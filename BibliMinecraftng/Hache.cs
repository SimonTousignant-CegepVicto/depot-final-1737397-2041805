using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Hache : Outil
    {
        /// <summary>
        /// constructeur pour la hache
        /// </summary>
        /// <param name="nom">nom de la hache</param>
        /// <param name="position">position de la hache</param>
        /// <param name="stackable">si la hache est stackable ou pas</param>
        /// <param name="durabilite">la durabilité de la hache</param>
        /// <param name="materiel">le matériel de la hache</param>
        /// <param name="degat">le dégat de la hache</param>
        /// <param name="type">le type d'outil</param>
        public Hache(string nom, double[,] position, bool stackable, ushort durabilite, string materiel, ushort degat, string type)
        {
            this.nom = nom;
            this.position = position;
            this.stackable = stackable;
            this.durabilite = durabilite;
            this.materiel = materiel;
            this.degat = degat;
            this.type = type;
        }
        /// <summary>
        /// Briser la hache
        /// </summary>
        public override void Briser()
        {

        }
        /// <summary>
        /// Baisser la hache d'un point de durabilité
        /// </summary>
        public override void Utilisation()
        {
            base.Utilisation();
        }
    }
}