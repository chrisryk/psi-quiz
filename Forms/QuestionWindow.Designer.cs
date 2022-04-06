namespace Quiz.WindowsForms
{
    partial class QuestionWindow
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
            this.backQuestionButton = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.Label();
            this.answersPanel = new System.Windows.Forms.Panel();
            this.answerButton4 = new System.Windows.Forms.RadioButton();
            this.answerButton3 = new System.Windows.Forms.RadioButton();
            this.answerButton2 = new System.Windows.Forms.RadioButton();
            this.answerButton1 = new System.Windows.Forms.RadioButton();
            this.nextButton = new System.Windows.Forms.Button();
            this.answersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backQuestionButton
            // 
            this.backQuestionButton.Location = new System.Drawing.Point(12, 388);
            this.backQuestionButton.Name = "backQuestionButton";
            this.backQuestionButton.Size = new System.Drawing.Size(150, 50);
            this.backQuestionButton.TabIndex = 3;
            this.backQuestionButton.Text = "Wróć do menu";
            this.backQuestionButton.UseVisualStyleBackColor = true;
            this.backQuestionButton.Click += new System.EventHandler(this.backQuestionButton_Click);
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionText.Location = new System.Drawing.Point(12, 9);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(132, 46);
            this.questionText.TabIndex = 4;
            this.questionText.Text = "label1";
            // 
            // answersPanel
            // 
            this.answersPanel.Controls.Add(this.answerButton4);
            this.answersPanel.Controls.Add(this.answerButton3);
            this.answersPanel.Controls.Add(this.answerButton2);
            this.answersPanel.Controls.Add(this.answerButton1);
            this.answersPanel.Location = new System.Drawing.Point(12, 105);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(776, 240);
            this.answersPanel.TabIndex = 5;
            // 
            // answerButton4
            // 
            this.answerButton4.AutoSize = true;
            this.answerButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerButton4.Location = new System.Drawing.Point(8, 170);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(223, 41);
            this.answerButton4.TabIndex = 3;
            this.answerButton4.TabStop = true;
            this.answerButton4.Text = "radioButton1";
            this.answerButton4.UseVisualStyleBackColor = true;
            // 
            // answerButton3
            // 
            this.answerButton3.AutoSize = true;
            this.answerButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerButton3.Location = new System.Drawing.Point(8, 123);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(223, 41);
            this.answerButton3.TabIndex = 2;
            this.answerButton3.TabStop = true;
            this.answerButton3.Text = "radioButton1";
            this.answerButton3.UseVisualStyleBackColor = true;
            // 
            // answerButton2
            // 
            this.answerButton2.AutoSize = true;
            this.answerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerButton2.Location = new System.Drawing.Point(8, 76);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(223, 41);
            this.answerButton2.TabIndex = 1;
            this.answerButton2.TabStop = true;
            this.answerButton2.Text = "radioButton1";
            this.answerButton2.UseVisualStyleBackColor = true;
            // 
            // answerButton1
            // 
            this.answerButton1.AutoSize = true;
            this.answerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerButton1.Location = new System.Drawing.Point(8, 29);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(223, 41);
            this.answerButton1.TabIndex = 0;
            this.answerButton1.TabStop = true;
            this.answerButton1.Text = "radioButton1";
            this.answerButton1.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(638, 388);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(150, 50);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Następne pytanie";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // QuestionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.answersPanel);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.backQuestionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionWindow";
            this.answersPanel.ResumeLayout(false);
            this.answersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backQuestionButton;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.Panel answersPanel;
        private System.Windows.Forms.RadioButton answerButton4;
        private System.Windows.Forms.RadioButton answerButton3;
        private System.Windows.Forms.RadioButton answerButton2;
        private System.Windows.Forms.RadioButton answerButton1;
        private System.Windows.Forms.Button nextButton;
    }
}