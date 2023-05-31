namespace IMAVDTP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textToSpeechBox = new RichTextBox();
            speakBtn = new Button();
            resumeBtn = new Button();
            stopBtn = new Button();
            pauseBtn = new Button();
            englishOnBtn = new RadioButton();
            portugueseOnBtn = new RadioButton();
            groupBox1 = new GroupBox();
            speechToTxtBox = new RichTextBox();
            speechToTxtBtn = new Button();
            stopSpeakingBtn = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            compareIO = new Button();
            testBtn = new Button();
            canvas = new FlowLayoutPanel();
            growBtn = new Button();
            shrinkBtn = new Button();
            divideTwo = new Button();
            cropBtn = new Button();
            rotateBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // textToSpeechBox
            // 
            textToSpeechBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textToSpeechBox.Location = new Point(7, 25);
            textToSpeechBox.Margin = new Padding(3, 2, 3, 2);
            textToSpeechBox.Name = "textToSpeechBox";
            textToSpeechBox.Size = new Size(584, 109);
            textToSpeechBox.TabIndex = 0;
            textToSpeechBox.Text = "";
            // 
            // speakBtn
            // 
            speakBtn.Image = (Image)resources.GetObject("speakBtn.Image");
            speakBtn.Location = new Point(6, 26);
            speakBtn.Margin = new Padding(3, 2, 3, 2);
            speakBtn.Name = "speakBtn";
            speakBtn.Size = new Size(57, 33);
            speakBtn.TabIndex = 2;
            speakBtn.UseVisualStyleBackColor = true;
            speakBtn.Click += speakBtn_Click;
            // 
            // resumeBtn
            // 
            resumeBtn.Anchor = AnchorStyles.Top;
            resumeBtn.Image = (Image)resources.GetObject("resumeBtn.Image");
            resumeBtn.Location = new Point(105, 26);
            resumeBtn.Margin = new Padding(3, 2, 3, 2);
            resumeBtn.Name = "resumeBtn";
            resumeBtn.Size = new Size(57, 33);
            resumeBtn.TabIndex = 3;
            resumeBtn.UseVisualStyleBackColor = true;
            resumeBtn.Click += resumeBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Anchor = AnchorStyles.Top;
            stopBtn.Image = (Image)resources.GetObject("stopBtn.Image");
            stopBtn.Location = new Point(261, 26);
            stopBtn.Margin = new Padding(3, 2, 3, 2);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(57, 33);
            stopBtn.TabIndex = 4;
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // pauseBtn
            // 
            pauseBtn.Anchor = AnchorStyles.Top;
            pauseBtn.Image = (Image)resources.GetObject("pauseBtn.Image");
            pauseBtn.Location = new Point(182, 26);
            pauseBtn.Margin = new Padding(3, 2, 3, 2);
            pauseBtn.Name = "pauseBtn";
            pauseBtn.Size = new Size(57, 33);
            pauseBtn.TabIndex = 5;
            pauseBtn.UseVisualStyleBackColor = true;
            pauseBtn.Click += pauseBtn_Click;
            // 
            // englishOnBtn
            // 
            englishOnBtn.Anchor = AnchorStyles.Top;
            englishOnBtn.AutoSize = true;
            englishOnBtn.Location = new Point(22, 19);
            englishOnBtn.Margin = new Padding(3, 2, 3, 2);
            englishOnBtn.Name = "englishOnBtn";
            englishOnBtn.Size = new Size(65, 19);
            englishOnBtn.TabIndex = 7;
            englishOnBtn.TabStop = true;
            englishOnBtn.Text = "en-US";
            englishOnBtn.UseVisualStyleBackColor = true;
            englishOnBtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // portugueseOnBtn
            // 
            portugueseOnBtn.Anchor = AnchorStyles.Top;
            portugueseOnBtn.AutoSize = true;
            portugueseOnBtn.Location = new Point(22, 42);
            portugueseOnBtn.Margin = new Padding(3, 2, 3, 2);
            portugueseOnBtn.Name = "portugueseOnBtn";
            portugueseOnBtn.Size = new Size(59, 19);
            portugueseOnBtn.TabIndex = 8;
            portugueseOnBtn.TabStop = true;
            portugueseOnBtn.Text = "pt-PT";
            portugueseOnBtn.UseVisualStyleBackColor = true;
            portugueseOnBtn.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(englishOnBtn);
            groupBox1.Controls.Add(portugueseOnBtn);
            groupBox1.Location = new Point(359, 31);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(98, 73);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Language";
            // 
            // speechToTxtBox
            // 
            speechToTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            speechToTxtBox.Location = new Point(6, 29);
            speechToTxtBox.Margin = new Padding(3, 2, 3, 2);
            speechToTxtBox.Name = "speechToTxtBox";
            speechToTxtBox.Size = new Size(585, 115);
            speechToTxtBox.TabIndex = 10;
            speechToTxtBox.Text = "";
            // 
            // speechToTxtBtn
            // 
            speechToTxtBtn.Image = (Image)resources.GetObject("speechToTxtBtn.Image");
            speechToTxtBtn.Location = new Point(6, 29);
            speechToTxtBtn.Margin = new Padding(3, 2, 3, 2);
            speechToTxtBtn.Name = "speechToTxtBtn";
            speechToTxtBtn.Size = new Size(57, 33);
            speechToTxtBtn.TabIndex = 13;
            speechToTxtBtn.UseVisualStyleBackColor = true;
            speechToTxtBtn.Click += speechToTxtBtn_Click;
            // 
            // stopSpeakingBtn
            // 
            stopSpeakingBtn.Anchor = AnchorStyles.Top;
            stopSpeakingBtn.Image = (Image)resources.GetObject("stopSpeakingBtn.Image");
            stopSpeakingBtn.Location = new Point(104, 29);
            stopSpeakingBtn.Margin = new Padding(3, 2, 3, 2);
            stopSpeakingBtn.Name = "stopSpeakingBtn";
            stopSpeakingBtn.Size = new Size(57, 33);
            stopSpeakingBtn.TabIndex = 14;
            stopSpeakingBtn.UseVisualStyleBackColor = true;
            stopSpeakingBtn.Click += stopSpeakingBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textToSpeechBox);
            groupBox2.Location = new Point(456, 31);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(598, 147);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(speechToTxtBox);
            groupBox3.Location = new Point(456, 189);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(599, 156);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ouput";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(speakBtn);
            groupBox4.Controls.Add(resumeBtn);
            groupBox4.Controls.Add(pauseBtn);
            groupBox4.Controls.Add(stopBtn);
            groupBox4.Location = new Point(15, 31);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(335, 147);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Text-to-Speech";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(compareIO);
            groupBox5.Controls.Add(speechToTxtBtn);
            groupBox5.Controls.Add(stopSpeakingBtn);
            groupBox5.Location = new Point(16, 189);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(334, 156);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Speech-to-Text";
            // 
            // compareIO
            // 
            compareIO.Anchor = AnchorStyles.Top;
            compareIO.Location = new Point(6, 76);
            compareIO.Name = "compareIO";
            compareIO.Size = new Size(155, 44);
            compareIO.TabIndex = 15;
            compareIO.Text = "Compare Input/Output";
            compareIO.UseVisualStyleBackColor = true;
            compareIO.Click += checkOutput_Click;
            // 
            // testBtn
            // 
            testBtn.Location = new Point(356, 311);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(92, 34);
            testBtn.TabIndex = 20;
            testBtn.Text = "TEST";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += testBtn_Click;
            // 
            // canvas
            // 
            canvas.BackColor = Color.White;
            canvas.ForeColor = Color.Transparent;
            canvas.Location = new Point(15, 351);
            canvas.Name = "canvas";
            canvas.Size = new Size(1039, 271);
            canvas.TabIndex = 21;
            // 
            // growBtn
            // 
            growBtn.Location = new Point(356, 109);
            growBtn.Name = "growBtn";
            growBtn.Size = new Size(92, 34);
            growBtn.TabIndex = 22;
            growBtn.Text = "grow";
            growBtn.UseVisualStyleBackColor = true;
            growBtn.Click += growBtn_Click;
            // 
            // shrinkBtn
            // 
            shrinkBtn.Location = new Point(356, 149);
            shrinkBtn.Name = "shrinkBtn";
            shrinkBtn.Size = new Size(92, 34);
            shrinkBtn.TabIndex = 23;
            shrinkBtn.Text = "shrink";
            shrinkBtn.UseVisualStyleBackColor = true;
            shrinkBtn.Click += shrinkBtn_Click;
            // 
            // divideTwo
            // 
            divideTwo.Location = new Point(356, 271);
            divideTwo.Name = "divideTwo";
            divideTwo.Size = new Size(92, 34);
            divideTwo.TabIndex = 24;
            divideTwo.Text = "/2";
            divideTwo.UseVisualStyleBackColor = true;
            divideTwo.Click += duplicate_Click;
            // 
            // cropBtn
            // 
            cropBtn.Location = new Point(356, 231);
            cropBtn.Name = "cropBtn";
            cropBtn.Size = new Size(92, 34);
            cropBtn.TabIndex = 25;
            cropBtn.Text = "crop";
            cropBtn.UseVisualStyleBackColor = true;
            cropBtn.Click += cropBtn_Click;
            // 
            // rotateBtn
            // 
            rotateBtn.Location = new Point(356, 191);
            rotateBtn.Name = "rotateBtn";
            rotateBtn.Size = new Size(92, 34);
            rotateBtn.TabIndex = 26;
            rotateBtn.Text = "rotate";
            rotateBtn.UseVisualStyleBackColor = true;
            rotateBtn.Click += rotateBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 634);
            Controls.Add(rotateBtn);
            Controls.Add(cropBtn);
            Controls.Add(divideTwo);
            Controls.Add(shrinkBtn);
            Controls.Add(growBtn);
            Controls.Add(canvas);
            Controls.Add(testBtn);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox textToSpeechBox;
        private Button speakBtn;
        private Button resumeBtn;
        private Button stopBtn;
        private Button pauseBtn;
        private RadioButton englishOnBtn;
        private RadioButton portugueseOnBtn;
        private GroupBox groupBox1;
        private RichTextBox speechToTxtBox;
        private Button speechToTxtBtn;
        private Button stopSpeakingBtn;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button compareIO;
        private Button testBtn;
        private FlowLayoutPanel canvas;
        private Button growBtn;
        private Button shrinkBtn;
        private Button divideTwo;
        private Button cropBtn;
        private Button rotateBtn;
    }
}