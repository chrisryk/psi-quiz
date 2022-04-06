namespace Quiz.WindowsForms
{
    partial class ScoreWindow
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
            this.backScoreboardButton = new System.Windows.Forms.Button();
            this.scoreText = new System.Windows.Forms.Label();
            this.scoreResult = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backScoreboardButton
            // 
            this.backScoreboardButton.Location = new System.Drawing.Point(12, 388);
            this.backScoreboardButton.Name = "backScoreboardButton";
            this.backScoreboardButton.Size = new System.Drawing.Size(150, 50);
            this.backScoreboardButton.TabIndex = 5;
            this.backScoreboardButton.Text = "Wróć do menu";
            this.backScoreboardButton.UseVisualStyleBackColor = true;
            this.backScoreboardButton.Click += new System.EventHandler(this.backScoreboardButton_Click);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreText.Location = new System.Drawing.Point(291, 53);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(218, 37);
            this.scoreText.TabIndex = 6;
            this.scoreText.Text = "Twój wynik to:";
            // 
            // scoreResult
            // 
            this.scoreResult.AutoSize = true;
            this.scoreResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreResult.Location = new System.Drawing.Point(119, 120);
            this.scoreResult.Name = "scoreResult";
            this.scoreResult.Size = new System.Drawing.Size(0, 46);
            this.scoreResult.TabIndex = 7;
            this.scoreResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.Window;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userName.Location = new System.Drawing.Point(74, 287);
            this.userName.MaxLength = 20;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(400, 44);
            this.userName.TabIndex = 8;
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameText.Location = new System.Drawing.Point(162, 232);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(476, 32);
            this.nameText.TabIndex = 9;
            this.nameText.Text = "Zapisz swoje imię w tablicy wyników:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(562, 287);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 50);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ScoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.scoreResult);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.backScoreboardButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backScoreboardButton;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label scoreResult;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Button saveButton;
    }
}