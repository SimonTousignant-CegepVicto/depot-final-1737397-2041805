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
        private ushort Faim = 10;
        private ushort Vie = 20; 
        private ushort Niveau_Protection = 0;
        private Item [] Backpack = new Item [3]; 
        private Item[,] Inventaire = new Item[2, 2];
        private Item[] BarreAcces = new Item[4];
        private Item [] Tete = new Item[0];
        private Item[] Corps = new Item[0];
        private Item[] Jambes = new Item[0];
        private Item[] Pieds = new Item[0];

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
            
            if(BarreAcces[0] is Bouffe)
            {
                ushort valeurBouffe = BarreAcces[0].GainBouffe; 

                if(valeurBouffe + felix.Faim > 10)
                {
                    felix.Faim = 10;
                    BarreAcces[0] = null; 
                }
                else
                {
                    felix.Faim += valeurBouffe;
                    BarreAcces[0] = null;
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
            //ajoute d'un commentaire
            
            if(BarreAcces[0] is Armure)
            {
                // Vérifie le type d'armure en main
                if (BarreAcces[0] is Casque) 
                {
                    // Vient chercher la valeur de protection de l'armure en main
                    ushort point_Armure = BarreAcces[0].protection;
                    // l'ajoute a notre personnage

                   // Casque casque_Cloner = barreAcces[0].DeepCopy();
                    felix.Niveau_Protection += point_Armure;
                    BarreAcces.CopyTo(felix.Tete, 0);
                    Tete[0] = BarreAcces.ElementAt(0);

                   // barreAcces = barreAcces.Where((obj, 0) => 0 != 0).ToArray());
                   
                    
                    // barreAcces.Pop();

                }

                else if (BarreAcces[0] is Plastron)
                {

                }

                else if ( BarreAcces[0] is Jambiere)
                {

                }
                else if (BarreAcces[0] is Bottes)
                {

                }
            }
            
        }

  


        public void Pertefaim()
        {
            Faim -= 1;  
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