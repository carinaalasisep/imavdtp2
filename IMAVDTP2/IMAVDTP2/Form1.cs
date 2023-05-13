using Google.Cloud.Speech.V1;
using Microsoft.VisualBasic.Devices;
using System.Speech.Synthesis;
using VisioForge.Libs.NAudio.Wave;

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

            //var speech = SpeechClient.Create();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.culture = "en-US";
            builder = new PromptBuilder(new System.Globalization.CultureInfo(culture));
            speechSynthesizerObj = new SpeechSynthesizer();
            speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0,
                new System.Globalization.CultureInfo(culture)
                );
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

            byte[] buffer = new byte[bwp.BufferLength];
            int offset = 0;
            int count = bwp.BufferLength;

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
                    LanguageCode = "en",
                }, RecognitionAudio.FromFile("audio.raw"));

                speechToTxtBox.Text = "";

                foreach (var result in response.Results)
                {
                    foreach (var alternative in result.Alternatives)
                    {
                        speechToTxtBox.AppendText(alternative.Transcript);
                    }
                }
            }
            else
            {
                speechToTxtBox.Text = "Couldnt fetch any audio! ";
            }
        }

        private void checkOutput_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textToSpeechBox.Text) || string.IsNullOrEmpty(speechToTxtBox.Text))
            {
                MessageBox.Show("You need to write an input or record your speech!");
            }
            else
            {
                string[] input = textToSpeechBox.Text.Split(" ");
                string[] output = speechToTxtBox.Text.Split(" ");

                speechToTxtBox.SelectAll();

                for (int i = 0; i < input.Length; i++)
                {
                    if (!input[i].ToLower().Equals(output[i].ToLower()))
                    {
                        speechToTxtBox.SelectionColor = Color.Red;
                        speechToTxtBox.SelectedText = output[i] + " ";
                    } else
                    {
                        speechToTxtBox.SelectionColor = Color.Black;
                        speechToTxtBox.SelectedText = output[i] + " ";
                    }
                }

                speechToTxtBox.Select(0, 0);
            }
        }
    }
}