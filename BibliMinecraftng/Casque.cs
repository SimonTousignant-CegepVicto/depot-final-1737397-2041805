using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Casque : Armure
    {
        /// <summary>
        /// constructeur pour le casque
        /// </summary>
        /// <param name="stackable">determine si le casque de stack ou pas</param>
        /// <param name="materiel">determine en quel matériel le casque est fait</param>
        /// <param name="durabilite">determine en combien de temps le casque se détruit</param>
        /// <param name="protection">determine le nombre de point d'armure que le casque donne</param>
        /// 

        public Casque() { }
        public Casque(bool stackable, string materiel, ushort durabilite, ushort protection)
            {
                this.stackable = stackable;
                this.materiel = materiel;
                this.durabilite = durabilite;
                this.protection = protection;
            }

        public ushort Protection
        {
            get
            {
                return protection;
            }
            set
            {
                this.protection = value; 
            }
        }

        /// <summary>
        /// Équiper le casque
        /// </summary>
        public override void Utilisation()
        {
           
        }
    }
}