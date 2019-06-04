/*
 * Projet       : ExCalculOral
 * Description  : Objet représentant un calcul
 * Auteur       : A.Morel
 * Date         : 05.12.2017
 * Version      : 2.0 
 */

using System;
using System.Linq;
using System.Text;

namespace ExCalculOralObjet
{
    class Calcul
    {
        private int operateurUn;                // Operateur 1
        private int operateurDeux;              // Operateur 2
        private TypeOperation typeOperation;    // Type de l'opération
        private int reponseUtilisateur;         // Réponse de l'utilisateur

        /// <summary>
        /// Propriété de l'opérateur 1
        /// </summary>
        public int OperateurUn
        {
            get
            {
                return operateurUn;
            }
        }

        /// <summary>
        /// Propriété de l'opérateur 2
        /// </summary>
        public int OperateurDeux
        {
            get
            {
                return operateurDeux;
            }
        }

        /// <summary>
        /// Propriété du type de l'opération
        /// </summary>
        public TypeOperation TypeOperation
        {
            get
            {
                return typeOperation;
            }
        }

        /// <summary>
        /// Propriété de la réponse de l'utilisateur
        /// </summary>
        public int ReponseUtilisateur
        {
            get
            {
                return reponseUtilisateur;
            }
            set
            {
                reponseUtilisateur = value;
            }
        }

        /// <summary>
        /// Constructeur de l'object Calcul. Attribues aléatoirement des valeurs pour les opérateurs
        /// un et deux d'après le nombre d'opérande et attribue le type d'opération aléatoirement si
        /// le mode aléatoire est activé.
        /// </summary>
        /// <param name="generateur">Générateur de nombre</param>
        /// <param name="nbrOperande">Nombre de chiffre des opérande</param>
        /// <param name="typeOperation">Type d'opération</param>
        public Calcul(Random generateur, int nbrOperande, TypeOperation typeOperation)
        {
            // Génération des valeurs pour les opérateurs
            this.operateurUn = generateur.Next(1, (int)(1 * Math.Pow(10, nbrOperande)));
            this.operateurDeux = generateur.Next(1, (int)(1 * Math.Pow(10, nbrOperande)));

            // Chargement du type de l'opération (En cas du choix 'm', chargement aléatoire de l'opérateur)
            this.typeOperation = typeOperation;
            if (this.typeOperation == TypeOperation.ALEATOIRE)
                this.typeOperation = (TypeOperation)generateur.Next(Enum.GetValues(typeof(TypeOperation)).Cast<int>().Min(), Enum.GetValues(typeof(TypeOperation)).Cast<int>().Max());
        }

        /// <summary>
        /// Calcule et retourne le résultat de l'opération.
        /// </summary>
        /// <returns>Résultat du calcul</returns>
        public int calculerResultat()
        {
            // Switch d'après le type d'opération
            switch (typeOperation)
            {
                // Addition
                case TypeOperation.ADDITION:
                    return operateurUn + operateurDeux;

                // Soustraction
                case TypeOperation.SOUSTRACTION:
                    return operateurUn - operateurDeux;

                // Multiplication
                case TypeOperation.MULTIPLICATION:
                    return operateurUn * operateurDeux;

                // Division
                case TypeOperation.DIVISION:
                    return operateurUn / operateurDeux;

                // Defaut (0)
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Vérifie le résultat de l'utilisateur et retourne vrai si la réponse est 
        /// correct et faux dans les autres cas.
        /// </summary>
        /// <returns>Retourne vrai si la réponse est correcte</returns>
        public bool verifierResultat()
        {
            // Retourne vrai si la réponse de l'utilistauer est correct
            return (reponseUtilisateur == calculerResultat());
        }

        /// <summary>
        /// Retourne une chaine de caractère pour l'affichage du calcul avec en paramètre,
        /// si l'on souhaite ajouter à la chaine la réponse de l'utilisateur.
        /// </summary>
        /// <param name="afficherResultat">Ajouter la réponse à la chaine de caractère</param>
        /// <returns>Le calcul sous forme de chaine de caractère</returns>
        public string construireCalcul(bool afficherResultat)
        {
            // Déclaration du string builder
            StringBuilder calculString = new StringBuilder();

            // Ajout des informations du calcul
            calculString.Append(operateurUn);
            calculString.Append(" ");
            calculString.Append(typeOperation.GetDescription());
            calculString.Append(" ");
            calculString.Append(operateurDeux);
            calculString.Append(" = ");

            // D'après le boolean, ajoute la réponse de l'utilisateur a la chaine
            if (afficherResultat)
                calculString.Append(reponseUtilisateur);

            // Retourne la chaine de caractères
            return calculString.ToString();
        }
    }
}