using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Quiz.WindowsForms
{
    public partial class ScoreboardWindow : Form
    {
        public ScoreboardWindow()
        {
            InitializeComponent();

            DisplayScores();
        }

        private void DisplayScores()
        {
            if (File.ReadAllText(ScoreWindow.FileName) == string.Empty)
            {
                usersListLabel.Text = "Brak wyników";
                return;
            }

            ISerializer serializer = new JsonSerializer();
            List<User> usersList = serializer.Deserialize<User>(ScoreWindow.FileName).OrderByDescending(u => u.Score).Take(10).ToList();
            
            foreach (User user in usersList)
            {
                usersListTable.Text += $"{usersList.IndexOf(user) + 1}. Wynik: {user.Score} - {user.Name}\n";
            }
        }

        private void backScoreboardButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
