using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliMinecrafting;
namespace BibliMinecrafting
{
    /// <summary>
    /// Classe permettant de créer notre personnage,
    /// elle hérite "nom" et "position" de Entite
    /// </summary>
    public class Personnage : Entite
    {
        private ushort faim = 10;
        private ushort vie = 20; 
        private ushort niveau_Protection = 0;
        private Backpack [] backpack = new Backpack [3]; 
        private Item[,] inventaire = new Item[2, 2];
        private Item[] barreAcces = new Item[4];
        private bool tete = false;
        private bool plastron = false;
        private bool jambe = false;
        private bool botte = false;

        public Personnage(string nom, double [,] position, int [,] inventaire)
        {
            this.nom = nom;
            this.position = position; 
        }


       
        /// <summary>
        /// permet de manger de la nourriture pour augmenter sa barre de faim
        /// </summary>
        public void Manger()
        {

            barreAcces[0] = new Fruit("pomme", true, 5, 5); 
            /*
            if(barreAcces[0] != this)
            string bouffe_Mangee = Console.ReadLine();

            switch (bouffe_Mangee.ToLower())
            {
                case "fruit":
                    Fruit pomme = new Fruit("pomme", true, 5, 5);
                    if (faim < 10)
                    {
                        faim += pomme.Gainbouffe;
                        pomme = null; 
                    }
                    else
                    {
                        pomme = null; 
                    }
                    break; 
            } */
        }
        /// <summary>
        /// permet d'équiper une armure sur différente partie du corps
        /// </summary>
        public void Equiper()
        {     
            Console.WriteLine("Quel équipement voulez-vous équiper(tete, plastron, jambe,botte)");
            string armure_Equipee = Console.ReadLine();
            switch (armure_Equipee.ToLower())
            
            {
                
                case "tete":
                    Casque b = new Casque(false, "diamant", 200, 5);
                    tete = true;
                    niveau_Protection += b.Protection; 
                    break;

                case "plaston":
                    Plastron c = new Plastron(false, "diamant", 200, 5);
                    plastron = true;
                    niveau_Protection += c.Protection; 
                    break;

                case "jambiere":
                    Jambiere d = new Jambiere(false, "diamant", 200, 5); 
                    jambe = true;
                    niveau_Protection += d.Protection; 
                    break;

                case "botte":
                    Bottes e = new Bottes(false, "diamant", 200, 5);
                    botte = true;
                    niveau_Protection += e.Protection; 
                    break;
                default: 
                      Console.WriteLine("Veuillez réessayer, vous avez entré une mauvaise information");
                    break; 
            }
        }



        public void Pertefaim()
        {
            faim -= 1;  
        }
        /// <summary>
        /// permet le gain et la perte de vie 
        /// prendra en compte la faim et les dégâts pris
        /// </summary>
        public void Controlevie()
        {
          
        }

        /// <summary>
        /// saisir des objets et les mettres dans son sac ou dans son inventaire
        /// </summary>
        public void Ramasser()
        {
           
        }
        /// <summary>
        /// permet de se déplacer sur la carte en modifiant la position du personnage
        /// </summary>
        public void Deplacer()
        {
        }
    }
}