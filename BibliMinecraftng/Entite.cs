using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    /// <summary>
    /// Classe centrale qui permet de créer
    ///d'autres classes qui héritent tous
    /// des propriétés communes "noms" et "position" 
    /// </summary>
    public class Entite
    {
            public string nom;
            public double[,] position;

        /// <summary>
        /// constructeur qui permet d'éviter le code d'erreur CS7036
        /// </summary>
            public Entite() { }

        /// <summary>
        /// Constructeur de l'entite
        /// </summary>
        /// <param name="nom">Donne un nom</param>
        /// <param name="position"> Donne une position double avec 2 variables (X,Y)</param>
            public Entite(string nom, double[,] position)
                {
                    this.nom = nom;
                    this.position = position;
                }
        /// <summary>
        /// Accesseur pour accéder au nom 
        /// </summary>
            private string Nom
            {
                get
                {
                    return nom;
                }
            }
        /// <summary>
        /// Accesseur qui permet d'accéder et modifier la position 
        /// </summary>
            private double [,] Position
            {
            get
            {
                return position;
            }
            set
            {
                this.position = Position; 
            }
        }
    }
}