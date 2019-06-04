/*
 * Projet       : Jeux du pendu
 * Description  : Classe de gestion des saisies
 * Auteur       : A.Morel
 * Date         : 08.03.2018
 * Version      : 1.0
 */

using System;

namespace Pendu
{
    class Saisie
    {
        /// <summary>
        /// Saisie du speudo par l'utilisateur
        /// </summary>
        /// <returns>Le speudo saisi</returns>
        public static string SaisieSpeudo()
        {
            Affichage.AfficherSaisieSpeudo();

            string speudo = "";
            speudo = Console.ReadLine();
            Console.WriteLine();

            return speudo;
        }

        /// <summary>
        /// Saisie d'un caractère par l'utilisateur
        /// </summary>
        /// <returns>Le caractère saisi</returns>
        public static char SaisieCaractere()
        {
            Affichage.AfficherSaisieCaractere();

            try
            {
                return Console.ReadLine().ToCharArray()[0];
            } catch (Exception e)
            {
                return ' ';
            }
        }

        /// <summary>
        /// Saisie O/N si le joueur souhaite rejouer
        /// </summary>
        /// <returns>Réponse du joueur</returns>
        public static bool SaisieRejouer()
        {
            Affichage.AfficherSaisieRejouer();

            try
            {
                char reponse = Console.ReadLine().ToCharArray()[0];

                switch (reponse)
                {
                    case 'n':
                        return false;
                    case 'N':
                        return false;
                    default:
                        throw new Exception();
                }
            } catch (Exception e)
            {
                return true;
            }
        }
    }
}
