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
        private Item [] backpack = new Item [3]; 
        private Item[,] inventaire = new Item[2, 2];
        private Item[] barreAcces = new Item[4];
        private Item [] tete = new Item[0];
        private Item[] corps = new Item[0];
        private Item[] jambes = new Item[0];
        private Item[] pieds = new Item[0];

        public Personnage(string nom)
        {
            this.nom = nom;
        
        }

        Personnage felix = new Personnage("Felix"); 

       
        /// <summary>
        /// permet de manger de la nourriture pour augmenter sa barre de faim
        /// </summary>
        public string Manger()
        {
             Fruit pomme = new Fruit( "pomme", true, 5, 5);
            
            if(barreAcces[0] is Bouffe)
            {
                ushort valeurBouffe = barreAcces[0].gainBouffe; 

                if(valeurBouffe + felix.faim > 10)
                {
                    felix.faim = 10;
                    barreAcces[0] = null; 
                }
                else
                {
                    felix.faim += valeurBouffe;
                    barreAcces[0] = null;
                }
                return "Vous vous êtes délecté de ce repas"; 
            }
            else
            {
                string messageErreurManger = "L'objet que vous tentez de manger n'est pas nutritif";
                return messageErreurManger; 
            }
        }
        /// <summary>
        /// permet d'équiper une armure sur différente partie du corps. L'armure doit correspondre
        /// a la partie du corps concernée
        /// </summary>
        public void Equiper()
        {
            Casque b = new Casque(false, "diamant", 10, 10);
            Plastron c = new Plastron(false, "diamant", 10, 10);
            Jambiere d = new Jambiere(false, "diamant", 10, 10);
            Bottes e = new Bottes(false, "diamant", 10, 10); 


            // vérifie si l'item en main est un Armure
            
            if(barreAcces[0] is Armure)
            {
                // Vérifie le type d'armure en main
                if (barreAcces[0] is Casque) 
                {
                    // Vient chercher la valeur de protection de l'armure en main
                    ushort point_Armure = barreAcces[0].protection;
                    // l'ajoute a notre personnage

                   // Casque casque_Cloner = barreAcces[0].DeepCopy();
                    felix.niveau_Protection += point_Armure;
                    barreAcces.CopyTo(felix.tete, 0); 
                  //  felix.tete[0] = barreAcces[0].Clone;
                    barreAcces[0] = null; 
                }

                else if (barreAcces[0] is Plastron)
                {

                }

                else if ( barreAcces[0] is Jambiere)
                {

                }
                else if (barreAcces[0] is Bottes)
                {

                }
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
        /// permet de mettre un objet dans son index 0 de la barre d'access (la main) 
        /// </summary>
        public void Deplacer()
        {

        }
    }
}