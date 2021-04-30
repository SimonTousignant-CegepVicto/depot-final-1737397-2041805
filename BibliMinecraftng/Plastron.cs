using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Plastron : Armure

    {
        /// <summary>
        /// constructeur pour le plastron
        /// </summary>
        /// <param name="stackable">determine si le plastron de stack ou pas</param>
        /// <param name="materiel">determine en quel matériel le plastron est fait</param>
        /// <param name="durabilite">determine en combien de temps le plastron se détruit</param>
        /// <param name="protection">determine le nombre de point d'armure que le plastron donne</param>
        public Plastron(bool stackable, string materiel, ushort durabilite, ushort protection)
        {
            this.stackable = stackable;
            this.materiel = materiel;
            this.durabilite = durabilite;
            this.protection = protection;
        }
        /// <summary>
        /// Équiper le plastron
        /// </summary>
        public override void Utilisation()
        {
            
        }
    }
}