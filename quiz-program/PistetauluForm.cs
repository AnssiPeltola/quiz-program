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

namespace quiz_program
{
    public partial class PistetauluForm : Form
    {
        public PistetauluForm()
        {
            InitializeComponent();
        }

        private void PistetauluForm_Load(object sender, EventArgs e)
        {
            string fileName = "pisteet.txt";
            // Lista tupleista, johon luetaan nimimerkki ja pisteet
            List<Tuple<string, int>> scores = new List<Tuple<string, int>>();

            try
            {
                // Open the file for reading using StreamReader
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    // Read each line of the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into player name and score
                        string[] parts = line.Split(',');

                        if (parts.Length == 2)
                        {
                            string playerName = parts[0];
                            // Parsee stringinä olevat pisteet intiksi ja out-keywordillä tallentaa ne score-muuttujaan
                            if (int.TryParse(parts[1], out int score))
                            {
                                scores.Add(Tuple.Create(playerName, score));
                            }
                            else
                            {
                                Console.WriteLine($"Invalid score format for player {playerName}: {parts[1]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid line format: {line}");
                        }
                    }
                }

                // Sort the scores in descending order
                scores = scores.OrderByDescending(score => score.Item2).ToList();

                // Printtaa 10 parasta pelaajanimeä ja tulosta, \r\n on rivinvaihto
                int i = 1;
                string rivi = "";
                foreach (var score in scores)
                {
                    Console.WriteLine($"{score.Item1} {score.Item2}");
                    //rivi = rivi +  i + ". " + score.Item1 + " " + score.Item2 + "\r\n";
                    rivi = rivi + i + ". " + score.Item1.PadRight(20) + score.Item2 + "\r\n";
                    i++;
                    if (i > 10)
                    {
                        tuloksetLabel.Text = rivi;
                        break;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {fileName} not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void aloitusvalikkoonNappi_Click(object sender, EventArgs e)
        {
            Form1 aloitusvalikko = new Form1();
            aloitusvalikko.Show();
            this.Hide();
        }
    }
}
