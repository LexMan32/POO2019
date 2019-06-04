/*
 * Projet       : Jeux du pendu
 * Description  : Classe de gestion des affichages
 * Auteur       : A.Morel
 * Date         : 08.03.2018
 * Version      : 1.0
 */

using Pendu.Objets;
using System;
using System.Text;

namespace Pendu
{
    class Affichage
    {
        private const int CONSOLE_WIDTH = 100;       // Constante pour la largeur de la console

        /// <summary>
        /// Affiche l'en-tête et le message d'introduction.
        /// </summary>
        public static void AfficherIntroduction()
        {
            AfficherEnTete("Introduction");

            Console.WriteLine("  Ce programme permet de jouer au jeu du Pendu.");
            Console.WriteLine();

            AfficherPause();
        }

        /// <summary>
        /// Affiche le message et l'en-tête de pour la saisie d'un speudo.
        /// </summary>
        public static void AfficherSaisieSpeudo()
        {
            AfficherEnTete("Saisie du Speudo");

            Console.Write("  Entrer votre speudo : ");
        }

        /// <summary>
        /// Affiche le message pour la saisie d'un caractère
        /// </summary>
        public static void AfficherSaisieCaractere()
        { 
            Console.Write("  Entrer le caractère souhaité : ");
        }

        /// <summary>
        /// Affiche le massage pour la siaisie du rejouer
        /// </summary>
        public static void AfficherSaisieRejouer()
        {
            Console.Write("  Partie terminé, souhaitez-vous continuer ? (o/n) : ");
        }

        /// <summary>
        /// Affiche le message et l'en-tête de l'écran principal
        /// </summary>
        /// <param name="partie">La partie en cour</param>
        public static void AfficherEcranPrincipal(Partie partie) {
            AfficherEnTete("Le Jeux du Pendu");

            Console.WriteLine("  Speudo du joueur : {0}", partie.getSpeudo());
            Console.WriteLine("  Mot trouvé : {0}", partie.getNbrMotTrouve());
            Console.WriteLine("  Quantité d'erreur : {0}", partie.getNbrErreurTotal());
            Console.WriteLine();

            AfficherPendu(partie.getErreur());

            AfficherCaseMot(partie.getMotJoueur());

            if (partie.isPartieFini())
            {
                string str;

                if (partie.isMotCorrect())
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    str = "Félicitation ! Vous avez gagné !";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    str = "Désolée mais vous avez perdu !";
                }

                Console.Write(new string(' ', (Console.WindowWidth - str.Length) / 2));
                Console.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Affiche le pendu d'après le nombre d'erreur en paramètre
        /// </summary>
        /// <param name="erreur">Nombre d'erreur</param>
        private static void AfficherPendu(int erreur)
        {
            string[] pendu = new string[13];
            switch (erreur)
            {
                case 1:
                    pendu[10] = "####################";
                    pendu[11] = "####################";
                    pendu[12] = "####################";
                    break;
                case 2:
                    pendu[0] = "#                   ";
                    pendu[1] = "#                   ";
                    pendu[2] = "#                   ";
                    pendu[3] = "#                   ";
                    pendu[4] = "#                   ";
                    pendu[5] = "#                   ";
                    pendu[6] = "#                   ";
                    pendu[7] = "#                   ";
                    pendu[8] = "#                   ";
                    pendu[9] = "#                   ";
                    pendu[10] = "####################";
                    pendu[11] = "####################";
                    pendu[12] = "####################";
                    break;
                case 3:
                    pendu[0] = "####################";
                    pendu[1] = "#                   ";
                    pendu[2] = "#                   ";
                    pendu[3] = "#                   ";
                    pendu[4] = "#                   ";
                    pendu[5] = "#                   ";
                    pendu[6] = "#                   ";
                    pendu[7] = "#                   ";
                    pendu[8] = "#                   ";
                    pendu[9] = "#                   ";
                    pendu[10] = "####################";
                    pendu[11] = "####################";
                    pendu[12] = "####################";
                    break;
                case 4:
                    pendu[0] = "####################";
                    pendu[1] = "#    #              ";
                    pendu[2] = "#   #               ";
                    pendu[3] = "#  #                ";
                    pendu[4] = "# #                 ";
                    pendu[5] = "##                  ";
                    pendu[6] = "#                   ";
                    pendu[7] = "#                   ";
                    pendu[8] = "#                   ";
                    pendu[9] = "#                   ";
                    pendu[10] = "####################";
                    pendu[11] = "####################";
                    pendu[12] = "####################";
                    break;
                case 5:
                    pendu[0] = "####################";
                    pendu[1] = "#    #         ¦    ";
                    pendu[2] = "#   #          ¦    ";
                    pendu[3] = "#  #           ¦    ";
                    pendu[4] = "# #                 ";
                    pendu[5] = "##                  ";
                    pendu[6] = "#                   ";
                    pendu[7] = "#                   ";
                    pendu[8] = "#                   ";
                    pendu[9] = "#                   ";
                    pendu[10] = "####################";
                    pendu[11] = "####################";
                    pendu[12] = "####################";
                    break;
                case 6:
                    pendu[0] = "####################";
                    pendu[1] = "#    #         ¦    ";
                    pendu[2] = "#   #          ¦    ";
                    pendu[3] = "#  #           ¦    ";
                    pendu[4] = "#              @    ";
                    pendu[5] = "##                  ";
                    pendu[6] = "#                   ";
                    pendu[7] = "#                   ";
                    pendu[8] = "#                   ";
                    pendu[9] = "#                   ";
                    pendu[10] = "####################";
                    pendu[11] = "####################";
                    pendu[12] = "####################";
                    break;
                case 7:
                    pendu[0] = "####################";
                    pendu[1] = "#    #         ¦    ";
                    pendu[2] = "#   #          ¦    ";
                    pendu[3] = "#  #           ¦    ";
                    pendu[4] = "#              @    ";
                    pendu[5] = "#              |    ";
                    pendu[6] = "#              |    ";
                    pendu[7] = "#                   ";
                    pendu[8] = "#                   ";
                    pendu[9] = "#                   ";
                    pendu[10] = "####################";
                    pendu[11] = "####################";
                    pendu[12] = "####################";
                    break;
                case 8:
                    pendu[0] = "####################";
                    pendu[1] = "#    #         ¦    ";
                    pendu[2] = "#   #          ¦    ";
                    pendu[3] = "#  #           ¦    ";
                    pendu[4] = "#              @    ";
                    pendu[5] = "#             '\'|/    ";
                    pendu[6] = "#              |    ";
                    pendu[7] = "#                   ";
                    pendu[8] = "#                   ";
                    pendu[9] = "#                   ";
                    pendu[10] = "####################";
                    pendu[11] = "####################";
                    pendu[12] = "####################";
                    break;
                case 9:
                    pendu[0] = "####################";
                    pendu[1] = "#    #         ¦    ";
                    pendu[2] = "#   #          ¦    ";
                    pendu[3] = "#  #           ¦    ";
                    pendu[4] = "#              @    ";
                    pendu[5] = "#             '\'|/    ";
                    pendu[6] = "#              |    ";
                    pendu[7] = "#             / '\'   ";
                    pendu[8] = "#                   ";
                    pendu[9] = "#                   ";
                    pendu[10] = "####################";
                    pendu[11] = "####################";
                    pendu[12] = "####################";
                    break;
                default:
                    pendu[0] = " ";
                    pendu[1] = " ";
                    pendu[2] = " ";
                    pendu[3] = " ";
                    pendu[4] = " ";
                    pendu[5] = " ";
                    pendu[6] = " ";
                    pendu[7] = " ";
                    pendu[8] = " ";
                    pendu[9] = " ";
                    pendu[10] = " ";
                    pendu[11] = " ";
                    pendu[12] = " ";
                    break;
            }

            foreach (string str in pendu)
            {
                if (str != null)
                {
                    Console.Write(new string(' ', (Console.WindowWidth - str.Length) / 2));
                    Console.WriteLine(str);
                } else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Affiche les caractères du mot du joueur
        /// </summary>
        /// <param name="motJoueur">Mot du joueur</param>
        private static void AfficherCaseMot(char[] motJoueur)
        {
            StringBuilder caseMot = new StringBuilder();

            foreach (char car in motJoueur) {
                caseMot.Append(car + " ");
            }

            Console.Write(new string(' ', (Console.WindowWidth - caseMot.ToString().Length) / 2));
            Console.WriteLine(caseMot);

            Console.WriteLine();
        }

        /// <summary>
        /// Affiche l'en-tete d'une fenetre du programme.
        /// </summary>
        /// <param name="titre">Titre de l'en-tete</param>
        private static void AfficherEnTete(string titre)
        {
            // Nettoie la console
            Console.Clear();

            // Modifie la largeur de la console
            Console.WindowWidth = CONSOLE_WIDTH;

            // Affiche 2 ligne de separation et le titre au centre
            AfficherLigneSeparation();
            Console.Write(new string(' ', (Console.WindowWidth - titre.Length) / 2));
            Console.WriteLine(titre);
            AfficherLigneSeparation();
            Console.WriteLine();
        }

        /// <summary>
        /// Affiche une ligne de separation.
        /// </summary>
        private static void AfficherLigneSeparation()
        {
            // Genere la ligne de separation d'après la largeur de la console
            StringBuilder ligneSeparation = new StringBuilder();
            for (int i = 0; i < CONSOLE_WIDTH; i++)
                ligneSeparation.Append("*");

            // Affiche la ligne de séparation
            Console.WriteLine(ligneSeparation);
        }

        /// <summary>
        /// Affiche une pause (demande d'appuis sur une touche).
        /// </summary>
        private static void AfficherPause()
        {
            AfficherLigneSeparation();
            Console.WriteLine();
            Console.Write(" Appuyer sur une touche pour continuer ...");
            Console.ReadKey();
        }
    }
}
