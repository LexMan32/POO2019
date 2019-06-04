using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExPeleMele
{
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            // Ferme le dialogue
            Close();
        }
    }
}
