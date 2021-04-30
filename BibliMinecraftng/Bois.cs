using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliMinecrafting
{
    public class Bois : Bloc
    {
        /// <summary>
        /// Constructeur pour créer un objet Bois
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="position"></param>
        /// <param name="durete"></param>
        /// <param name="predilection"></param>
        public Bois(string nom, double[,] position, ushort durete, string predilection)
        {
            this.nom = nom;
            this.position = position;
            this.durete = durete;
            this.predilection = predilection;
        }
    }
}
