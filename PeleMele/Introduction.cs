using System;
using System.Windows.Forms;

namespace ExPeleMele
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void btContinuer_Click(object sender, EventArgs e)
        {
            // Ferme la fenetre d'introduction
            Close();
        }
    }
}
