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
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(543, 250);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(112, 34);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(365, 250);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(112, 34);
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.resumeBtn);
            this.Controls.Add(this.speakBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textToSpeechBox);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}