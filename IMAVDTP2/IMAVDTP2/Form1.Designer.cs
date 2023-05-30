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
            this.textToSpeechBox = new System.Windows.Forms.RichTextBox();
            this.speakBtn = new System.Windows.Forms.Button();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.englishOnBtn = new System.Windows.Forms.RadioButton();
            this.portugueseOnBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.speechToTxtBox = new System.Windows.Forms.RichTextBox();
            this.speechToTxtBtn = new System.Windows.Forms.Button();
            this.stopSpeakingBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.compareIO = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.FlowLayoutPanel();
            this.growBtn = new System.Windows.Forms.Button();
            this.shrinkBtn = new System.Windows.Forms.Button();
            this.divideTwo = new System.Windows.Forms.Button();
            this.divideFour = new System.Windows.Forms.Button();
            this.rotateBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textToSpeechBox
            // 
            this.textToSpeechBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textToSpeechBox.Location = new System.Drawing.Point(7, 25);
            this.textToSpeechBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textToSpeechBox.Name = "textToSpeechBox";
            this.textToSpeechBox.Size = new System.Drawing.Size(584, 109);
            this.textToSpeechBox.TabIndex = 0;
            this.textToSpeechBox.Text = "";
            // 
            // speakBtn
            // 
            this.speakBtn.Image = ((System.Drawing.Image)(resources.GetObject("speakBtn.Image")));
            this.speakBtn.Location = new System.Drawing.Point(6, 26);
            this.speakBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speakBtn.Name = "speakBtn";
            this.speakBtn.Size = new System.Drawing.Size(57, 33);
            this.speakBtn.TabIndex = 2;
            this.speakBtn.UseVisualStyleBackColor = true;
            // 
            // resumeBtn
            // 
            this.resumeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resumeBtn.Image = ((System.Drawing.Image)(resources.GetObject("resumeBtn.Image")));
            this.resumeBtn.Location = new System.Drawing.Point(105, 26);
            this.resumeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(57, 33);
            this.resumeBtn.TabIndex = 3;
            this.resumeBtn.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.Location = new System.Drawing.Point(261, 26);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(57, 33);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // pauseBtn
            // 
            this.pauseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pauseBtn.Image = ((System.Drawing.Image)(resources.GetObject("pauseBtn.Image")));
            this.pauseBtn.Location = new System.Drawing.Point(182, 26);
            this.pauseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(57, 33);
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.UseVisualStyleBackColor = true;
            // 
            // englishOnBtn
            // 
            this.englishOnBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.englishOnBtn.AutoSize = true;
            this.englishOnBtn.Location = new System.Drawing.Point(22, 19);
            this.englishOnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.englishOnBtn.Name = "englishOnBtn";
            this.englishOnBtn.Size = new System.Drawing.Size(91, 26);
            this.englishOnBtn.TabIndex = 7;
            this.englishOnBtn.TabStop = true;
            this.englishOnBtn.Text = "en-US";
            this.englishOnBtn.UseVisualStyleBackColor = true;
            // 
            // portugueseOnBtn
            // 
            this.portugueseOnBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.portugueseOnBtn.AutoSize = true;
            this.portugueseOnBtn.Location = new System.Drawing.Point(22, 42);
            this.portugueseOnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portugueseOnBtn.Name = "portugueseOnBtn";
            this.portugueseOnBtn.Size = new System.Drawing.Size(85, 26);
            this.portugueseOnBtn.TabIndex = 8;
            this.portugueseOnBtn.TabStop = true;
            this.portugueseOnBtn.Text = "pt-PT";
            this.portugueseOnBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.englishOnBtn);
            this.groupBox1.Controls.Add(this.portugueseOnBtn);
            this.groupBox1.Location = new System.Drawing.Point(359, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(98, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // speechToTxtBox
            // 
            this.speechToTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speechToTxtBox.Location = new System.Drawing.Point(6, 29);
            this.speechToTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speechToTxtBox.Name = "speechToTxtBox";
            this.speechToTxtBox.Size = new System.Drawing.Size(585, 115);
            this.speechToTxtBox.TabIndex = 10;
            this.speechToTxtBox.Text = "";
            // 
            // speechToTxtBtn
            // 
            this.speechToTxtBtn.Image = ((System.Drawing.Image)(resources.GetObject("speechToTxtBtn.Image")));
            this.speechToTxtBtn.Location = new System.Drawing.Point(6, 29);
            this.speechToTxtBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speechToTxtBtn.Name = "speechToTxtBtn";
            this.speechToTxtBtn.Size = new System.Drawing.Size(57, 33);
            this.speechToTxtBtn.TabIndex = 13;
            this.speechToTxtBtn.UseVisualStyleBackColor = true;
            // 
            // stopSpeakingBtn
            // 
            this.stopSpeakingBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stopSpeakingBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopSpeakingBtn.Image")));
            this.stopSpeakingBtn.Location = new System.Drawing.Point(104, 29);
            this.stopSpeakingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopSpeakingBtn.Name = "stopSpeakingBtn";
            this.stopSpeakingBtn.Size = new System.Drawing.Size(57, 33);
            this.stopSpeakingBtn.TabIndex = 14;
            this.stopSpeakingBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textToSpeechBox);
            this.groupBox2.Location = new System.Drawing.Point(456, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(598, 147);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.speechToTxtBox);
            this.groupBox3.Location = new System.Drawing.Point(456, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 156);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ouput";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.speakBtn);
            this.groupBox4.Controls.Add(this.resumeBtn);
            this.groupBox4.Controls.Add(this.pauseBtn);
            this.groupBox4.Controls.Add(this.stopBtn);
            this.groupBox4.Location = new System.Drawing.Point(15, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 147);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Text-to-Speech";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.compareIO);
            this.groupBox5.Controls.Add(this.speechToTxtBtn);
            this.groupBox5.Controls.Add(this.stopSpeakingBtn);
            this.groupBox5.Location = new System.Drawing.Point(16, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 156);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Speech-to-Text";
            // 
            // compareIO
            // 
            this.compareIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.compareIO.Location = new System.Drawing.Point(6, 76);
            this.compareIO.Name = "compareIO";
            this.compareIO.Size = new System.Drawing.Size(155, 44);
            this.compareIO.TabIndex = 15;
            this.compareIO.Text = "Compare Input/Output";
            this.compareIO.UseVisualStyleBackColor = true;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(356, 311);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(92, 34);
            this.testBtn.TabIndex = 20;
            this.testBtn.Text = "TEST";
            this.testBtn.UseVisualStyleBackColor = true;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.ForeColor = System.Drawing.Color.Transparent;
            this.canvas.Location = new System.Drawing.Point(15, 351);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1039, 271);
            this.canvas.TabIndex = 21;
            // 
            // growBtn
            // 
            this.growBtn.Location = new System.Drawing.Point(356, 109);
            this.growBtn.Name = "growBtn";
            this.growBtn.Size = new System.Drawing.Size(92, 34);
            this.growBtn.TabIndex = 22;
            this.growBtn.Text = "grow";
            this.growBtn.UseVisualStyleBackColor = true;
            // 
            // shrinkBtn
            // 
            this.shrinkBtn.Location = new System.Drawing.Point(356, 149);
            this.shrinkBtn.Name = "shrinkBtn";
            this.shrinkBtn.Size = new System.Drawing.Size(92, 34);
            this.shrinkBtn.TabIndex = 23;
            this.shrinkBtn.Text = "shrink";
            this.shrinkBtn.UseVisualStyleBackColor = true;
            // 
            // divideTwo
            // 
            this.divideTwo.Location = new System.Drawing.Point(356, 271);
            this.divideTwo.Name = "divideTwo";
            this.divideTwo.Size = new System.Drawing.Size(92, 34);
            this.divideTwo.TabIndex = 24;
            this.divideTwo.Text = "Duplicate";
            this.divideTwo.UseVisualStyleBackColor = true;
            // 
            // divideFour
            // 
            this.divideFour.Location = new System.Drawing.Point(356, 231);
            this.divideFour.Name = "divideFour";
            this.divideFour.Size = new System.Drawing.Size(92, 34);
            this.divideFour.TabIndex = 25;
            this.divideFour.Text = "/4";
            this.divideFour.UseVisualStyleBackColor = true;
            // 
            // rotateBtn
            // 
            this.rotateBtn.Location = new System.Drawing.Point(356, 191);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(92, 34);
            this.rotateBtn.TabIndex = 26;
            this.rotateBtn.Text = "rotate";
            this.rotateBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 634);
            this.Controls.Add(this.rotateBtn);
            this.Controls.Add(this.divideFour);
            this.Controls.Add(this.divideTwo);
            this.Controls.Add(this.shrinkBtn);
            this.Controls.Add(this.growBtn);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Button divideFour;
        private Button rotateBtn;
    }
}