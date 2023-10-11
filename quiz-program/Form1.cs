using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pelaaNappi_Click(object sender, EventArgs e)
        {
            // Create an instance of the PlayGameForm
            KategoriaValintaForm kategoriaValintaForm = new KategoriaValintaForm();

            // Show the PlayGameForm
            kategoriaValintaForm.Show();

            // Optionally, hide the main menu form if you don't want it to be visible anymore
            this.Hide();
        }

        private void suljeNappi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pistetauluNappi_Click(object sender, EventArgs e)
        {
            PistetauluForm pistetaulu = new PistetauluForm();
            pistetaulu.Show();
            this.Hide();
        }
    }
}
