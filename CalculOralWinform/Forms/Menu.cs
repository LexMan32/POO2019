using ExCalculOral.Enums;
using ExCalculOral.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExCalculOral
{
    public partial class mMenu : Form
    {
        public mMenu()
        {
            InitializeComponent();
        }

        private void btMenuQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLancement_Click(object sender, EventArgs e)
        {
            if (nudOperande.Value > 0 && nudCalculs.Value > 0)
            {
                int nbrOperande = (int)nudOperande.Value;
                TypeOperation typeOperation = (TypeOperation)cbOperations.SelectedItem;
                int nbrCalcul = (int)nudCalculs.Value;

                SequenceCalcul sequenceCalcul = new SequenceCalcul(nbrOperande, typeOperation, nbrCalcul);
                Hide();
                sequenceCalcul.ShowDialog();
                Show();
            }
        }

        private void btAffichageHistorique_Click(object sender, EventArgs e)
        {
            HistoriqueCalcul historiqueCalcul = new HistoriqueCalcul();
            Hide();
            historiqueCalcul.ShowDialog();
            Show();
        }
    }
}
