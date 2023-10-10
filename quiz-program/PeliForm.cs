using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace quiz_program
{
    public partial class PeliForm : Form
    {
        List<Question> questions;
        string pelaajaNimi;
        string kategoria;

        public PeliForm(string pelaajaNimi, string kategoria)
        {
            InitializeComponent();

            // Load questions from JSON file
            // this.questions = JsonConvert.DeserializeObject<List<Question>>(File.ReadAllText("kysymykset.json"));
            QuestionRoot questionRoot = JsonConvert.DeserializeObject<QuestionRoot>(File.ReadAllText("kysymykset.json"));
            List<Question> questions = questionRoot.Questions;

            this.pelaajaNimi = pelaajaNimi;
            this.kategoria = kategoria;
        }

        private void PeliForm_Load(object sender, EventArgs e)
        {

        }

        public class QuestionRoot
        {
            [JsonProperty("kysymykset")]
            public List<Question> Questions { get; set; }
        }



        private List<Question> filteredQuestions;

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

            // Populate CheckBox controls with answer options
            for (int i = 0; i < shuffledAnswers.Count; i++)
            {
                CheckBox checkBox = (CheckBox)this.Controls.Find($"AnswerCheckBox{i + 1}", true)[0];
                checkBox.Text = shuffledAnswers[i];
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
