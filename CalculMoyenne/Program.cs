/*
 * Projet       : CalculMoyenne
 * Description  : Classe principale de l'application
 * Auteur       : A.Morel
 * Date         : 30.01.2018
 * Version      : 3.0
 */

using System;
using System.Text;

namespace CalculMoyenne
{
    class Program
    {
        // Constantes du programme
        private const int CONSOLE_WIDTH = 80;
        private const int MAXIMUM_NOTE = 10;

        // Variables du programme
        private static string nomBranche;
        private static double[] notes = new double[MAXIMUM_NOTE];
        private static int nbrNotes = 0;

        /// <summary>
        /// Point d'entrée du programme, gestion de l'introduction et du menu principal. 
        /// </summary>
        static void Main(string[] args)
        {
            AfficherIntro();

            bool quitterApp = false;

            do
            {
                AfficherMenu();

                string choixUtil = SaisirChoixMenu();

                switch (choixUtil)
                {
                    case "a":
                        GestionNomBranche();
                        break;
                    case "b":
                        GestionAjouterNote();
                        break;
                    case "c":
                        GestionSupprimerNote();
                        break;
                    case "d":
                        ModifierNote();
                        break;
                    case "e":
                        AfficherMoyenne();
                        break;
                    case "q":
                        quitterApp = true;
                        break;
                    default:
                        break;
                }
            } while (!quitterApp);
        }

        /// <summary>
        /// Affiche l'introduction de l'application et 
        /// demande l'appuie sur une touche pour continuer.
        /// </summary>
        static void AfficherIntro()
        {
            AfficherEnTete("Introduction");

            Console.WriteLine("*** Moyenne de branche ***");
            Console.WriteLine();
            Console.WriteLine(" Ce programme permet de calculer des moyennes de branche");
            Console.WriteLine();

            AfficherPause();
        }

        /// <summary>
        /// Affiche le menu de l'application.
        /// </summary>
        static void AfficherMenu()
        {
            AfficherEnTete("Menu");

            Console.WriteLine(" a) Nom de la branche [{0}]", nomBranche);
            Console.WriteLine(" b) Insertion d'une note");
            Console.WriteLine(" c) Suppression d'une note");
            Console.WriteLine(" d) Modification d'une note");
            Console.WriteLine();
            Console.WriteLine(" e) Affichage de la moyenne des notes");
            Console.WriteLine();
            Console.WriteLine(" q) Quitter");
            Console.WriteLine();
        }

        /// <summary>
        /// Demande la saisie d'une chaine de caractère pour
        /// la redirection au sein du menu.
        /// </summary>
        /// <returns>Le caractère saisie en minuscule</returns>
        static string SaisirChoixMenu()
        {
            AfficherLigneSeparation();
            Console.WriteLine();
            Console.Write(" Entrer votre choix : ");

            string choixMenu;

            try
            {
                choixMenu = Console.ReadLine();
            }
            catch
            {
                choixMenu = "";
            }

            return choixMenu.ToLower();
        }

        /// <summary>
        /// Menu de gestion pour modifier le nom de la branche.
        /// </summary>
        static void GestionNomBranche()
        {
            AfficherEnTete("Gestion du nom de la branche");

            Console.WriteLine("  Valeur actuelle : {0}", nomBranche);
            Console.WriteLine();
            Console.Write("  Nouvelle valeur : ");

            nomBranche = Console.ReadLine();

            Console.WriteLine();
            AfficherPause();
        }

        /// <summary>
        /// Menu de gestion pour ajouter une note.
        /// </summary>
        static void GestionAjouterNote()
        {
            AfficherEnTete("Ajouter une note");

            Console.Write("  Nouvelle valeur : ");

            try
            {
                double note = double.Parse(Console.ReadLine());

                if (note < 1 || note > 6)
                {
                    AfficherMessageErreur("Valeur incorrecte !");
                }
                else
                {
                    AjouterNote(note);
                }
            }
            catch
            {
                AfficherMessageErreur("Valeur incorrecte !");
            }

            Console.WriteLine();
            AfficherPause();
        }

        /// <summary>
        /// Ajoute une note au tableau
        /// </summary>
        /// <param name="note">Note</param>
        static void AjouterNote(double note)
        {
            notes[nbrNotes] = note;
            nbrNotes++;
        }

        /// <summary>
        /// Menu de gestion pour supprimer une note. Utilise la méthode
        /// de sélection d'une note pour connaitre la note à supprimer.
        /// </summary>
        static void GestionSupprimerNote()
        {
            int index = SelectionnerNote();

            if (!(index < 0))
            {
                AfficherEnTete("Supprimer une note");

                Console.Write("  Etes-vous sûr de vouloir supprimer la note {0} (o/n) ? ", notes[index]);

                switch (Console.ReadLine())
                {
                    case "o":
                        SupprimerNote(index);
                        break;
                    case "n":
                        break;
                    default:
                        AfficherMessageErreur("Valeur incorrecte !");
                        break;
                }

                Console.WriteLine();
                AfficherPause();
            }
        }

        /// <summary>
        /// Supprime la note dans le tableau qui se trouve a l'index donne en paramètre.
        /// </summary>
        /// <param name="index">Index de la note</param>
        static void SupprimerNote(int index)
        {
            for (int i = index; i < MAXIMUM_NOTE; i++)
            {
                notes[index] = notes[index + 1];
            }
            nbrNotes--;
        }

        /// <summary>
        /// Menu de gestion pour modifier une note. Utilise la méthode
        /// de sélection d'une note pour connaitre la note à modifier.
        /// </summary>
        static void ModifierNote()
        {
            int index = SelectionnerNote();

            if (!(index < 0))
            {
                AfficherEnTete("Modifier une note");

                Console.WriteLine("  Valeur actuelle : {0}", notes[index]);
                Console.WriteLine();

                Console.Write("  Nouvelle valeur : ");

                try
                {
                    double note = double.Parse(Console.ReadLine());

                    if (note < 1 || note > 6)
                    {
                        AfficherMessageErreur("Valeur incorrecte !");
                    }
                    else
                    {
                        notes[index] = note;
                    }
                }
                catch
                {
                    AfficherMessageErreur("Valeur incorrecte !");
                }

                Console.WriteLine();
                AfficherPause();
            }
        }

        /// <summary>
        /// Demande la sélection d'une note à l'utilisateur
        /// </summary>
        /// <returns>Retourne l'index de la note sélectionnner</returns>
        static int SelectionnerNote()
        {
            AfficherEnTete("Sélection d'une note");

            int choixUtil = -1;

            for (int index = 1; index <= nbrNotes; index++)
            {
                Console.WriteLine(" {0} : {1}", index, notes[index - 1]);
            }
            Console.WriteLine();
            Console.Write("  Entrer votre choix : ");

            try
            {
                choixUtil = int.Parse(Console.ReadLine());

                if (choixUtil < 1 || choixUtil > nbrNotes)
                {
                    choixUtil = -1;
                    AfficherMessageErreur("Valeur incorrecte !");
                    AfficherPause();
                }
            }
            catch
            {
                choixUtil = -1;
                AfficherMessageErreur("Valeur incorrecte !");
                AfficherPause();
            }

            return choixUtil - 1;
        }

        /// <summary>
        /// Affiche les notes et la moyenne de celles-ci.
        /// </summary>
        static void AfficherMoyenne()
        {
            AfficherEnTete("Affichage de la moyenne");

            int index = 0;
            double moyenne = 0;

            foreach (double note in notes)
            {
                if (note != 0)
                {
                    index++;
                    moyenne = moyenne + note;
                    Console.WriteLine(" {0} : {1}", index, note);
                }
            }

            moyenne = moyenne / index;

            Console.WriteLine(" Moyenne pour les {0} notes ci-dessus : {1}", index, moyenne);

            Console.WriteLine();
            AfficherPause();
        }

        /// <summary>
        /// Affiche un message d'erreur
        /// </summary>
        /// <param name="message">Message de l'erreur</param>
        static void AfficherMessageErreur(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t Erreur ! {0}", message);
            Console.ResetColor();
        }

        /// <summary>
        /// Affiche l'en-tete des fenetres du programme
        /// </summary>
        /// <param name="titre">Titre de l'en-tete</param>
        static void AfficherEnTete(string titre)
        {
            Console.Clear();

            Console.WindowWidth = CONSOLE_WIDTH;

            AfficherLigneSeparation();
            Console.Write(new string(' ', (Console.WindowWidth - titre.Length) / 2));
            Console.WriteLine(titre);
            AfficherLigneSeparation();
            Console.WriteLine();
        }

        /// <summary>
        /// Affiche une ligne de séparation.
        /// </summary>
        static void AfficherLigneSeparation()
        {
            StringBuilder ligneSeparation = new StringBuilder();
            for (int i = 0; i < CONSOLE_WIDTH; i++)
                ligneSeparation.Append("*");

            Console.WriteLine(ligneSeparation);
        }

        /// <summary>
        /// Demande à l'utilisateur d'appuyer sur une touche pour continuer.
        /// </summary>
        static void AfficherPause()
        {
            AfficherLigneSeparation();
            Console.WriteLine();
            Console.Write(" Appuyer sur une touche pour continuer ...");
            Console.ReadKey();
        }
    }
}
