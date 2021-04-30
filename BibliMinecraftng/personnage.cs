﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliMinecrafting
{
    /// <summary>
    /// Classe permettant de créer notre personnage,
    /// elle hérite "nom" et "position" de Entite
    /// </summary>
    public class Personnage : Entite
    {
        private ushort faim;
        private ushort vie;
        private int[,] inventaire;
        private int[] backpack;
        private int[] tete;
        private int[] plastron;
        private int[] jambe;
        private int[] botte;
        private int[,] barreAcces;


        public Personnage(string nom, double [,] position, ushort faim, ushort vie, int [,] inventaire, int [] backpack,
                                int [] tete, int [] plastron,
                                int [] jambe, int [] botte, int [,] barreAcces)
        {
            this.faim = faim;
            this.vie = vie;
            this.inventaire = inventaire;
            this.backpack = backpack;
            this.tete = tete;
            this.plastron = plastron;
            this.jambe = jambe;
            this.botte = botte;
            this.plastron = plastron; 
        }

        /// <summary>
        /// permet de manger de la nourriture pour augmenter sa barre de faim
        /// </summary>
        public void Manger()
        {
         
            
        }

        /// <summary>
        /// permet d'équiper une armure sur différente partie du corps
        /// </summary>
        public void Equiper()
        {
            //Console.WriteLine("Quel équipement voulez-vous équiper(tete, plastron, jambe,botte)");
            //string armure_equipee = Console.ReadLine();
            //switch (armure_equipee)
            //{
            //    case 1:
            //        plastron = 1; 
            //}


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