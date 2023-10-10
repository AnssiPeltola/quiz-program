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
    public partial class KategoriaValintaForm : Form
    {
        public KategoriaValintaForm()
        {
            InitializeComponent();
        }

        private void pelaaNappi_Click(object sender, EventArgs e)
        {
            // Get the player name from the TextBox
            string pelaajaNimi = pelaajaNimiBox.Text;

            // Determine the selected category based on the checked radio button
            string valittuKategoria = "";

            if (radioNappi1.Checked)
            {
                valittuKategoria = "tiede";
            }
            else if (radioNappi2.Checked)
            {
                valittuKategoria = "luonto ja eläimet";
            }
            else if (radioNappi3.Checked)
            {
                valittuKategoria = "maantieto";
            }
            else if (radioNappi4.Checked)
            {
                valittuKategoria = "kaikki";
            }

            // Create an instance of the GameplayForm and pass the player name and category
            PeliForm peliForm = new PeliForm(pelaajaNimi, valittuKategoria);

            // Show the GameplayForm
            peliForm.Show();

            // Optionally, hide the ChooseCategoryForm if you don't want it to be visible anymore
            this.Hide();
        }
    }
}
