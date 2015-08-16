﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou.Core
{
    public class Habitant
    {
        private string nom;
        private JeuDuLoupGarou jeuDuLoupGarou;

        public Habitant(string nom)
        {
            this.nom = nom;
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public virtual void afficheInformationRole(string v)
        {
            throw new NotImplementedException();
        }

        public void emmenage(JeuDuLoupGarou jeuDuLoupGarou)
        {
            this.jeuDuLoupGarou = jeuDuLoupGarou;
            this.jeuDuLoupGarou.ajouterJoueur(this);
        }

        public void demandeInformationRole(string nomDuRole)
        {
            jeuDuLoupGarou.donneInformationRole(nomDuRole, this);
        }
    }
}