using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Armure : Utilitaire
    {
        protected ushort protection;

        /// <summary>
        /// constructeur qui permet d'éviter le code d'erreur CS7036
        /// </summary>
        public Armure() { }
        /// <summary>
        /// Constructeur de l'armure 
        /// </summary>
        /// <param name="stackable">est-ce que la pièce d'armure se stack? </param>
        /// <param name="materiel">De quel matériel est fait l'armure</param>
        /// <param name="durabilite">Sa durabilite</param>
        /// <param name="protection">Son degré de protection</param>
        public Armure(bool stackable, string materiel, ushort durabilite, ushort protection)
        {
            this.stackable = stackable;
            this.materiel = materiel;
            this.durabilite = durabilite;
            this.protection = protection; 
        }


        /// <summary>
        /// détermine la facon de mettre l'armure (casque a la tete
        /// plastron au plastron, etc.) 
        /// </summary>
        public override void Utilisation()
        {

        }
    }
}