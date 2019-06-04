using System.ComponentModel;
using System.Reflection;

namespace ExCalculOral.Enums
{
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
        ALEATOIRE = 5,
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
        public static string GetDescription(this TypeOperation value)
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
