using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace quiz_program
{
    public partial class PeliForm : Form
    {
        // Define class-level variables
        List<Question> questions; // List to store all loaded questions
        string pelaajaNimi; // Player's name
        string kategoria; // Selected category

        public PeliForm(string pelaajaNimi, string kategoria)
        {
            InitializeComponent();

            // Load questions from JSON file
            QuestionRoot questionRoot = JsonConvert.DeserializeObject<QuestionRoot>(File.ReadAllText("kysymykset.json"));
            this.questions = questionRoot.Questions; // Assign questions to class-level variable
            this.pelaajaNimi = pelaajaNimi;
            this.kategoria = kategoria;
        }

        private void PeliForm_Load(object sender, EventArgs e)
        {
            // Your initialization code (if any) can be added here
        }

        private List<Question> filteredQuestions; // List to store questions based on selected category

        private void aloitaNappi_Click(object sender, EventArgs e)
        {
            string selectedCategory = kategoria;

            // Filter questions by selected category
            filteredQuestions = questions.Where(q => q.Kategoria == selectedCategory).ToList();

            if (filteredQuestions.Count == 0)
            {
                MessageBox.Show("No questions found in the selected category.");
                return;
            }

            // Randomly select a question
            Random random = new Random();
            int randomIndex = random.Next(0, filteredQuestions.Count);
            DisplayQuestion(filteredQuestions[randomIndex]);
        }

        private void DisplayQuestion(Question question)
        {
            kysymysLabel.Text = question.Kysymys;

            // Shuffle the answer options randomly
            List<string> shuffledAnswers = question.Vastaukset.OrderBy(x => Guid.NewGuid()).ToList();

            // Create and position buttons for answer options
            for (int i = 0; i < shuffledAnswers.Count; i++)
            {
                Button answerButton = new Button();
                answerButton.Name = $"AnswerButton{i + 1}";
                answerButton.Text = shuffledAnswers[i];
                answerButton.Width = 150;
                answerButton.Height = 30;
                answerButton.Top = 150 + i * 40;
                answerButton.Left = 50;

                // Add a click event handler to the button
                answerButton.Click += AnswerButton_Click;

                this.Controls.Add(answerButton);
            }
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null)
            {
                return;
            }

            string selectedAnswer = clickedButton.Text;

            // Get the correct answer for the current question
            string correctAnswer = filteredQuestions[0].OikeaVastaus;

            if (selectedAnswer == correctAnswer)
            {
                MessageBox.Show("Correct answer!");
            }
            else
            {
                MessageBox.Show($"Incorrect answer. The correct answer is: {correctAnswer}");
            }

            // Clear the buttons and move to the next question
            ClearAnswerButtons();
            NextQuestion();
        }

        private void ClearAnswerButtons()
        {
            // Remove all answer buttons from the form
            foreach (Control control in this.Controls)
            {
                if (control is Button answerButton && answerButton.Name.StartsWith("AnswerButton"))
                {
                    this.Controls.Remove(control);
                }
            }
        }

        private void NextQuestion()
        {
            // Remove the current question from the list
            filteredQuestions.RemoveAt(0);

            if (filteredQuestions.Count > 0)
            {
                // Display the next question
                DisplayQuestion(filteredQuestions[0]);
            }
            else
            {
                MessageBox.Show("Quiz completed!");
                // Handle quiz completion here
            }
        }
    }

    public class Question
    {
        public string Kategoria { get; set; }
        public string Vaikeusaste { get; set; }
        public string Kysymys { get; set; }
        public List<string> Vastaukset { get; set; }
        public string OikeaVastaus { get; set; }
    }
}
