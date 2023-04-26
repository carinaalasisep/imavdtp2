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
            this.textToSpeechBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speakBtn = new System.Windows.Forms.Button();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.englishOnBtn = new System.Windows.Forms.RadioButton();
            this.portugueseOnBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textToSpeechBox
            // 
            this.textToSpeechBox.Location = new System.Drawing.Point(11, 76);
            this.textToSpeechBox.Name = "textToSpeechBox";
            this.textToSpeechBox.Size = new System.Drawing.Size(1009, 168);
            this.textToSpeechBox.TabIndex = 0;
            this.textToSpeechBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Write text";
            // 
            // speakBtn
            // 
            this.speakBtn.Location = new System.Drawing.Point(11, 250);
            this.speakBtn.Name = "speakBtn";
            this.speakBtn.Size = new System.Drawing.Size(112, 34);
            this.speakBtn.TabIndex = 2;
            this.speakBtn.Text = "Speak";
            this.speakBtn.UseVisualStyleBackColor = true;
            this.speakBtn.Click += new System.EventHandler(this.speakBtn_Click);
            // 
            // resumeBtn
            // 
            this.resumeBtn.Location = new System.Drawing.Point(191, 250);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(112, 34);
            this.resumeBtn.TabIndex = 3;
            this.resumeBtn.Text = "Resume";
            this.resumeBtn.UseVisualStyleBackColor = true;
            this.resumeBtn.Click += new System.EventHandler(this.resumeBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(543, 250);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(112, 34);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(365, 250);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(112, 34);
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Text to Speech";
            // 
            // englishOnBtn
            // 
            this.englishOnBtn.AutoSize = true;
            this.englishOnBtn.Location = new System.Drawing.Point(18, 30);
            this.englishOnBtn.Name = "englishOnBtn";
            this.englishOnBtn.Size = new System.Drawing.Size(85, 29);
            this.englishOnBtn.TabIndex = 7;
            this.englishOnBtn.TabStop = true;
            this.englishOnBtn.Text = "en-US";
            this.englishOnBtn.UseVisualStyleBackColor = true;
            this.englishOnBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // portugueseOnBtn
            // 
            this.portugueseOnBtn.AutoSize = true;
            this.portugueseOnBtn.Location = new System.Drawing.Point(18, 65);
            this.portugueseOnBtn.Name = "portugueseOnBtn";
            this.portugueseOnBtn.Size = new System.Drawing.Size(80, 29);
            this.portugueseOnBtn.TabIndex = 8;
            this.portugueseOnBtn.TabStop = true;
            this.portugueseOnBtn.Text = "pt-PT";
            this.portugueseOnBtn.UseVisualStyleBackColor = true;
            this.portugueseOnBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.englishOnBtn);
            this.groupBox1.Controls.Add(this.portugueseOnBtn);
            this.groupBox1.Location = new System.Drawing.Point(862, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 113);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.resumeBtn);
            this.Controls.Add(this.speakBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textToSpeechBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}