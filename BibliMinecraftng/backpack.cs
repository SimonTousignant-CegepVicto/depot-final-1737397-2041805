using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Backpack : Item
    {
        private int[,] inventaireBP;

        /// <summary>
        /// constructeur du backpack
        /// </summary>
        /// <param name="stackable">détermine si le backpack peut stack des items</param>
        /// <param name="inventaireBP">détermine la grosseur du backpack</param>
        public Backpack(bool stackable, int[,] inventaireBP)
        {
            this.stackable = stackable; 
            this.inventaireBP = inventaireBP ; 
        }
        /// <summary>
        /// Methode overrider d'item permettant d'utiliser le backpack
        /// (le fermer et l'ouvrir) 
        /// </summary>
        public override void Utilisation()
        {

        }
    }
}