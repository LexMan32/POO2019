using System;
using System.IO;
using System.Windows.Forms;

namespace ExPeleMele
{
    public partial class Menu : Form
    {
        private int nbrMaxMot = 0;      // Nombre maximal de mot
        private string[] mots = null;   // Tableau des mots disponibles

        public Menu()
        {
            InitializeComponent();

            // Assigne le nombre maximum de mot 
            nudNbreMot.Value = nbrMaxMot;
        }

        private void btSelectionFichier_Click(object sender, EventArgs e)
        {
            // Ouvre un dialogue de selection d'un fichier
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            // Verification de la reponse du dialogue
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Remplissage du tableau de mots avec les mots contenu dans le fichier 
                    mots = File.ReadAllLines(openFileDialog.FileName);

                    // Recupere le nombre de mot contenu dans la liste
                    nbrMaxMot = mots.Length;

                    // Affecte le nouveau nombre de mot aux variable de saisie du nombre maximal de mot
                    nudNbreMot.Value = nbrMaxMot;
                    nudNbreMot.Maximum = nbrMaxMot;

                    // Modifie le libelle pour afficher le fichier selectionne
                    lbFichier.Text = openFileDialog.FileName;
                } catch (Exception ex)
                {
                    // Affiche le message d'erreur
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            // Raffraichie le dialogue
            Refresh();
        }

        private void btJouerSequence_Click(object sender, EventArgs e)
        {
            // Test si les paramètres de la partie sont correct 
            // (Affiche un message d'erreur dans le cas contraire)
            if (mots != null && nudNbreMot.Value >= 1)
            {
                // Création du dialogue d'une séquence de jeu
                JouerSequence jouerSequence = new JouerSequence(mots, (int)nudNbreMot.Value);
          
                Hide();                         // Cache le dialogue du Menu              
                jouerSequence.ShowDialog();     // Affiche le dialogue de la sequence
                Show();                         // Affiche le menu on fois le dialogue de lancement ferme
            } else
            {
                MessageBox.Show("Erreur : Paramètres de la partie invalide !"); 
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Close();    // Ferme le dialogue
        }

        private void btHistorique_Click(object sender, EventArgs e)
        {
            Historique historique = new Historique();   // Création du dialogue pour l'historique 
            Hide();                                     // Cache le dialogue du menu         
            historique.ShowDialog();                    // Affiche le dialogue pour l'historique
            Show();                                     // Affiche le menu on fois le dialogue d'historique ferme
        }
    }
}
