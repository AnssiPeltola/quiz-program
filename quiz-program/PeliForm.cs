﻿using System;
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
        private List<Question> filteredQuestions; // List to store questions based on selected category
        private int currentQuestionIndex = -1; // Initialize with -1 to indicate no questions displayed yet
        string pelaajaNimi; // Player's name
        string kategoria; // Selected category
        int pisteet; // Counter for the correct answers
        int virheet; // Counter for the wrong answers
        int remainingTime = 30; // Set the initial time to 30 seconds
        string selectedDifficulty;

        public PeliForm(string pelaajaNimi, string kategoria)
        {
            InitializeComponent();

            // Load questions from JSON file
            QuestionRoot questionRoot = JsonConvert.DeserializeObject<QuestionRoot>(File.ReadAllText("kysymykset.json"));
            this.questions = questionRoot.Questions; // Assign questions to class-level variable
            this.pelaajaNimi = pelaajaNimi;
            this.kategoria = kategoria;
            this.selectedDifficulty = "helppo";
        }

        private void PeliForm_Load(object sender, EventArgs e)
        {
            // Jos tulee joku luovuta -nappi kesken pelin niin siihen pisteiden käsittely (nollaus/tallennus)
            pisteet = 0;
            virheet = 0;

            // string selectedCategory = kategoria;
            timer1.Enabled = true; // Starts timer

            // Filter questions by selected category
            if (kategoria == "kaikki")
            {
                filteredQuestions = questions.Where(q => q.Vaikeusaste == selectedDifficulty).ToList();
            }
            else
            {
                filteredQuestions = questions.Where(q => q.Kategoria == kategoria && q.Vaikeusaste == selectedDifficulty).ToList();
            }

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

            // Set the text for the answer buttons
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
                timer1.Stop();
                MessageBox.Show("Oikein!");
                pisteet++;
                pisteetLabel.Text = "Pisteesi: " + pisteet;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Väärä vastaus");
                virheet++;
                virheetLabel.Text = "Väärät vastaukset: " + virheet + " /5";
            }

            // Game over when 5 wrong answers
            if (virheet >= 5)
            {
                timer1.Stop();
                MessageBox.Show($"Peli loppui! Pisteesi: {pisteet}");
                TallennaPisteet(pisteet);
                virheet = 0;

                // Palaa
                Form1 alkuvalikko = new Form1();
                alkuvalikko.Show();
                this.Hide();   
            }
            else
            {
                TarkistaVaikeusaste();
                // Move to the next question
                if(filteredQuestions.Count != 0)
                {
                    NextQuestion();
                    // After prompt resets timer back to 30 sec
                    ResetTimer();
                }
            }
        }

        private void TarkistaVaikeusaste()
        {
            // Check if it's time to change difficulty
            if (pisteet % 10 == 0 && selectedDifficulty != "vaikea")
            {
                // Change difficulty based on questions answered
                if (pisteet < 10)
                {
                    selectedDifficulty = "helppo";
                }
                else if (pisteet < 20)
                {
                    selectedDifficulty = "keskivaikea";
                }
                else
                {
                    selectedDifficulty = "vaikea";
                }

                // Filter questions by selected category
                if (kategoria == "kaikki")
                {
                    filteredQuestions = questions.Where(q => q.Vaikeusaste == selectedDifficulty).ToList();
                }
                else
                {
                    filteredQuestions = questions.Where(q => q.Kategoria == kategoria && q.Vaikeusaste == selectedDifficulty).ToList();
                }

                if (filteredQuestions.Count == 0)
                {
                    MessageBox.Show("No questions found in the selected category.");
                    return;
                }
            }
            
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
                // Handle quiz completion here
                timer1.Stop();
                MessageBox.Show("Quiz completed!");
                TallennaPisteet(pisteet);
                pisteet = 0;
                virheet = 0;
                Form1 alkuvalikko = new Form1();
                alkuvalikko.Show();
                this.Hide();
            }
        }

        private void VastausNappi1_Click(object sender, EventArgs e)
        {
            // Get the text of the clicked button (selected answer)
            string selectedAnswer = VastausNappi1.Text;

            // Get the correct answer for the current question
            string correctAnswer = filteredQuestions[0].Oikea_Vastaus;
        }

        private void VastausNappi2_Click(object sender, EventArgs e)
        {
            string selectedAnswer = VastausNappi2.Text;
            string correctAnswer = filteredQuestions[0].Oikea_Vastaus;
        }

        private void VastausNappi3_Click(object sender, EventArgs e)
        {
            string selectedAnswer = VastausNappi3.Text;
            string correctAnswer = filteredQuestions[0].Oikea_Vastaus;
        }

        private void VastausNappi4_Click(object sender, EventArgs e)
        {
            string selectedAnswer = VastausNappi4.Text;
            string correctAnswer = filteredQuestions[0].Oikea_Vastaus;
        }

        public void TallennaPisteet(int pisteet)
        {
            string comma = ",";
            string filePath = "pisteet.txt";

            // Check if the file exists, and create it if it doesn't
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            // Create a StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                    writer.WriteLine(pelaajaNimi + comma + pisteet);
            }
        }

        // Timer ticks 1 per sec. 
        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            if (remainingTime < 0)
            {
                timer1.Stop(); // Stop the timer when it reaches 0 seconds
                MessageBox.Show("Time's up! Incorrect answer.");
                virheet++;
                virheetLabel.Text = "Väärät vastaukset: " + virheet + " /5";
                if (virheet >= 5)
                {
                    timer1.Stop();
                    MessageBox.Show($"Peli loppui! Pisteesi: {pisteet}");
                    TallennaPisteet(pisteet);
                    virheet = 0;

                    // Palaa
                    Form1 alkuvalikko = new Form1();
                    alkuvalikko.Show();
                    this.Hide();
                }
                else
                {
                    NextQuestion();
                    ResetTimer();
                }
            }
            else
            {
                // Update your timer display (e.g., a label with the remaining time)
                timerLabel.Text = $"{remainingTime} sec"; // Update "timerLabel" with the remaining time.
            }
        }

        // Resets timer back to 30sec
        private void ResetTimer()
        {
            timer1.Stop(); // Stop the timer
            remainingTime = 30; // Reset the timer to 30 seconds
            timerLabel.Text = "30 sec"; // Update the timer display
            timer1.Start(); // Start the timer
        }

        private void luovutusNappi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show($"Peli loppui! Pisteesi: {pisteet}");
            TallennaPisteet(pisteet);
            virheet = 0;

            // Palaa
            Form1 alkuvalikko = new Form1();
            alkuvalikko.Show();
            this.Hide();
        }
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
