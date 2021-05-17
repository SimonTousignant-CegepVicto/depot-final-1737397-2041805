using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public abstract class Bouffe : Item
    {
        /// <summary>
        /// determine combien de point de bouffe la nourriture donne
        /// </summary>
        protected ushort Gainbouffe;
        /// <summary>
        /// constructeur qui permet d'éviter le code d'erreur CS7036
        /// </summary>
        /// 
        /// 
        /// 
        /// <summary>
        /// accesseur pour accéder au gain de nourriture 
        /// </summary>
       /* public abstract ushort Gainbouffe
        {
            get;

            set;
  
        } */ 
        /// <summary>
        /// Manger la bouffe
        /// </summary>
        public override void Utilisation()
        {
           
        } 
    }
}