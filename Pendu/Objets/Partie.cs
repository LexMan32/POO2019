/*
 * Projet       : Jeux du pendu
 * Description  : Objet représentant une partie du jeu du pendu
 * Auteur       : A.Morel
 * Date         : 08.03.2018
 * Version      : 1.0
 */

using System;
using System.Text;

namespace Pendu.Objets
{
    class Partie
    {
        private string speudo;

        private string motCorrect;
        private char[] motJoueur;

        private int nbrMotTrouve;
        private int nbrErreurTotal;
        private int nbrErreur;

        public const int MISE_A_MORT = 9;

        public Partie(string speudo)
        {
            this.speudo = speudo;

            motCorrect = Donnee.getMotPendu();

            StringBuilder str = new StringBuilder();
            str.Append('_', motCorrect.Length);
            motJoueur = str.ToString().ToCharArray();

            nbrErreur = 0;
            nbrMotTrouve = 0;
            nbrErreurTotal = 0;
        }

        public void NouvellePartie()
        {
            motCorrect = Donnee.getMotPendu();

            StringBuilder str = new StringBuilder();
            str.Append('_', motCorrect.Length);
            motJoueur = str.ToString().ToCharArray();

            nbrErreur = 0;
        }

        public void VerifierCaractere(char carJoueur)
        {
            int cptErreur = 0;

            for (int index = 0; index < motCorrect.Length; index ++ )
            {
                char carMot = motCorrect.ToCharArray()[index];

                if (carJoueur == carMot)
                {
                    motJoueur[index] = carJoueur;
                } else
                {
                    cptErreur ++;
                }
            }

            if (cptErreur == motJoueur.Length)
            {
                addErreur();
            }
        }

        public string getSpeudo()
        {
            return speudo;
        }

        public int getErreur()
        {
            return nbrErreur;
        }

        public void addErreur()
        {
            nbrErreur++;
            nbrErreurTotal++;
        }

        public bool isPartieFini()
        {
            return isMotCorrect() || nbrErreur == MISE_A_MORT;
        }

        public bool isMotCorrect()
        {
            if (String.Equals(motJoueur.ToString(), motCorrect))
            {
                nbrMotTrouve++;
                return true;
            }
            return false;
        }

        public int getNbrMotTrouve()
        {
            return nbrMotTrouve;
        }

        public int getNbrErreurTotal()
        {
            return nbrErreurTotal;
        }

        public char[] getMotJoueur()
        {
            return motJoueur;
        }

        public void setMotJoueur(char[] motJoueur)
        {
            this.motJoueur = motJoueur;
        }

    }
}
