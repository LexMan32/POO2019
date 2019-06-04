/*
 * Projet       : ExCalculOral
 * Description  : Classe principale de l'application
 * Auteur       : A.Morel
 * Date         : 28.10.2017
 * Version      : 4.0 
 */

using System;
using System.Linq;
using System.Text;

namespace ExCalculOralObjet
{
    class Program
    {
        private const int CONSOLE_WIDTH = 80;       // Constante pour la largeur de la console
        private const int OPERANDE_MAXIMUM = 4;     // Constante pour la valeur maximum de l'opérande
        private const int NOMBRE_MAXIMUM = 100;     // Constante pour la valeur maximum de calcul

        private static int nbrOperande = 2;                                     // Champ du nombre d'opérande (Préchargé 2)
        private static TypeOperation typeOperation = TypeOperation.ADDITION;    // Champ du type d'opération (Préchargé +)
        private static int nbrCalcul = 10;                                      // Champ du nombre de calcul (Préchargé 10)

        /// <summary>
        /// Point d'entrée du programme et gestion du menu principal.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool quitterApp = false;    // Boolean pour quitter l'application
            Menu choix;                 // Menu choisie par l'utilisateur

            // Affiche l'introduction
            AfficherIntroduction();

            // Boucle pour quitter l'application
            do
            {
                // Affiche le menu
                AfficherMenu();

                // Demande la saisie pour le menu
                choix = SaisirChoixMenu();

                // Redirection d'après le choix de l'utilisateur
                switch (choix)
                {
                    // Choix pour l'erreur de saisie
                    case Menu.ERREUR_SAISIE:
                        break;

                    // Saisie d'un nombre d'opérande
                    case Menu.SAISIE_NOMBRE_OPERANDE:
                        GestionNbrOperande();
                        break;

                    // Saisie d'une opération
                    case Menu.SAISIE_OPERATION_DESIRE:
                        GestionTypeOperation();
                        break;

                    // Saisie d'un nombre de calcul
                    case Menu.SAISIE_NOMBRE_CALCUL:
                        GestionNbrCalcul();
                        break;

                    // Lancement de la sequence de calcul
                    case Menu.LANCEMENT:
                        LancerSequenceCalcul();
                        break;

                    // Quitter l'application
                    case Menu.QUITTER:
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
            for (int i = 0; i < CONSOLE_WIDTH; i++)
                ligneHautBas.Append("*");

            // Affiche la ligne de séparation
            Console.WriteLine(ligneHautBas);
        }

        /// <summary>
        /// Affiche l'introduction du programme.
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
        /// Affiche une pause (demande d'appuis sur une touche).
        /// </summary>
        static void AfficherPause()
        {
            AfficherLigneSeparation();
            Console.WriteLine();
            Console.Write(" Appuyer sur une touche pour continuer ...");
            Console.ReadKey();
        }

        /// <summary>
        /// Affiche le menu de l'application avec les valeurs pour chacun des paramètres de l'application.
        /// </summary>
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
        /// Demande la saisie d'une option pour le menu. Retourne l'énumération Menu.ERREUR_SAISIE
        /// en cas d'erreur de saisie (mauvais numéro ou caractère).
        /// </summary>
        /// <returns>Menu demandé</returns>
        static Menu SaisirChoixMenu()
        {
            // Variable pour la valeur saisie
            int valeurSaisie;

            // Affiche le message de saisie
            Console.Write(" Entrer votre choix : ");

            try
            {
                valeurSaisie = int.Parse(Console.ReadLine());
            }
            catch
            {
                // Mise à zero en cas de saisie d'un caractère
                valeurSaisie = 0;
            }

            // Verification si la valeur saisie correspond a un menu
            if (valeurSaisie > Enum.GetValues(typeof(Menu)).Cast<int>().Max())
                valeurSaisie = 0;

            // Retourne la valeur saisie converti en menu
            return (Menu)valeurSaisie;
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
        static void GestionNbrOperande()
        {
            int valeurSaisie; // Valeur saisie par l'utilisateur

            // Affiche le message de sélection du menu
            AfficherChoixMenu(Menu.SAISIE_NOMBRE_OPERANDE);

            // Affiche la valeur maximum
            Console.WriteLine(" Valeur maximum : {0}", OPERANDE_MAXIMUM);
            Console.WriteLine();

            // Affiche la valeur actuelle
            Console.WriteLine("  Valeur actuelle : {0}", nbrOperande);

            // Message de saisie
            Console.Write("  Nouvelle valeur : ");
            try
            {
                // Récupération de la valeur
                valeurSaisie = int.Parse(Console.ReadLine());

                // Validation de la valeur saisie (Nombre positif et ne dépassant pas la valeur max)
                if (valeurSaisie <= 0 || valeurSaisie > OPERANDE_MAXIMUM)
                {
                    // Affiche un message d'erreur
                    AfficherMessageErreur("Valeur incorrect");
                }
                else
                {
                    // Attribue la valeur saisie
                    nbrOperande = valeurSaisie;
                }
            }
            catch
            {
                // Affiche un message d'erreur
                AfficherMessageErreur("Valeur incorrect");
            }

            // Affiche une pause
            Console.WriteLine();
            AfficherPause();
        }

        /// <summary>
        /// Saisie d'un type d'opération d'après l'énumération des TypeOperation.
        /// </summary>
        static void GestionTypeOperation()
        {
            int valeurSaisie; // Valeur saisie par l'utilisateur 

            // Affiche le message de sélection du menu
            AfficherChoixMenu(Menu.SAISIE_OPERATION_DESIRE);

            // Affiche les saisie possible d'après l'énumération
            Console.Write(" Saisie possible : ");
            foreach (TypeOperation operation in Enum.GetValues(typeof(TypeOperation)))
                Console.Write("({0} : {1}) ", (int)operation, operation.GetDescription());
            Console.WriteLine();
            Console.WriteLine();

            // Affiche la valeur actuelle
            Console.WriteLine("  Valeur actuelle : {0}", (int)typeOperation);

            // Message de saisie
            Console.Write("  Nouvelle valeur : ");
            try
            {
                // Récupération de la valeur saisie
                valeurSaisie = int.Parse(Console.ReadLine());

                // Validation de la valeur (Si positif et si correspond a une énum)
                if (valeurSaisie <= 0 || valeurSaisie > Enum.GetValues(typeof(TypeOperation)).Cast<int>().Max())
                {
                    // Affiche un message d'erreur
                    AfficherMessageErreur("Valeur incorrect");
                }
                else
                {
                    // Attribution de la valeur
                    typeOperation = (TypeOperation)valeurSaisie;
                }
            }
            catch
            {
                // Affiche un message d'erreur
                AfficherMessageErreur("Valeur incorrect");
            }

            // Affiche une pause
            Console.WriteLine();
            AfficherPause();
        }

        /// <summary>
        /// Saisie d'un nombre de calcul par l'utilisateur.
        /// </summary>
        static void GestionNbrCalcul()
        {
            int valeurSaisie; // Valeur saisie par l'utilisateur 

            // Affiche le message de sélection du menu
            AfficherChoixMenu(Menu.SAISIE_NOMBRE_CALCUL);

            // Affiche la valeur maximum
            Console.WriteLine("  Valeur maximum : {0}", NOMBRE_MAXIMUM);
            Console.WriteLine();

            // Affiche la valeur actuelle
            Console.WriteLine("  Valeur actuelle : {0}", nbrCalcul);

            // Message de saisie
            Console.Write("  Nouvelle valeur : ");
            try
            {
                // Récupération de la valeur saisie
                valeurSaisie = int.Parse(Console.ReadLine());

                // Validation de la valeur (Si positif et inférieur au maximum)
                if (valeurSaisie <= 0 || valeurSaisie > NOMBRE_MAXIMUM)
                {
                    // Affiche un message d'erreur
                    AfficherMessageErreur("Valeur incorrect");
                }
                else
                {
                    // Attribution de la valeur
                    nbrCalcul = valeurSaisie;
                }
            }
            catch
            {
                // Affiche un message d'erreur
                AfficherMessageErreur("Valeur incorrect");
            }

            // Affiche une pause
            Console.WriteLine();
            AfficherPause();
        }

        /// <summary>
        /// Calcul et affiche les différentes calculs et les statistiques pour le résultat du questionnaire
        /// </summary>
        static void LancerSequenceCalcul()
        {
            Calcul calcul;                      // Objet représentant un calcul
            Random generateur = new Random();   // Genérateur aléatoire de nombre
            bool erreurSaisie = false;          // Boolean pour l'erreur de saisie
            int nbrJuste = 0;                   // Compteur de réponse correct

            // Affiche le message de sélection du menu
            AfficherChoixMenu(Menu.LANCEMENT);

            // Boucle pour le nombre de calcul et le comptage  des lignes
            for (int numLigne = 1; numLigne < (nbrCalcul + 1); numLigne++)
            {
                // Initialisation de l'objet Calcul
                calcul = new Calcul(nbrOperande, typeOperation);

                // Boucle pour la saisie d'une lettre
                do
                {
                    // Ecrit le calcul
                    Console.Write("   No {0} : {1} {2} {3} = ", numLigne, calcul.operateurUn, calcul.typeOperation.GetDescription(), calcul.operateurDeux);

                    // TryParse de la saisie de l'utilisateur
                    try
                    {
                        calcul.reponseUtilisateur = int.Parse(Console.ReadLine());
                        erreurSaisie = false;
                    }
                    catch
                    {
                        erreurSaisie = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t Veuillez saisir un nombre !");
                        Console.ResetColor();
                    }
                } while (erreurSaisie);

                // Test si le résultat est correct
                if (calcul.verifierResultat())
                {
                    nbrJuste++;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t Correct !");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t Incorrect ! Réponse : {0}", calcul.calculerResultat());
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

            // Affiche une pause
            AfficherPause();
        }

        /// <summary>
        /// Demande la confirmation pour quitter le programme. Retourne True si la saisie
        /// est égal a "o".
        /// </summary>
        /// <returns>Confirmation (True,False)</returns>
        static bool AfficherValidationQuitter()
        {
            // Affiche le message de sélection du menu
            AfficherChoixMenu(Menu.QUITTER);

            // Message de saisie
            Console.Write(" Désirez-vous quitter le programme (o/n) ? : ");

            // Retourne True si la caractère "o" est saisie
            if (Console.ReadLine() == "o")
                return true;

            // Par défaut, retourne False
            return false;
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