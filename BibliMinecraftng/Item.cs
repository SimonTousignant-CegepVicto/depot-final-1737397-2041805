using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public abstract class Item : Entite
    {
        

        /// <summary>
        /// Si l'objet est stackable ou non
        /// </summary>
        protected bool stackable;

        /// <summary>
        /// constructeur qui permet d'éviter le code d'erreur CS7036
        /// </summary>
        public Item()
        {

        }

        /// <summary>
        /// constructeur de l'item
        /// </summary>
        /// <param name="stackable">Determine si l'item se stack ou pas</param>
        public Item(bool stackable)
        {
            this.stackable = stackable; 
        }

        /// <summary>
        /// internal set qui permettent d'utiliser les accesseurs dans mes autres classes
        /// </summary>
        public ushort gainBouffe { get; internal set; }
        public ushort protection { get; internal set; }

        /// <summary>
        /// accesseur permettant d'aller chercher
        /// la valeur boolenne du stackable
        /// et de la modifier
        /// </summary>
        private bool Stackable
        {
            get
            {
                return stackable; 

            }
            set
            {
                this.Stackable = stackable; 
            }
        }

        /// <summary>
        /// Methode abstract permettant 
        /// aux classes en héritant de faire une action
        /// </summary>
        public abstract void Utilisation();

    }
}