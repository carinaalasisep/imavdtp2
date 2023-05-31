using Google.Cloud.Speech.V1;
using IMAVDTP2.CropperHelper;
using IMAVDTP2.DrawerHelper;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;
using VisioForge.Libs.NAudio.Wave;
using VisioForge.Libs.ZXing;

namespace IMAVDTP2
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer speechSynthesizerObj;
        private string culture = "en-US";
        private PromptBuilder builder;
        private SpeechClient speech;
        private RecognitionConfig config;
        private BufferedWaveProvider bwp;
        private Drawer drawer = new Drawer();
        private List<CustomizedPanel> createdPanels = new List<CustomizedPanel>();
        private List<string> possibleShapes = new List<string> { "square", "triangle", "circle", "star" };
        private List<string> possibleCommands = new List<string> { "rotate", "grow", "shrink", "duplicate", "move" };
        private List<string> directions = new List<string> { "right", "left", "up", "down" };
        private List<RotatablePictureBox> pictureBoxList = new List<RotatablePictureBox>();

        WaveIn waveIn;
        WaveFileWriter writer;
        string output = "audio.raw";

        public Form1()
        {
            this.culture = "en-US";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            this.builder = new PromptBuilder(new System.Globalization.CultureInfo(culture));
            resumeBtn.Enabled = false;
            pauseBtn.Enabled = false;
            stopBtn.Enabled = false;

            this.speech = new SpeechClientBuilder
            {
                CredentialsPath = "../../../credentials.json"
            }.Build();
            this.config = new RecognitionConfig
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
                SampleRateHertz = 16000,
                LanguageCode = LanguageCodes.English.UnitedStates
            };
        }

        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }


        private void resumeBtn_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                if (speechSynthesizerObj.State == SynthesizerState.Paused)
                {
                    //Resumes the SpeechSynthesizer object after it has been paused.   
                    speechSynthesizerObj.Resume();
                    resumeBtn.Enabled = false;
                    speakBtn.Enabled = true;
                }
            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                //Gets the current speaking state of the SpeechSynthesizer object.   
                if (speechSynthesizerObj.State == SynthesizerState.Speaking)
                {
                    //Pauses the SpeechSynthesizer object.   
                    speechSynthesizerObj.Pause();
                    resumeBtn.Enabled = true;
                    speakBtn.Enabled = false;
                }
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                //Disposes the SpeechSynthesizer object   
                speechSynthesizerObj.Dispose();
                speakBtn.Enabled = true;
                resumeBtn.Enabled = false;
                pauseBtn.Enabled = false;
                stopBtn.Enabled = false;
            }
        }

        private void speakBtn_Click(object sender, EventArgs e)
        {
            //Disposes the SpeechSynthesizer object   
            speechSynthesizerObj.Dispose();
            builder.ClearContent();
            if (textToSpeechBox.Text != "")
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                //Asynchronously speaks the contents present in RichTextBox   
                builder.AppendText(textToSpeechBox.Text);
                speechSynthesizerObj.SpeakAsync(builder);
                pauseBtn.Enabled = true;
                stopBtn.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.culture = "en-US";
            builder = new PromptBuilder(new System.Globalization.CultureInfo(culture));
            speechSynthesizerObj = new SpeechSynthesizer();
            speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0,
                new System.Globalization.CultureInfo(culture));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.culture = "pt-BR";
            builder = new PromptBuilder(new System.Globalization.CultureInfo(culture));
            speechSynthesizerObj = new SpeechSynthesizer();
            speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0,
              new System.Globalization.CultureInfo(culture)
              );
            this.builder = new PromptBuilder(new System.Globalization.CultureInfo(culture));
        }

        private void speechToTxtBtn_Click(object sender, EventArgs e)
        {
            if (WaveIn.DeviceCount < 1)
            {
                MessageBox.Show("No microphone!");
                return;
            }
            waveIn = new WaveIn();
            waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);
            waveIn.WaveFormat = new WaveFormat(16000, 1);
            bwp = new BufferedWaveProvider(waveIn.WaveFormat);
            bwp.DiscardOnBufferOverflow = true;
            waveIn.StartRecording();
            speechToTxtBtn.BackColor = System.Drawing.Color.Green;

        }

        private void stopSpeakingBtn_Click(object sender, EventArgs e)
        {
            speechToTxtBtn.BackColor = System.Drawing.Color.Transparent;
            waveIn.StopRecording();
            if (File.Exists("audio.raw"))
                File.Delete("audio.raw");
            writer = new WaveFileWriter(output, waveIn.WaveFormat);

            var buffer = new byte[bwp.BufferLength];
            var offset = 0;
            var count = bwp.BufferLength;

            var read = bwp.Read(buffer, offset, count);
            if (count > 0)
            {
                writer.Write(buffer, offset, read);
            }

            waveIn.Dispose();
            waveIn = null;
            writer.Close();
            writer = null;

            if (File.Exists("audio.raw"))
            {
                var response = this.speech.Recognize(new RecognitionConfig()
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                    SampleRateHertz = 16000,
                    LanguageCode = this.culture,
                }, RecognitionAudio.FromFile("audio.raw"));

                speechToTxtBox.Text = "";

                foreach (var result in response.Results)
                {
                    ApplyCommandsFromVoice(result);
                }
            }
            else
            {
                speechToTxtBox.Text = "Couldn't fetch any audio! ";
            }
        }

        private void ApplyCommandsFromVoice(SpeechRecognitionResult? result)
        {

            foreach (var alternative in result.Alternatives)
            {
                speechToTxtBox.AppendText(alternative.Transcript);

                var listOfWords = alternative.Transcript.ToLowerInvariant().Split(' ').ToList();

                var shape = possibleShapes.FirstOrDefault(s => listOfWords.Contains(s));
                var color = GetColorFromSpeech(listOfWords);
                var operation = possibleCommands.FirstOrDefault(s => listOfWords.Contains(s));
                var direction = directions.FirstOrDefault(s => listOfWords.Contains(s));
                // draw a new shape
                if (listOfWords.Contains("draw"))
                {
                    DrawNewShape(shape, color);

                    continue;
                }


                if (listOfWords.Contains("image") || listOfWords.Contains("imagem") || listOfWords.Contains("picture"))
                {
                    if (listOfWords.Contains("load") || listOfWords.Contains("carregar") || listOfWords.Contains("upload"))
                    {
                        LoadImage();

                        continue;
                    }
                    ApplyCommandsToExistingImages(operation, direction);

                }

                ApplyCommandsToExistingShapes(shape, color, operation, direction);
            }
        }

        private void ApplyCommandsToExistingShapes(string? shape, Color? color, string? operation, string? direction)
        {
            var affectedPanels = this.createdPanels.Where(p => p.shape == shape);

            foreach (var panel in affectedPanels)
            {
                // mudar a cor APENAS
                if (color != null && operation == null)
                {
                    panel.color = color.Value;
                    panel.Invalidate();
                    continue;
                }

                // faz a operação 
                if (operation != null)
                {
                    if (color != null && panel.color != color)
                    {
                        continue;
                    }

                    ApplyOperation(operation, panel, direction);
                }
            }
        }

        private void DrawNewShape(string? shape, Color? color)
        {
            if (shape != null)
            {
                this.createdPanels.Add(drawer.Draw(this.canvas, shape, color ?? Color.FromKnownColor(KnownColor.Black)));
            }
        }

        private void ApplyOperation(string? operation, CustomizedPanel? panel, string? direction)
        {
            if (operation == "rotate")
            {
                if (direction == null || (direction != null && direction == "right"))
                {
                    RotatePanel(panel, 15f);
                }
                if (direction != null && direction == "left")
                {
                    RotatePanel(panel, -15f);
                }
            }

            if (operation == "grow")
            {
                GrowPanel(panel);
            }

            if (operation == "shrink")
            {
                ShrinkPanel(panel);
            }

            if (operation == "duplicate")
            {
                ClonePanelAndAddToCanvas(panel);
            }
        }

        private void ClonePanelAndAddToCanvas(CustomizedPanel? panel)
        {
            var newPanel = drawer.Draw(this.canvas, panel.shape, panel.color, panel.angle);
            panel.Invalidate();
            this.canvas.Controls.Add(newPanel);
        }

        private static void ShrinkPanel(CustomizedPanel? panel)
        {
            var shrinkFactor = 2;
            panel.Width /= shrinkFactor;
            panel.Height /= shrinkFactor;
            panel.Invalidate();
        }

        private static void GrowPanel(CustomizedPanel? panel)
        {
            var growthFactor = 2;
            panel.Width *= growthFactor;
            panel.Height *= growthFactor;
            panel.Invalidate();
        }

        private static void RotatePanel(CustomizedPanel? panel, float newAngle)
        {
            panel.angle += newAngle;
            panel.Invalidate();
        }

        private Color? GetColorFromSpeech(List<string> listOfWords)
        {
            var enumNameList = new List<string>();
            foreach (int i in Enum.GetValues(typeof(KnownColor)))
            {
                enumNameList.Add(Enum.GetName(typeof(KnownColor), i).ToLowerInvariant());
            }

            var color = enumNameList.FirstOrDefault(s => listOfWords.Contains(s));

            if (color != null)
            {
                var colorEnum = (KnownColor)Enum.Parse(typeof(KnownColor), color, true);
                return Color.FromKnownColor(colorEnum);
            }

            return null;
        }


        #region Compare Input with Output
        private void checkOutput_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textToSpeechBox.Text) || string.IsNullOrEmpty(speechToTxtBox.Text))
            {
                MessageBox.Show("You need to write an input or record your speech!");
            }
            else
            {
                var input = textToSpeechBox.Text.Split(" ");
                var output = speechToTxtBox.Text.Split(" ");

                speechToTxtBox.SelectAll();

                for (var i = 0; i < input.Length; i++)
                {
                    if (!input[i].ToLower().Equals(output[i].ToLower()))
                    {
                        speechToTxtBox.SelectionColor = Color.Red;
                        speechToTxtBox.SelectedText = output[i] + " ";
                    }
                    else
                    {
                        speechToTxtBox.SelectionColor = Color.Black;
                        speechToTxtBox.SelectedText = output[i] + " ";
                    }
                }

                if (output.Length > input.Length)
                {
                    for (var i = input.Length; i < output.Length; i++)
                    {
                        speechToTxtBox.SelectionColor = Color.Red;
                        speechToTxtBox.SelectedText = output[i] + " ";
                    }
                }

                speechToTxtBox.Select(0, 0);
            }
        }
        #endregion

        #region Load image
        private void LoadImage()
        {
            var openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                RotatablePictureBox pictureBox = new RotatablePictureBox();
                pictureBox.Size = new Size(200, 200);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(openFile.FileName);

                canvas.Controls.Add(pictureBox);
                this.pictureBoxList.Add(pictureBox);
            }
        }


        private void ApplyCommandsToExistingImages(string? operation, string? direction)
        {
            if (operation == "rotate")
            {
                if (direction == null || (direction != null && direction == "right"))
                {
                    RotateImages(45);
                }
                if (direction != null && direction == "left")
                {
                    RotateImages(-45);
                }
            }

            if (operation == "move")
            {
                SlideImages(direction);
            }

            if (operation == "grow")
            {
                GrowImages();
            }

            if (operation == "shrink")
            {
                ShrinkImages();
            }

            if (operation == "duplicate")
            {
                DuplicateImages();
            }
        }

        private void SlideImages(string? direction)
        {
            if (this.pictureBoxList.Count <= this.canvas.Controls.Count)
            {
                foreach (var control in this.canvas.Controls)
                {
                    if (control is RotatablePictureBox pictureBox)
                    {
                        if (direction == null || (direction != null && direction == "right"))
                        {
                            pictureBox.Location = new Point(pictureBox.Location.X + 100, pictureBox.Location.Y);
                        }
                        if (direction != null && direction == "left")
                        {
                            pictureBox.Location = new Point(pictureBox.Location.X - 100, pictureBox.Location.Y);
                        }
                        if (direction != null && direction == "up")
                        {
                            pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + 100);
                        }
                        if (direction != null && direction == "down")
                        {
                            pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y - 100);
                        }
                    }
                }
                this.canvas.PerformLayout();
            }
        }

        private void RotateImages(float angle)
        {
            if (this.pictureBoxList.Count <= this.canvas.Controls.Count)
            {
                foreach (var control in this.canvas.Controls)
                {
                    if (control is RotatablePictureBox pictureBox)
                    {
                        pictureBox.RotationAngle += angle;
                    }
                }
                this.canvas.PerformLayout();
            }
        }

        private void GrowImages()
        {
            if (this.pictureBoxList.Count <= this.canvas.Controls.Count)
            {
                foreach (var control in this.canvas.Controls)
                {
                    if (control is RotatablePictureBox pictureBox)
                    {
                        pictureBox.Width *= 2;
                        pictureBox.Height *= 2;
                    }
                }
                this.canvas.PerformLayout();
            }
        }

        private void ShrinkImages()
        {
            if (this.pictureBoxList.Count <= this.canvas.Controls.Count)
            {
                foreach (var control in this.canvas.Controls)
                {
                    if (control is RotatablePictureBox pictureBox)
                    {
                        pictureBox.Width /= 2;
                        pictureBox.Height /= 2;
                    }
                }
                this.canvas.PerformLayout();
            }
        }

        private void DuplicateImages()
        {
            if (this.pictureBoxList.Count <= this.canvas.Controls.Count)
            {
                List<RotatablePictureBox> duplicatedImages = new List<RotatablePictureBox>();
                foreach (var control in this.canvas.Controls)
                {
                    if (control is RotatablePictureBox pictureBox)
                    {
                        RotatablePictureBox duplicatePictureBox = new RotatablePictureBox();
                        duplicatePictureBox.Image = pictureBox.Image;
                        duplicatePictureBox.SizeMode = pictureBox.SizeMode;
                        duplicatePictureBox.Size = pictureBox.Size;

                        duplicatedImages.Add(duplicatePictureBox);
                    }
                }
                this.canvas.Controls.AddRange(duplicatedImages.ToArray());
                this.canvas.PerformLayout();
            }
        }
        #endregion

        private void testBtn_Click(object sender, EventArgs e)
        {
            var shape = "triangle";
            var color = Color.Green;
            var color2 = Color.Blue;
            var angle = 0f;
            this.createdPanels.Add(drawer.Draw(this.canvas, shape, color, angle));

            this.createdPanels.Add(drawer.Draw(this.canvas, shape, color2, angle));
        }

        private void growBtn_Click(object sender, EventArgs e)
        {
            //TODO: REDRAW OF THE SHAPE
            var growthFactor = 2;

            foreach (var panel in createdPanels)
            {
                panel.Width *= growthFactor;
                panel.Height *= growthFactor;
                panel.Invalidate();
            }
        }

        private void shrinkBtn_Click(object sender, EventArgs e)
        {
            //TODO: REDRAW OF THE SHAPE
            var shrinkFactor = 2;
            foreach (var panel in createdPanels)
            {
                panel.Width /= shrinkFactor;
                panel.Height /= shrinkFactor;
                panel.Invalidate();
            }
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            var newAngle = 15f;
            foreach (var panel in createdPanels)
            {
                panel.angle += newAngle;
                panel.Invalidate();
            }
        }

        private void cropBtn_Click(object sender, EventArgs e)
        {
            //only works with panels containing background images
            string option = "upper left corner";

            foreach (var panel in createdPanels)
            {
                Cropper.ApplyCroppedImageToPanel(panel, option);
            }
        }

        private void duplicate_Click(object sender, EventArgs e)
        {
            var newPanels = new List<CustomizedPanel>();
            newPanels.AddRange(createdPanels);

            foreach (var panel in createdPanels)
            {
                var newPanel = drawer.Draw(this.canvas, panel.shape, panel.color, panel.angle);
                newPanels.Add(newPanel);
                panel.Invalidate();
            }

            createdPanels = newPanels;

            foreach (var panel in newPanels)
            {
                this.canvas.Controls.Add(panel);
            }
        }
    }
}