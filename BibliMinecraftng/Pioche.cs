using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Pioche : Outil
    {
        /// <summary>
        /// constructeur pour la pioche
        /// </summary>
        /// <param name="nom">nom de la pioche</param>
        /// <param name="position">position de la pioche</param>
        /// <param name="stackable">si la pioche est stackable ou pas</param>
        /// <param name="durabilite">la durabilité de la pioche</param>
        /// <param name="materiel">le matériel de la pioche</param>
        /// <param name="degat">le dégat de la pioche</param>
        /// <param name="type">le type d'outil</param>
        public Pioche(string nom, double[,] position, bool stackable, ushort durabilite, string materiel, ushort degat, string type)
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
        /// Briser la pioche
        /// </summary>
        public override void Briser()
        {

        }
        /// <summary>
        /// Baisser la pioche d'un point de durabilité
        /// </summary>
        public override void Utilisation()
        {
            base.Utilisation();
        }
    }
}