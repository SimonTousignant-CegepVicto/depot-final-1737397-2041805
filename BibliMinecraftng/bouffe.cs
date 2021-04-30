using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Bouffe : Item
    {
        /// <summary>
        ///  permet de savoir en combien de temps la barre de nourriture va se vider
        /// </summary>
        protected ushort saturation;

        /// <summary>
        /// determine combien de point de bouffe la nourriture donne
        /// </summary>
        protected ushort gainbouffe;
        /// <summary>
        /// constructeur qui permet d'éviter le code d'erreur CS7036
        /// </summary>
        public Bouffe()
        {

        }
        /// <summary>
        /// constructeur d'objet de bouffe
        /// </summary>
        /// <param name="nom">nom de la bouffe</param>
        /// <param name="position">position de la bouffe</param>
        /// <param name="stackable">si la bouffe est stackable ou nom</param>
        /// <param name="gainbouffe">les point de faim que la bouffe donne</param>
        public Bouffe(string nom, double[,] position, bool stackable, ushort saturation, ushort gainbouffe)
        {
            this.nom = nom;
            this.position = position;
            this.stackable = stackable;        
            this.gainbouffe = gainbouffe;
        }

        /// <summary>
        /// accesseur pour accéder au gain de nourriture 
        /// </summary>
        public ushort Gainbouffe
        {
            get
            {
                return gainbouffe;
            }
            set
            {
                this.gainbouffe = value;
            }
        }
        /// <summary>
        /// Manger la bouffe
        /// </summary>
        public override void Utilisation()
        {
           
        } 
    }
}