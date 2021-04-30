using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Utilitaire : Item
    {
        protected string materiel;
        protected ushort durabilite;
        /// <summary>
        /// constructeur qui permet d'éviter le code d'erreur CS7036
        /// </summary>
        public Utilitaire() { }
        /// <summary>
        /// constructeur pour la classe Utilitaire
        /// </summary>
        /// <param name="stackable">détermine si l'utilitaire se stack</param>
        /// <param name="materiel">détermine le matériel de l'utilitaire (diamant,fer, etc) </param>
        /// <param name="durabilite">Détermine sa durabilité </param>
        public Utilitaire(bool stackable, string materiel, ushort durabilite)
        {
            this.stackable = stackable;
            this.materiel = materiel;
            this.durabilite = durabilite; 
        }
        public override void Utilisation()
        {

        }

    }
}