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

        private int currentQuestionIndex = -1; // Initialize with -1 to indicate no questions displayed yet

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

            // Randomly select the first question
            Random random = new Random();
            currentQuestionIndex = random.Next(0, filteredQuestions.Count);
            DisplayQuestion(filteredQuestions[currentQuestionIndex]);
        }

        private void DisplayQuestion(Question question)
        {
            kysymysLabel.Text = question.Kysymys;

            // Shuffle the answer options randomly
            List<string> shuffledAnswers = question.Vastaukset.OrderBy(x => Guid.NewGuid()).ToList();

            // Set the text for the answer buttons (assuming you named them AnswerButton1, AnswerButton2, etc.)
            for (int i = 0; i < shuffledAnswers.Count; i++)
            {
                Button answerButton = this.Controls.Find($"VastausNappi{i + 1}", true).FirstOrDefault() as Button;

                if (answerButton != null)
                {
                    answerButton.Text = shuffledAnswers[i];
                }
            }
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null || currentQuestionIndex < 0 || currentQuestionIndex >= filteredQuestions.Count)
            {
                MessageBox.Show("Invalid question or answer.");
                return;
            }

            string selectedAnswer = clickedButton.Text;

            // Get the correct answer for the current question
            string correctAnswer = filteredQuestions[currentQuestionIndex].Oikea_Vastaus;

            if (selectedAnswer == correctAnswer)
            {
                MessageBox.Show("Correct answer!");
            }
            else
            {
                MessageBox.Show($"Incorrect answer. The correct answer is: {correctAnswer}");
            }

            // Move to the next question
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
            if (currentQuestionIndex >= 0)
            {
                // Remove the current question from the list
                filteredQuestions.RemoveAt(currentQuestionIndex);
            }

            // Clear the existing answer buttons
            ClearAnswerButtons();

            if (filteredQuestions.Count > 0)
            {
                // Randomly select the next question
                Random random = new Random();
                currentQuestionIndex = random.Next(0, filteredQuestions.Count);
                DisplayQuestion(filteredQuestions[currentQuestionIndex]);
            }
            else
            {
                MessageBox.Show("Quiz completed!");
                // Handle quiz completion here
            }
        }

        private void VastausNappi1_Click(object sender, EventArgs e)
        {
            // Get the text of the clicked button (selected answer)
            string selectedAnswer = VastausNappi1.Text;

            // Get the correct answer for the current question
            string correctAnswer = filteredQuestions[0].Oikea_Vastaus;

            CheckAnswer(selectedAnswer, correctAnswer);
        }

        private void VastausNappi2_Click(object sender, EventArgs e)
        {
            string selectedAnswer = VastausNappi2.Text;
            string correctAnswer = filteredQuestions[0].Oikea_Vastaus;

            CheckAnswer(selectedAnswer, correctAnswer);
        }

        private void VastausNappi3_Click(object sender, EventArgs e)
        {
            string selectedAnswer = VastausNappi3.Text;
            string correctAnswer = filteredQuestions[0].Oikea_Vastaus;

            CheckAnswer(selectedAnswer, correctAnswer);
        }

        private void VastausNappi4_Click(object sender, EventArgs e)
        {
            string selectedAnswer = VastausNappi4.Text;
            string correctAnswer = filteredQuestions[0].Oikea_Vastaus;

            CheckAnswer(selectedAnswer, correctAnswer);
        }

        private void CheckAnswer(string selectedAnswer, string correctAnswer)
        {
            if (selectedAnswer == correctAnswer)
            {
                MessageBox.Show("Correct answer!");
            }
            else
            {
                MessageBox.Show($"Incorrect answer. The correct answer is: {correctAnswer}");
            }

            // Move to the next question
            NextQuestion();
        }
    }

    public class Question
    {
        public string Kategoria { get; set; }
        public string Vaikeusaste { get; set; }
        public string Kysymys { get; set; }
        public List<string> Vastaukset { get; set; }
        public string Oikea_Vastaus { get; set; }
    }

    public class QuestionRoot
    {
        [JsonProperty("kysymykset")]
        public List<Question> Questions { get; set; }
    }
}
