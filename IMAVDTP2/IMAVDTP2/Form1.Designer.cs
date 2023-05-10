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
            textToSpeechBox = new RichTextBox();
            label1 = new Label();
            speakBtn = new Button();
            resumeBtn = new Button();
            stopBtn = new Button();
            pauseBtn = new Button();
            label2 = new Label();
            englishOnBtn = new RadioButton();
            portugueseOnBtn = new RadioButton();
            groupBox1 = new GroupBox();
            label3 = new Label();
            speechToTxtBox = new RichTextBox();
            speechToTxtBtn = new Button();
            stopSpeakingBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textToSpeechBox
            // 
            textToSpeechBox.Location = new Point(8, 46);
            textToSpeechBox.Margin = new Padding(2);
            textToSpeechBox.Name = "textToSpeechBox";
            textToSpeechBox.Size = new Size(708, 102);
            textToSpeechBox.TabIndex = 0;
            textToSpeechBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Write text";
            // 
            // speakBtn
            // 
            speakBtn.Location = new Point(8, 150);
            speakBtn.Margin = new Padding(2);
            speakBtn.Name = "speakBtn";
            speakBtn.Size = new Size(78, 20);
            speakBtn.TabIndex = 2;
            speakBtn.Text = "Speak";
            speakBtn.UseVisualStyleBackColor = true;
            speakBtn.Click += speakBtn_Click;
            // 
            // resumeBtn
            // 
            resumeBtn.Location = new Point(134, 150);
            resumeBtn.Margin = new Padding(2);
            resumeBtn.Name = "resumeBtn";
            resumeBtn.Size = new Size(78, 20);
            resumeBtn.TabIndex = 3;
            resumeBtn.Text = "Resume";
            resumeBtn.UseVisualStyleBackColor = true;
            resumeBtn.Click += resumeBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(380, 150);
            stopBtn.Margin = new Padding(2);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(78, 20);
            stopBtn.TabIndex = 4;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // pauseBtn
            // 
            pauseBtn.Location = new Point(256, 150);
            pauseBtn.Margin = new Padding(2);
            pauseBtn.Name = "pauseBtn";
            pauseBtn.Size = new Size(78, 20);
            pauseBtn.TabIndex = 5;
            pauseBtn.Text = "Pause";
            pauseBtn.UseVisualStyleBackColor = true;
            pauseBtn.Click += pauseBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 6;
            label2.Text = "Text to Speech";
            // 
            // englishOnBtn
            // 
            englishOnBtn.AutoSize = true;
            englishOnBtn.Location = new Point(13, 18);
            englishOnBtn.Margin = new Padding(2);
            englishOnBtn.Name = "englishOnBtn";
            englishOnBtn.Size = new Size(57, 19);
            englishOnBtn.TabIndex = 7;
            englishOnBtn.TabStop = true;
            englishOnBtn.Text = "en-US";
            englishOnBtn.UseVisualStyleBackColor = true;
            englishOnBtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // portugueseOnBtn
            // 
            portugueseOnBtn.AutoSize = true;
            portugueseOnBtn.Location = new Point(13, 39);
            portugueseOnBtn.Margin = new Padding(2);
            portugueseOnBtn.Name = "portugueseOnBtn";
            portugueseOnBtn.Size = new Size(54, 19);
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
            groupBox1.Location = new Point(648, 333);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(124, 68);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Language";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 180);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 12;
            label3.Text = "Speech to Text";
            // 
            // speechToTxtBox
            // 
            speechToTxtBox.Location = new Point(8, 205);
            speechToTxtBox.Margin = new Padding(2);
            speechToTxtBox.Name = "speechToTxtBox";
            speechToTxtBox.Size = new Size(708, 102);
            speechToTxtBox.TabIndex = 10;
            speechToTxtBox.Text = "";
            // 
            // speechToTxtBtn
            // 
            speechToTxtBtn.Location = new Point(8, 309);
            speechToTxtBtn.Margin = new Padding(2);
            speechToTxtBtn.Name = "speechToTxtBtn";
            speechToTxtBtn.Size = new Size(128, 26);
            speechToTxtBtn.TabIndex = 13;
            speechToTxtBtn.Text = "Start Speaking";
            speechToTxtBtn.UseVisualStyleBackColor = true;
            speechToTxtBtn.Click += speechToTxtBtn_Click;
            // 
            // stopSpeakingBtn
            // 
            stopSpeakingBtn.Location = new Point(140, 309);
            stopSpeakingBtn.Margin = new Padding(2);
            stopSpeakingBtn.Name = "stopSpeakingBtn";
            stopSpeakingBtn.Size = new Size(128, 26);
            stopSpeakingBtn.TabIndex = 14;
            stopSpeakingBtn.Text = "Stop Speaking";
            stopSpeakingBtn.UseVisualStyleBackColor = true;
            stopSpeakingBtn.Click += stopSpeakingBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 408);
            Controls.Add(stopSpeakingBtn);
            Controls.Add(speechToTxtBtn);
            Controls.Add(label3);
            Controls.Add(speechToTxtBox);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(pauseBtn);
            Controls.Add(stopBtn);
            Controls.Add(resumeBtn);
            Controls.Add(speakBtn);
            Controls.Add(label1);
            Controls.Add(textToSpeechBox);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textToSpeechBox;
        private Label label1;
        private Button speakBtn;
        private Button resumeBtn;
        private Button stopBtn;
        private Button pauseBtn;
        private Label label2;
        private RadioButton englishOnBtn;
        private RadioButton portugueseOnBtn;
        private GroupBox groupBox1;
        private Label label3;
        private RichTextBox speechToTxtBox;
        private Button speechToTxtBtn;
        private Button stopSpeakingBtn;
    }
}