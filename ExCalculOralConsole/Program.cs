/*
 * Projet       : ExCalculOral
 * Description  : Classe principale de l'application
 * Auteur       : A.Morel
 * Date         : 28.10.2017
 * Version      : 2.0 
 */

using System;
using System.Linq;
using System.Text;

namespace ExCalculOralConsole
{
    class Program
    {
        // Constante de l'application
        private const int CONSOLE_WIDTH = 80;
        private const int OPERANDE_MAXIMUM = 4;
        private const int NOMBRE_MAXIMUM = 100;

        // Champs de l'application
        private static int nbrOperande = 2;
        private static TypeOperation typeOperation = TypeOperation.ADDITION;
        private static int nbrCalcul = 10;

        /// <summary>
        /// Point d'entrée du programme et gestion du menu principale.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Affiche l'introduction
            AfficherIntroduction();

            // Boolean et boucle pour quitter l'application
            bool quitterApp = false;
            do
            {
                // Affiche le menu
                AfficherMenu();

                // Demande la saisie pour le menu
                Menu choix = SaisirChoixMenu();

                // Redirection d'après le choix de l'utilisateur
                switch (choix)
                {
                    // Choix pour l'erreur de saisie
                    case Menu.ERREUR_SAISIE:
                        break;

                    // Saisie d'un nombre d'opérande
                    case Menu.SAISIE_NOMBRE_OPERANDE:
                        AfficherChoixMenu(choix);
                        SaisirNbrOperande();
                        AfficherPause();
                        break;

                    // Saisie d'une opération
                    case Menu.SAISIE_OPERATION_DESIRE:
                        AfficherChoixMenu(choix);
                        SaisirTypeOperation();
                        AfficherPause();
                        break;

                    // Saisie d'un nombre de calcul
                    case Menu.SAISIE_NOMBRE_CALCUL:
                        AfficherChoixMenu(choix);
                        SaisieNbrCalcul();
                        AfficherPause();
                        break;

                    // Lancement de la sequence de calcul
                    case Menu.LANCEMENT:
                        AfficherChoixMenu(choix);
                        LancerSequenceCalcul();
                        AfficherPause();
                        break;

                    case Menu.QUITTER:
                        AfficherChoixMenu(choix);
                        quitterApp = AfficherValidationQuitter();
                        break;
                }
            } while (!quitterApp);
        }

        /// <summary>
        /// Affiche l'en-tete d'une fenetre du programme.
        /// </summary>
        /// <param name="titre">Titre de l'en-tete</param>
        static void AfficherEnTete(string titre)
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
        static void AfficherLigneSeparation()
        {
            // Genere la ligne de separation d'après la largeur de la console
            StringBuilder ligneHautBas = new StringBuilder();
            for (int i = 0; i < CONSOLE_WIDTH; i++) { ligneHautBas.Append("*"); }

            // Affiche la ligne
            Console.WriteLine(ligneHautBas);
        }

        /// <summary>
        /// Affiche l'introduction du programme
        /// </summary>
        static void AfficherIntroduction()
        {
            // Affiche l'en-tete
            AfficherEnTete("Introduction");

            // Affiche l'introduction
            Console.WriteLine(" Bienvenue !");
            Console.WriteLine();
            Console.WriteLine(" Ce programme permet d'exercer le calcul oral.");
            Console.WriteLine(" Il propose les quattres opérations de base.");
            Console.WriteLine();

            // Affiche une pause
            AfficherPause();
        }

        /// <summary>
        /// Affiche une pause (demande d'appuis sur un touche)
        /// </summary>
        static void AfficherPause()
        {
            AfficherLigneSeparation();
            Console.WriteLine();
            Console.Write(" Appuyer sur une touche pour continuer ...");
            Console.ReadKey();
        }

        /// <summary>
        /// Affiche le menu de l'application avec les valeurs passées en paramètre.
        /// </summary>
        /// <param name="iNbrOperande">Nombre d'operande</param>
        /// <param name="oTypeOperation">Type d'opération</param>
        /// <param name="iNbrCalcul">Nomnre de calcul</param>
        static void AfficherMenu()
        {
            // Affiche l'en-tete
            AfficherEnTete("Menu");

            // Affiche le menu avec les valeurs actuelles
            Console.WriteLine("  1. {0} <{1}>", Menu.SAISIE_NOMBRE_OPERANDE.GetDescription(), nbrOperande);
            Console.WriteLine("  2. {0} <{1}>", Menu.SAISIE_OPERATION_DESIRE.GetDescription(), typeOperation.GetDescription());
            Console.WriteLine("  3. {0} <{1}>", Menu.SAISIE_NOMBRE_CALCUL.GetDescription(), nbrCalcul);
            Console.WriteLine("  4. {0}", Menu.LANCEMENT.GetDescription());
            Console.WriteLine("  5. {0}", Menu.QUITTER.GetDescription());
            Console.WriteLine();

            // Affiche une séparation
            AfficherLigneSeparation();
            Console.WriteLine();
        }

        /// <summary>
        /// Demande la saisie d'un choix de redirection pour le menu.
        /// </summary>
        /// <returns>Menu demandé</returns>
        static Menu SaisirChoixMenu()
        {
            // Variable pour la valeur saisie
            int choix;

            // Affiche le message de saisie
            Console.Write(" Entrer votre choix : ");

            try
            {
                choix = int.Parse(Console.ReadLine());
            }
            catch
            {
                // Mise à zero en cas de saisie d'un caractère
                choix = 0;
            }

            // Verification si la valeur saisie correspond a un menu
            if (choix > Enum.GetValues(typeof(Menu)).Cast<int>().Max())
            {
                choix = 0;
            }

            // Retourne le choix converti en menu
            return (Menu)choix;
        }

        /// <summary>
        /// Affiche le menu qui as été selectionné
        /// </summary>
        /// <param name="menu">Menu a affiché</param>
        static void AfficherChoixMenu(Menu menu)
        {
            Console.WriteLine();
            AfficherLigneSeparation();
            Console.WriteLine();
            Console.WriteLine(" Menu sélectionné : {0}", menu.GetDescription());
            Console.WriteLine();
        }

        /// <summary>
        /// Saisie d'un nombre d'opérande par l'utilisateur
        /// </summary>
        static void SaisirNbrOperande()
        {
            // Affiche la valeur maximum
            Console.WriteLine(" Valeur maximum : {0}", OPERANDE_MAXIMUM);
            Console.WriteLine();

            // Affiche la valeur actuelle
            Console.WriteLine("  Valeur actuelle : {0}", nbrOperande);

            // Saisie d'une nouvelle valeur
            Console.Write("  Nouvelle valeur : ");
            int choix;
            try
            {
                choix = int.Parse(Console.ReadLine());

                // Validation de la valeur
                if (choix <= 0 || choix > OPERANDE_MAXIMUM)
                {
                    AfficherMessageErreur("Valeur incorrect !");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    nbrOperande = choix;
                }
            }
            catch
            {
                AfficherMessageErreur("Valeur incorrect !");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Saisie d'un type d'opération d'après l'énumération des TypeOperation.
        /// </summary>
        /// <returns>TypeOperation</returns>
        static void SaisirTypeOperation()
        {
            // Affiche les saisie possible d'après l'énumération
            Console.Write(" Saisie possible : ");
            foreach (TypeOperation operation in Enum.GetValues(typeof(TypeOperation)))
            {
                Console.Write("({0} : {1}) ", (int)operation, operation.GetDescription());
            }
            Console.WriteLine();
            Console.WriteLine();

            // Affiche la valeur actuelle
            Console.WriteLine("  Valeur actuelle : {0}", (int)typeOperation);

            // Saisie d'une nouvelle valeur
            Console.Write("  Nouvelle valeur : ");
            int choix;
            try
            {
                choix = int.Parse(Console.ReadLine());

                // Validation de la valeur
                if (choix <= 0 || choix > Enum.GetValues(typeof(TypeOperation)).Cast<int>().Max())
                {
                    AfficherMessageErreur("Valeur incorrect !");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    typeOperation = (TypeOperation)choix;
                }
            }
            catch
            {
                AfficherMessageErreur("Valeur incorrect !");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Saisie d'un nombre de calcul par l'utilisateur.
        /// </summary>
        static void SaisieNbrCalcul()
        {
            // Affiche la valeur maximum
            Console.WriteLine("Valeur maximum : {0}", NOMBRE_MAXIMUM);
            // Affiche la valeur actuelle
            Console.WriteLine("  Valeur actuelle : {0}", nbrCalcul);

            // Saisie d'une nouvelle valeur
            Console.Write("  Nouvelle valeur : ");
            int choix;
            try
            {
                choix = int.Parse(Console.ReadLine());

                // Validation de la valeur
                if (choix <= 0 || choix > NOMBRE_MAXIMUM)
                {
                    AfficherMessageErreur("Valeur incorrect !");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    nbrCalcul = choix;
                }
            }
            catch
            {
                AfficherMessageErreur("Valeur incorrect !");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Calcul et affiche les différentes calculs et les statistiques pour le résultat du questionnaire
        /// </summary>
        static void LancerSequenceCalcul()
        {
            // Compteur de réponse correct
            int nbrJuste = 0;

            // Genérateur aléatoire de nombre
            Random generateur = new Random();

            // Boucle pour le nombre de calcul et le comptage  des lignes
            for (int numLigne = 1; numLigne < (nbrCalcul + 1); numLigne++)
            {
                // Chargement aléatoire des valeurs
                int valeur1 = generateur.Next(1, (int)(1 * Math.Pow(10, nbrOperande)));
                int valeur2 = generateur.Next(1, (int)(1 * Math.Pow(10, nbrOperande)));

                // Chargement de l'opération (En cas m, chargement aléatoire)
                TypeOperation operateur = typeOperation;
                if (operateur == TypeOperation.ALEATOIRE)
                    operateur = (TypeOperation)generateur.Next(Enum.GetValues(typeof(TypeOperation)).Cast<int>().Min() + 1, Enum.GetValues(typeof(TypeOperation)).Cast<int>().Max() - 1);

                // Chargement du résutat
                int resultat = CalculerResultat(valeur1, valeur2, operateur);

                // Variable de la saisie de l'utilisateur
                int valeurUtilisateur;

                // Boucle pour la saisie d'une lettre
                bool erreurSaisie = true;
                do
                {
                    // Ecrit le calcul
                    Console.Write("   No {0} : {1} {2} {3} = ", numLigne, valeur1, operateur.GetDescription(), valeur2);

                    // TryParse de la saisie de l'utilisateur
                    bool saisieValide = int.TryParse(Console.ReadLine(), out valeurUtilisateur);

                    // Erreur si invalide
                    if (saisieValide)
                    {
                        erreurSaisie = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t Veuillez saisir un nombre !");
                        Console.ResetColor();
                    }
                } while (erreurSaisie);

                // Test si le résultat est correct
                if (resultat == valeurUtilisateur)
                {
                    nbrJuste++;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t Correct !");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t Incorrect ! Réponse : {0}", resultat);
                    Console.ResetColor();
                }
            }

            // Affiche les statistique de la partie
            Console.WriteLine();
            Console.WriteLine("  Nombre de calculs : {0}", nbrCalcul);
            Console.WriteLine();
            Console.WriteLine("  Nombre de calcul corrects : {0}", nbrJuste);
            Console.WriteLine("  Nombre de calcul incorrects : {0}", nbrCalcul - nbrJuste);
            Console.WriteLine();
            Console.WriteLine("  Pourcentage de réponse correct : {0}%", (((double)nbrJuste / nbrCalcul) * 100));
            Console.WriteLine();
        }

        /// <summary>
        /// Calcul du résultat d'après le type d'opération. Retourne 0 si le type d'opération est vide.
        /// </summary>
        /// <param name="valeur1">Valeur 1</param>
        /// <param name="valeur2">Valeur 2</param>
        /// <param name="operation">Type d'opération</param>
        /// <returns>Le résultat</returns>
        static int CalculerResultat(int valeur1, int valeur2, TypeOperation operation)
        {
            // Switch d'après le type d'opération
            switch (operation)
            {
                // Addition
                case TypeOperation.ADDITION:
                    return valeur1 + valeur2;

                // Soustraction
                case TypeOperation.SOUSTRACTION:
                    return valeur1 - valeur2;

                // Multiplication
                case TypeOperation.MULTIPLICATION:
                    return valeur1 * valeur2;

                // Division
                case TypeOperation.DIVISION:
                    return valeur1 / valeur2;

                // Defaut (0)
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Demande la confirmation pour quitter le programme
        /// </summary>
        /// <returns>Confirmation (oui/non)</returns>
        static bool AfficherValidationQuitter()
        {
            bool quitter = false;

            Console.Write(" Désirez-vous quitter le programme (o/n) ? : ");



            switch (Console.ReadLine().ToLower())
            {
                case "oui":
                case "o":
                case "yes":
                case "y":
                    quitter = true;
                    break;
                default:
                    quitter = false;
                    break;
            }

            return quitter;
        }

        /// <summary>
        /// Affiche un message d'erreur en rouge avec une tabulation.
        /// </summary>
        /// <param name="messageErreur">Message d'erreur</param>
        static void AfficherMessageErreur(string messageErreur)
        {
            // Préparation du message
            string message = String.Format(" !!! {0} !!!", messageErreur);

            // Affichage du message en rouge
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
