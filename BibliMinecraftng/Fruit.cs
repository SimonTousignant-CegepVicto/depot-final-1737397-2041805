using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Fruit : Bouffe
    {


        /// <summary>
        /// constructeur du fruit 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="position"></param>
        /// <param name="stackable"></param>
        /// <param name="saturation"></param>
        /// <param name="gainbouffe"></param>
        public Fruit(string nom, double[,] position, bool stackable, ushort saturation, ushort gainbouffe)
        {
            this.nom = nom;
            this.position = position;
            this.stackable = stackable;
            this.saturation = saturation;
            this.gainbouffe = gainbouffe;
        }

        protected ushort Manger()
        {
          
            return gainbouffe; 
        }
    }
}