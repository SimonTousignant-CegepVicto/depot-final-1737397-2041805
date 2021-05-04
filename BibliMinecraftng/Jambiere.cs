using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Jambiere : Armure
    {
        /// <summary>
        /// constructeur pour les jambières
        /// </summary>
        /// <param name="stackable">determine si les jambières se stack ou pas</param>
        /// <param name="materiel">determine en quel matériel les jambières sont faites</param>
        /// <param name="durabilite">determine en combien de temps les jambières se détruises</param>
        /// <param name="protection">determine le nombre de point d'armure que les jambières donne</param>
        public Jambiere(bool stackable, string materiel, ushort durabilite, ushort protection)
        {
            this.stackable = stackable;
            this.materiel = materiel;
            this.durabilite = durabilite;
            this.protection = protection;
        }
        /// <summary>
        /// Équiper des jambières
        /// </summary>
        /// 

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
        public override void Utilisation()
        {
            
        }
    }
}