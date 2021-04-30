using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Bloc : Item
    {
        /// <summary>
        /// Dureté du bloc (quel matériel est nécessaire à briser le bloc)
        /// </summary>
        protected ushort durete
        {
            get => default;
            set
            {
            }
        }
        /// <summary>
        /// Quel type d'outil est plus efficace pour briser le bloc
        /// </summary>
        protected string predilection
        {
            get => default;
            set
            {
            }
        }
        /// <summary>
        /// constructeur qui permet d'éviter le code d'erreur CS7036
        /// </summary>
        public Bloc() { }

        /// <summary>
        /// Constructeur pour créer un objet bloc
        /// </summary>
        /// <param name="nom">nom du bloc</param>
        /// <param name="position">Position du bloc sur la carte</param>
        /// <param name="durete">Dureté du bloc</param>
        /// <param name="predilection">Quel type d'outil est plus efficace pour briser le bloc</param>
        public Bloc(string nom, double [,] position, ushort durete, string predilection)
        {
            this.nom = nom;
            this.position = position;
            this.durete = durete;
            this.predilection = predilection;
        }
        /// <summary>
        /// Briser le bloc
        /// </summary>
        public override void  Utilisation()
        {

        }
    }
}