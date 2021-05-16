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
        /// <param name="materiel">Le Matériel dont il est fait</param>
        /// <param name="durabilite">La durabilité des bottes</param>
        /// <param name="protection">Niveau de protection</param>
        public Bottes(string nom, double[,] position, string materiel, ushort durabilite, ushort protection)
        {
            stackable = false;
            this.nom = nom;
            this.position = position;
            this.materiel = materiel;
            this.durabilite = durabilite;
            this.protection = protection;
        }
        /// <summary>
        /// Équiper les Bottes
        /// </summary>
        public override void Utilisation()
        {
         
        }
    }
}