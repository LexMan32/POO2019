/*
 * Projet       : ExCalculOral
 * Description  : Classe regroupant les énumérations du projet
 * Auteur       : A.Morel
 * Date         : 25.10.2017
 * Version      : 1.0 
 */

using System;
using System.Linq;
using System.Text;

namespace ExCalculOralConsole
{
    class Program
    {
        // Constante pour la largeur de la console
        const int CONSOLE_WIDTH = 80;

        /// <summary>
        /// Point d'entrée du programme et gestion du menu prinipale.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int iNbrOperande = 2;
            TypeOperation toTypeOperation = TypeOperation.ADDITION;
            int iNbrCalcul = 10;

            afficherIntroduction();

            bool bQuitterApp = false;
            do
            {
                afficherMenu(iNbrOperande, toTypeOperation, iNbrCalcul);

                Menu mChoix = saisirChoixMenu();

                switch (mChoix)
                {
                    case Menu.SAISIE_NOMBRE_OPERANDE:
                        iNbrOperande = saisirInt(true, false);
                        break;

                    case Menu.SAISIE_OPERATION_DESIRE:
                        toTypeOperation = saisirTypeOperation();
                        break;

                    case Menu.SAISIE_QUANTITE_CALCUL:
                        iNbrCalcul = saisirInt(true, false);
                        break;

                    case Menu.LANCEMENT:
                        lancerSequenceCalcul(iNbrOperande, toTypeOperation, iNbrCalcul);
                        break;

                    case Menu.QUITTER:
                        bQuitterApp = true;
                        break;
                }
            } while (!bQuitterApp);
        }

        /// <summary>
        /// Affiche l'en-tete d'une fenetre du programme
        /// </summary>
        /// <param name="sTitre">Titre de l'en-tete</param>
        static void afficherEnTete(string sTitre)
        {
            Console.Clear();

            Console.WindowWidth = CONSOLE_WIDTH;

            StringBuilder sLigneHautBas = new StringBuilder();
            for (int i = 0; i < CONSOLE_WIDTH; i++) { sLigneHautBas.Append("*"); }

            Console.WriteLine(sLigneHautBas.ToString());
            Console.Write(new string(' ', (Console.WindowWidth - sTitre.Length) / 2));
            Console.WriteLine(sTitre);
            Console.WriteLine(sLigneHautBas.ToString());
            Console.WriteLine();
        }

        /// <summary>
        /// Affiche l'introduction du programme
        /// </summary>
        static void afficherIntroduction()
        {
            afficherEnTete("Introduction");

            Console.WriteLine(" Bienvenue !");
            Console.WriteLine();
            Console.WriteLine(" Ce programme permet d'exercer le calcul oral.");
            Console.WriteLine(" Il propose les quattres opérations de base.");
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
        static void afficherMenu(int iNbrOperande, TypeOperation toTypeOperation, int iNbrCalcul)
        {
            afficherEnTete("Menu");

            Console.WriteLine("  1. Quantité maximum de chiffres des opérandes <{0}>", iNbrOperande);
            Console.WriteLine("  2. Genre d'opérations desirées (+,-,*,/,m) <{0}>", toTypeOperation.GetDescription());
            Console.WriteLine("  3. Quantité de calculs suivis <{0}>", iNbrCalcul);
            Console.WriteLine("  4. Lancement d'une séquence de calcul");
            Console.WriteLine("  5. Quitter");
            Console.WriteLine();
        }

        /// <summary>
        /// Demande la saisie d'un choix de redirection pour le menu.
        /// </summary>
        /// <returns>Menu demandé</returns>
        static Menu saisirChoixMenu()
        {
            int iChoix = 0;

            do
            {
                Console.Write(" Entrer votre choix : ");

                try
                {
                    iChoix = int.Parse(Console.ReadLine());

                    if (iChoix <= 0 || iChoix > Enum.GetValues(typeof(Menu)).Cast<int>().Max())
                    {
                        afficherMessageErreur("Saisie incorrect !");
                        iChoix = 0;
                    }
                }
                catch
                {
                    afficherMessageErreur("Saisie incorrect !");
                    iChoix = 0;
                }
            } while (iChoix == 0);

            return (Menu)iChoix;
        }

        /// <summary>
        /// Saisie d'un nombre entier positif. Les paramètres permettent de définir
        /// les conditions de validations.
        /// </summary>
        /// <param name="bNonNegatif">Saisie en dessous de zero accepté</param>
        /// <param name="bZeroPossible">Saisie de zero accepté</param>
        /// <returns>Nombre entier</returns>
        public static int saisirInt(bool bNonNegatif, bool bZeroPossible)
        {
            int iValeur = 0;

            bool bSaisieIncorrect = true;
            do
            {
                Console.Write(" Entrer une valeur : ");

                try
                {
                    iValeur = int.Parse(Console.ReadLine());

                    int valMin;
                    if (bZeroPossible) { valMin = 0; } else { valMin = 1; }

                    if (bNonNegatif && iValeur < valMin)
                        afficherMessageErreur("Saisie incorrect !");
                    else
                        bSaisieIncorrect = false;
                }
                catch
                {
                    afficherMessageErreur("Saisie incorrect !");
                }
            } while (bSaisieIncorrect);

            return iValeur;
        }

        /// <summary>
        /// Saisie d'un type d'opération d'après l'énumération des TypeOperation.
        /// </summary>
        /// <returns>TypeOperation</returns>
        static TypeOperation saisirTypeOperation()
        {
            Console.Write(" Saisie possible : ");
            foreach (TypeOperation toOperation in Enum.GetValues(typeof(TypeOperation)))
            {
                Console.Write("({0} : {1}) ", (int)toOperation, toOperation.GetDescription());
            }
            Console.WriteLine();

            int iChoix;

            do
            {
                Console.Write(" Entrer votre choix : ");

                try
                {
                    iChoix = int.Parse(Console.ReadLine());

                    if (iChoix <= 0 || iChoix > Enum.GetValues(typeof(TypeOperation)).Cast<int>().Max())
                    {
                        afficherMessageErreur("Saisie incorrect !");
                        iChoix = 0;
                    }
                }
                catch
                {
                    afficherMessageErreur("Saisie incorrect !");
                    iChoix = 0;
                }
            } while (iChoix == 0);

            return (TypeOperation)iChoix;
        }

        /// <summary>
        /// Calcul et affiche les différentes calculs et les statistiques pour le résultat du questionnaire
        /// </summary>
        /// <param name="iNbrOperande"></param>
        /// <param name="toTypeOperation"></param>
        /// <param name="iNbrCalcul"></param>
        static void lancerSequenceCalcul(int iNbrOperande, TypeOperation toTypeOperation, int iNbrCalcul)
        {
            afficherEnTete("Séquence de calcul");

            int iNbrJuste = 0;

            Random generateur = new Random();

            for (int iNumLigne = 1; iNumLigne < (iNbrCalcul + 1); iNumLigne++)
            {
                int iValeur1 = generateur.Next(1, (int)(1 * Math.Pow(10, iNbrOperande)));
                int iValeur2 = generateur.Next(1, (int)(1 * Math.Pow(10, iNbrOperande)));

                TypeOperation toOperateur = toTypeOperation;
                if (toOperateur == TypeOperation.ALEATOIRE)
                    toOperateur = (TypeOperation)generateur.Next(Enum.GetValues(typeof(Menu)).Cast<int>().Min(), Enum.GetValues(typeof(Menu)).Cast<int>().Max() - 1);

                int iResultat = 0;
                switch (toOperateur)
                {
                    case TypeOperation.ADDITION:
                        iResultat = iValeur1 + iValeur2;
                        break;
                    case TypeOperation.SOUSTRACTION:
                        iResultat = iValeur1 - iValeur2;
                        break;
                    case TypeOperation.MULTIPLICATION:
                        iResultat = iValeur1 * iValeur2;
                        break;
                    case TypeOperation.DIVISION:
                        iResultat = iValeur1 / iValeur2;
                        break;
                }

                Console.Write("  No {0} : {1} {2} {3} = ", iNumLigne, iValeur1, toOperateur.GetDescription(), iValeur2);

                int iValeurUtilisateur = int.Parse(Console.ReadLine());

                if (iResultat == iValeurUtilisateur)
                {
                    iNbrJuste++;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t Correct !");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t Incorrect !");
                    Console.ResetColor();
                }
            }

            Console.WriteLine();
            Console.WriteLine("  Nombre de calcul corrects : {0}", iNbrJuste);
            Console.WriteLine("  Nombre de calcul incorrects : {0}", iNbrCalcul - iNbrJuste);
            Console.WriteLine("  Pourcentage de calcul correct : {0}%", (((double)iNbrJuste / iNbrCalcul) * 100));
            Console.WriteLine();

            Console.Write(" Appuyer sur une touche pour retourner au menu");
            Console.ReadKey();
        }

        /// <summary>
        /// Affiche un message d'erreur en rouge avec une tabulation.
        /// </summary>
        /// <param name="sMessageErreur">Message d'erreur</param>
        static void afficherMessageErreur(string sMessageErreur)
        {
            string sMessage = String.Format("\t {0} !", sMessageErreur);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(sMessage);
            Console.ResetColor();
        }
    }
}
