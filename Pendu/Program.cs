using Pendu.Objets;
using System;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Affichage l'introduction
            Affichage.AfficherIntroduction();

            // Initialisation de la partie et saisie du speudo
            Partie partie = new Partie(Saisie.SaisieSpeudo());

            bool rejouer = true;
            do
            {
                // Affichage de l'écran principale
                Affichage.AfficherEcranPrincipal(partie);

                // Affichage de la partie terminée
                if (partie.isPartieFini())
                {
                    rejouer = Saisie.SaisieRejouer();

                    partie.NouvellePartie();
                }
                else
                {
                    // Afficher la saisie d'un caractère
                    partie.VerifierCaractere(Saisie.SaisieCaractere());
                }
            } while (rejouer);

            Console.ReadKey();
        }
    }
}
