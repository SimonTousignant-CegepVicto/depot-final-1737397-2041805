using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Bottes : Armure
    {
        /// <summary>
        /// Constructeur d'objet Bottes
        /// </summary>
        /// <param name="stackable"></param>
        /// <param name="materiel">Le Matériel dont il est fait</param>
        /// <param name="durabilite">La durabilité des bottes</param>
        /// <param name="protection">Niveau de protection</param>

        public Bottes(string materiel, ushort durabilite, ushort protection)
        {
            stackable = false;
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
        /// Équiper les Bottes
        /// </summary>
        public override void Utilisation()
        {
         
        }
    }
}