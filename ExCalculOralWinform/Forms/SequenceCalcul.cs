using ExCalculOral.Enums;
using ExCalculOral.Objet;
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
    public partial class SequenceCalcul : Form
    {
        private Random generateur;
        private Calcul calcul;
        private int indexCalcul;

        private Calcul[] calculs;

        private int nbrOperande;
        private TypeOperation typeOperation;
        private int nbrCalcul;

        public SequenceCalcul(int nbrOperande, TypeOperation typeOperation, int nbrCalcul)
        {
            this.calculs = new Calcul[nbrCalcul];

            InitializeComponent();

            generateur = new Random();

            
            this.indexCalcul = 0;

            this.nbrOperande = nbrOperande;
            this.typeOperation = typeOperation;
            this.nbrCalcul = nbrCalcul;

            CreationCalcul();
        }

        private void CreationCalcul()
        {
            if (indexCalcul > 0)
                calculs[indexCalcul - 1] = calcul;

            calcul = new Calcul(generateur, nbrOperande, typeOperation);

            this.lbCalcul.Text = calcul.construireCalcul(false);

            indexCalcul++;
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btVerifier_Click(object sender, EventArgs e)
        {
            try
            {
                calcul.ReponseUtilisateur = int.Parse(tbReponse.Text);

                CreationCalcul();

                this.dgvCalculs.Refresh();
            } catch {
                tbReponse.Text = "0";
            }            
        }
    }
}
