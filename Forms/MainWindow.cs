using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.WindowsForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            QuestionWindow questionWindow = new QuestionWindow();
            questionWindow.StartPosition = FormStartPosition.CenterScreen;
            questionWindow.Show();
            this.Hide();
        }
        private void scoreboardButton_Click(object sender, EventArgs e)
        {
            ScoreboardWindow scoreboardWindow = new ScoreboardWindow();
            scoreboardWindow.StartPosition = FormStartPosition.CenterScreen;
            scoreboardWindow.Show();
            this.Hide();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
