using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    public class Viande : Bouffe


    {
        public Viande(string nom, ushort gainbouffe)
        {
            this.nom = nom;
            this.gainbouffe = gainbouffe;
        }

        public override ushort Gainbouffe
        {
            get
            {
                return gainbouffe;
            }
            set
            {
                this.gainbouffe = value;
            }
        }

        protected ushort Manger()
        {

            return gainbouffe;
        }
    }
}