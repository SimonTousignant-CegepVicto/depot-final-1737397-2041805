using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Pelle : Outil
    {
        /// <summary>
        /// constructeur pour la pelle
        /// </summary>
        /// <param name="nom">nom de la pelle</param>
        /// <param name="position">position de la pelle</param>
        /// <param name="stackable">si la pelle est stackable ou pas</param>
        /// <param name="durabilite">la durabilité de la pelle</param>
        /// <param name="materiel">le matériel de la pelle</param>
        /// <param name="degat">le dégat de la pelle</param>
        /// <param name="type">le type d'outil</param>
        public Pelle(string nom, double[,] position, bool stackable, ushort durabilite, string materiel, ushort degat, string type)
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
        /// Briser la pelle
        /// </summary>
        public override void Briser()
        {

        }
    }
}