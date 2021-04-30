using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public abstract class Outil : Utilitaire
    {
        /// <summary>
        /// détermine combien de dégats fait l'outil
        /// </summary>
        protected ushort degat
        {
            get => default;
            set
            {
            }
        }
        /// <summary>
        /// déternime quelle type d'outil qu'il est
        /// </summary>
        protected string type
        {
            get => default;
            set
            {
            }
        }
        /// <summary>
        /// Briser le type d'outil
        /// </summary>
        public abstract void Briser();
    }
}