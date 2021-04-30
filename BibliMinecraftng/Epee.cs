using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Epee : Outil
    {
        /// <summary>
        /// constructeur pour l'épée
        /// </summary>
        /// <param name="nom">nom de l'épée</param>
        /// <param name="position">position de l'épée</param>
        /// <param name="stackable">si l'épée est stackable ou pas</param>
        /// <param name="durabilite">la durabilité de l'épée</param>
        /// <param name="materiel">le matériel de l'épée</param>
        /// <param name="degat">le dégat de l'épée</param>
        /// <param name="type">le type d'outil</param>
        public Epee(string nom, double[,] position, bool stackable, ushort durabilite, string materiel, ushort degat, string type)
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
        /// Briser l'épée
        /// </summary>
        public override void Briser()
        {
            if (this.durabilite == 0)
            {
            }
        }
    }
}