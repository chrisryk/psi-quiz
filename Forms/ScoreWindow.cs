using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.WindowsForms
{
    public partial class ScoreWindow : Form
    {
        public static string FileName { get; } = Directory.GetCurrentDirectory() + @"\Scores\scoreboard.json";
        private int userScore;
        private string userInput;
        public ScoreWindow(int score, int numberOfQuestions)
        {
            InitializeComponent();

            userScore = score;
            scoreResult.Text = $"{score} / {numberOfQuestions} poprawnych odpowiedzi";
        }

        private void backScoreboardButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            userInput = userName.Text;

            User user = new User();
            user.Name = userInput;
            user.Score = userScore;

            ISerializer serializer = new JsonSerializer();
            serializer.Serialize(FileName, user);

            MessageBox.Show("Zapisano!");

            ScoreboardWindow scoreboardWindow = new ScoreboardWindow();
            scoreboardWindow.StartPosition = FormStartPosition.CenterScreen;
            scoreboardWindow.Show();

            this.Close();
        }
    }
}
