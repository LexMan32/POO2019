/*
 * Projet       : Jeux du pendu
 * Description  : Service pour l'obtention d'un mot (pour l'instant utilisé avec un tableau de mot)
 * Auteur       : A.Morel
 * Date         : 08.03.2018
 * Version      : 1.0
 */

using System;

namespace Pendu
{
    class Donnee
    {
        /// <summary>
        /// Retourne un mot aléatoire contenu dans le tableau de mots disponible
        /// </summary>
        /// <returns>Un mot aléatoire de la liste</returns>
        public static string getMotPendu()
        {
            // A déplacer ou dans la base de donnée
            string[] baseDeDonnee = new string[] { "test", "bonjour", "pendu" };

            Random random = new Random();
            int index = random.Next(baseDeDonnee.Length - 1);
            return baseDeDonnee[index];
        }
    }
}
