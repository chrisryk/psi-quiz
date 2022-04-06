using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.WindowsForms
{
    public partial class QuestionWindow : Form
    {
        public static int index = 0;
        public static int score = 0;
        private List<Question> questions;
        private string fileName = Directory.GetCurrentDirectory() + @"\Questions\questions.json";
        private string endText = "Zakończ";
        private Regex pattern = new Regex(@"^#");
        private List<RadioButton> answerButtons;

        public QuestionWindow()
        {
            InitializeComponent();

            ISerializer serializer = new JsonSerializer();
            questions = serializer.Deserialize<Question>(fileName).ToList();

            DisplayQuestion();
            DisplayAnswers();
        }

        private void DisplayQuestion()
        {
            if (index == questions.Count - 1)
            {
                nextButton.Text = endText;
            }
            questionText.Text = questions[index].QuestionContent;
        }

        private void DisplayAnswers()
        {
            Random random = new Random();
            int max = questions.FirstOrDefault().Answers.Count;
            List<string> answers = questions[index].Answers.ToList();

            answerButtons = answersPanel.Controls.OfType<RadioButton>().ToList();

            foreach (RadioButton button in answerButtons)
            {
                button.Checked = false;
            }

            for (int i = 0; i < max; i++)
            {
                int nextIndex = random.Next(answers.Count);

                if (answers[nextIndex] == string.Empty)
                {
                    i--;
                    continue;
                }

                if (pattern.IsMatch(answers[nextIndex]))
                {
                    answers[nextIndex] = answers[nextIndex].Substring(1);
                }

                answersPanel.Controls[i].Text = answers[nextIndex];
                answers[nextIndex] = string.Empty;
            }
        }

        private void CheckIfCorrect()
        {
            string correctAnswer = questions[index].Answers.Where(a => pattern.IsMatch(a)).First().Substring(1);

            foreach (RadioButton button in answerButtons)
            {
                if (button.Checked && button.Text == correctAnswer)
                {
                    score++;
                }
            }
        }

        private void backQuestionButton_Click(object sender, EventArgs e)
        {
            AlertWindow alertWindow = new AlertWindow();
            alertWindow.StartPosition = FormStartPosition.CenterScreen;
            alertWindow.ShowDialog();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            CheckIfCorrect();

            if (nextButton.Text != endText)
            {
                index++;
            }
            else
            {
                index = 0;
            }

            if (nextButton.Text == endText)
            {
                ScoreWindow scoreWindow = new ScoreWindow(score, questions.Count);
                scoreWindow.StartPosition = FormStartPosition.CenterScreen;
                scoreWindow.Show();
                this.Close();
                score = 0;
                return;
            }

            DisplayQuestion();
            DisplayAnswers();
        }
    }
}
