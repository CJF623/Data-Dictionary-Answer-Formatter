namespace Data_Dictionary_Answers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddAnswer = new System.Windows.Forms.Button();
            this.AnswerInput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FormattedAnswers = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAnswer
            // 
            this.AddAnswer.Location = new System.Drawing.Point(981, 779);
            this.AddAnswer.Name = "AddAnswer";
            this.AddAnswer.Size = new System.Drawing.Size(214, 103);
            this.AddAnswer.TabIndex = 2;
            this.AddAnswer.Text = "Add Answer";
            this.AddAnswer.UseVisualStyleBackColor = true;
            this.AddAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
            // 
            // AnswerInput
            // 
            this.AnswerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AnswerInput.Location = new System.Drawing.Point(13, 779);
            this.AnswerInput.Name = "AnswerInput";
            this.AnswerInput.Size = new System.Drawing.Size(962, 103);
            this.AnswerInput.TabIndex = 3;
            this.AnswerInput.Text = "";
            this.AnswerInput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.AnswerInput.Enter += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 387);
            this.button1.TabIndex = 4;
            this.button1.Text = "Copy Formatted Answers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(827, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(981, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 235);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear Formatted Answers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormattedAnswers
            // 
            this.FormattedAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormattedAnswers.Location = new System.Drawing.Point(13, 15);
            this.FormattedAnswers.Name = "FormattedAnswers";
            this.FormattedAnswers.Size = new System.Drawing.Size(962, 758);
            this.FormattedAnswers.TabIndex = 10;
            this.FormattedAnswers.Text = "";
            this.FormattedAnswers.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.AddAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 905);
            this.Controls.Add(this.FormattedAnswers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnswerInput);
            this.Controls.Add(this.AddAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddAnswer;
        private System.Windows.Forms.RichTextBox AnswerInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox FormattedAnswers;
    }
}

