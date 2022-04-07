namespace Quiz.WindowsForms
{
    partial class ScoreboardWindow
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
            this.usersListLabel = new System.Windows.Forms.Label();
            this.usersListTable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backScoreboardButton
            // 
            this.backScoreboardButton.Location = new System.Drawing.Point(12, 388);
            this.backScoreboardButton.Name = "backScoreboardButton";
            this.backScoreboardButton.Size = new System.Drawing.Size(150, 50);
            this.backScoreboardButton.TabIndex = 4;
            this.backScoreboardButton.Text = "Wróć do menu";
            this.backScoreboardButton.UseVisualStyleBackColor = true;
            this.backScoreboardButton.Click += new System.EventHandler(this.backScoreboardButton_Click);
            // 
            // usersListLabel
            // 
            this.usersListLabel.AutoSize = true;
            this.usersListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usersListLabel.Location = new System.Drawing.Point(4, 9);
            this.usersListLabel.Name = "usersListLabel";
            this.usersListLabel.Size = new System.Drawing.Size(344, 46);
            this.usersListLabel.TabIndex = 5;
            this.usersListLabel.Text = "Najlepsze wyniki:";
            // 
            // usersListTable
            // 
            this.usersListTable.AutoSize = true;
            this.usersListTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usersListTable.Location = new System.Drawing.Point(12, 72);
            this.usersListTable.Name = "usersListTable";
            this.usersListTable.Size = new System.Drawing.Size(0, 29);
            this.usersListTable.TabIndex = 6;
            // 
            // ScoreboardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.usersListTable);
            this.Controls.Add(this.usersListLabel);
            this.Controls.Add(this.backScoreboardButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreboardWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backScoreboardButton;
        private System.Windows.Forms.Label usersListLabel;
        private System.Windows.Forms.Label usersListTable;
    }
}