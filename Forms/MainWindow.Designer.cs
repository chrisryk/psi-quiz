namespace Quiz.WindowsForms
{
    partial class MainWindow
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
            this.title = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.scoreboardButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(341, 51);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(118, 46);
            this.title.TabIndex = 0;
            this.title.Text = "QUIZ";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(325, 167);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(150, 50);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Graj!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // scoreboardButton
            // 
            this.scoreboardButton.Location = new System.Drawing.Point(325, 257);
            this.scoreboardButton.Name = "scoreboardButton";
            this.scoreboardButton.Size = new System.Drawing.Size(150, 50);
            this.scoreboardButton.TabIndex = 2;
            this.scoreboardButton.Text = "Tablica wyników";
            this.scoreboardButton.UseVisualStyleBackColor = true;
            this.scoreboardButton.Click += new System.EventHandler(this.scoreboardButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(638, 388);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(150, 50);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Wyjdź";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.scoreboardButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button scoreboardButton;
        private System.Windows.Forms.Button quitButton;
    }
}

