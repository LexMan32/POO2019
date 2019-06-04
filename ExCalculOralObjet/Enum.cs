/*
 * Projet       : ExCalculOral
 * Description  : Classe regroupant les énumérations du projet
 * Auteur       : A.Morel
 * Date         : 28.10.2017
 * Version      : 2.0 
 */

using System;
using System.ComponentModel;
using System.Reflection;

namespace ExCalculOralObjet
{
    /// <summary>
    /// Représente les options du menu
    /// </summary>
    public enum Menu
    {
        [Description("Erreur de saisie")]
        ERREUR_SAISIE = 0,
        [Description("Quantité maximum de chiffres des opérandes")]
        SAISIE_NOMBRE_OPERANDE = 1,
        [Description("Genre d'opérations désirées (+,-,*,/,m)")]
        SAISIE_OPERATION_DESIRE = 2,
        [Description("Quantité de calculs suivis")]
        SAISIE_NOMBRE_CALCUL = 3,
        [Description("Lancement d'une séquence de calcul")]
        LANCEMENT = 4,
        [Description("Quitter")]
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