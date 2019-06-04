/*
 * Projet       : ExCalculOral
 * Description  : Classe regroupant les énumérations du projet
 * Auteur       : A.Morel
 * Date         : 25.10.2017
 * Version      : 1.0 
 */

using System;
using System.ComponentModel;
using System.Reflection;

namespace ExCalculOralConsole
{
    /// <summary>
    /// Représente les onglets du menu
    /// </summary>
    public enum Menu
    {
        SAISIE_NOMBRE_OPERANDE = 1,
        SAISIE_OPERATION_DESIRE = 2,
        SAISIE_QUANTITE_CALCUL = 3,
        LANCEMENT = 4,
        QUITTER = 5
    }

    /// <summary>
    /// Représente les types d'opération possible
    /// </summary>
    public enum TypeOperation
    {
        [Description("+")]
        ADDITION = 1,
        [Description("-")]
        SOUSTRACTION = 2,
        [Description("*")]
        MULTIPLICATION = 3,
        [Description("/")]
        DIVISION = 4,
        [Description("m")]
        ALEATOIRE =5,
    }

    /// <summary>
    /// Contient des utilitaires pour les énumérations
    /// </summary>
    public static class UtilsEnum
    {
        /// <summary>
        /// Permet de récupérer la description de l'énumération
        /// </summary>
        /// <param name="value">Enumération</param>
        /// <returns>Description</returns>
        public static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            object[] attribs = field.GetCustomAttributes(typeof(DescriptionAttribute), true);
            if (attribs.Length > 0)
            {
                return ((DescriptionAttribute)attribs[0]).Description;
            }
            return string.Empty;
        }
    }
}
