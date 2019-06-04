using System;
using System.Windows.Forms;

namespace ExPeleMele
{
    public partial class JouerSequence : Form
    {
        Random rnd = new Random();  // Generateur Random
        string[] mots = null;       // Tableau de mot
        int nbrMots = 0;            // Nombre de mot
        string mot = null;          // Mot en cour
        int nbrMot = 1;             // Nombre de mot en cour


        public JouerSequence(string[] mots, int nbrMots)
        {
            InitializeComponent();

            // Chargement des variables
            this.mots = mots;
            this.nbrMots = nbrMots;

            // Chargement du premier mot
            chargerMot();
        }

        /// <summary>
        /// Charge un mot aléatoire depuis le tableau "mots" dans la 
        /// varible "mot", melange les lettres de "mot" et mets à jour
        /// le label pour l'affichage des lettres.
        /// </summary>
        private void chargerMot()
        {
            // Recuperation d'un mot depuis le tableau
            mot = mots[rnd.Next(mots.Length - 1)];

            // Mise en majuscule et melange des lettres
            char[] motChar = mot.ToUpper().ToCharArray();
            int n = motChar.Length;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                var value = motChar[k];
                motChar[k] = motChar[n];
                motChar[n] = value;
            }

            // Mise a jour du label
            lbLettres.Text = new string(motChar);
            reponse.Text = "";

            // Rafraichie l'affichage
            Refresh();
        }

        private void btVerifier_Click(object sender, EventArgs e)
        {
            // Test si la réponse est complete
            if (!String.IsNullOrWhiteSpace(reponse.Text))
            {
                // Test si la réponse est correct
                if (reponse.Text.ToLower() == mot.ToLower())
                {
                    // Message de réponse correct
                    MessageBox.Show("Réponse correct !");

                    // Si c'est le dernier mot, fais apparaitre le bouton quitter, sinon passe au mot suivant
                    if (nbrMot == nbrMots)
                    {
                        btRetour.Visible = true;
                        btVerifier.Visible = false;
                    } else
                    {
                        chargerMot();
                        nbrMot++;
                    }

                    // Raffraichie la fenetre
                    Refresh();
                } else
                {
                    // Message de réponse incorrecte
                    MessageBox.Show("Réponse incorrect !");
                }
            }
            
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            // Ferme le dialogue
            Close();
        }
    }
}
