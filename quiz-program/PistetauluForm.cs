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
            Console.WriteLine("Tultiin pistetaulu -formille"); // Debug

            string fileName = "pisteet.txt";

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
                            //pelaajaLabel1.Text = playerName;
                            string score = parts[1];
                            //pisteetLabel1.Text = score;

                            // Print player name and score in the "playername score" format
                            Console.WriteLine($"{playerName} {score}");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid line format: {line}");
                        }
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
