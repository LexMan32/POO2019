/*
 * Projet       : ExCalculOral
 * Description  : Objet représentant un calcul
 * Auteur       : A.Morel
 * Date         : 05.12.2017
 * Version      : 1.0 
 */

using System;
using System.Linq;

namespace ExCalculOralObjet
{
    class Calcul
    {
        public int operateurUn { get; }                 // Operateur 1
        public int operateurDeux { get; }               // Operateur 2
        public TypeOperation typeOperation { get; }     // Type de l'opération
        public int reponseUtilisateur { get; set; }     // Réponse de l'utilisateur

        /// <summary>
        /// Constructeur de l'object Calcul. Attribues aléatoirement des valeurs pour les opérateurs
        /// un et deux d'après le nombre d'opérande et attribue le type d'opération aléatoirement si
        /// le mode aléatoire est activé.
        /// </summary>
        /// <param name="nbrOperande">Nombre d'opérande</param>
        /// <param name="typeOperation">Type d'opération</param>
        public Calcul(int nbrOperande, TypeOperation typeOperation)
        {
            // Genérateur aléatoire de nombre
            Random generateur = new Random();

            // Génération des valeurs pour les opérateurs
            this.operateurUn = generateur.Next(1, (int)(1 * Math.Pow(10, nbrOperande)));
            this.operateurDeux = generateur.Next(1, (int)(1 * Math.Pow(10, nbrOperande)));

            // Chargement du type de l'opération (En cas m, chargement aléatoire)
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
        /// Vérifie le résultat de l'utilisateur et retourne True si la réponse est 
        /// correct et False dans les autres cas.
        /// </summary>
        /// <returns>Retourne True si la valeur est correct</returns>
        public bool verifierResultat()
        { 
            // Retourne True si la valeur entrée est correct
            if (reponseUtilisateur == calculerResultat())
                return true;

            // Retourne False dans les autres cas
            return false;
        }

    }
}