using System;
using System.Collections.Generic;

namespace LoupGarou.Core
{
    public class JeuDuLoupGarou
    {
        private Dictionary<string, string> descriptionParRole = new Dictionary<string, string>();
        MaitreDuJeu maitreDuJeu = null;
        public List<Habitant> listeDesHabitants = new List<Habitant>();
        int nombreHabitantsAttendu = 0;
        bool partieSimplifie = false;

        public JeuDuLoupGarou()
        {
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleVoyante,     LoupGarou.Core.Properties.Resources.DescriptionRoleVoyante);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois,  LoupGarou.Core.Properties.Resources.DescriptionRoleVillageois);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleCupidon,     LoupGarou.Core.Properties.Resources.DescriptionRoleCupidon);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleSorciere,    LoupGarou.Core.Properties.Resources.DescriptionRoleSorciere);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRolePetiteFille, LoupGarou.Core.Properties.Resources.DescriptionrolePetiteFille);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleChasseur,    LoupGarou.Core.Properties.Resources.DescriptionRoleChasseur);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleLoupGarou,   LoupGarou.Core.Properties.Resources.DescriptionRoleLoupGarou);
        }

        public void creerUnVillageAvecHabitants(int p0)
        {
            nombreHabitantsAttendu = p0;
        }

        internal void ajouterJoueur(Habitant habitant)
        {
            listeDesHabitants.Add(habitant);
            maitreDuJeu.saluer(habitant, LoupGarou.Core.Properties.Resources.SalutationHabitant);

            if(nombreHabitantsAttendu == listeDesHabitants.Count)
            {
                //commencerPartie();
            }
        }

        public bool contientLHabitant(string nomDuJoueur)
        {
            bool joueurEstPresent = false;

            foreach (var joueur in listeDesHabitants)
            {
                if(joueur.Nom == nomDuJoueur)
                {
                    joueurEstPresent = true;
                }
            }
            return joueurEstPresent;
        }

        public void avecCommeMaitreDuJeu(MaitreDuJeu maitreDuJeu)
        {
            this.maitreDuJeu = maitreDuJeu;
        }

        public void commencerPartie()
        {
            List<string>listeDesRoles  = creerListeDesRoles();

            for (int i = 0; i < listeDesHabitants.Count; i++)
            {
                listeDesHabitants[i].Role = listeDesRoles[i];
            }
            maitreDuJeu.conter(LoupGarou.Core.Properties.Resources.PresentationDuJeu);
        }

        static Random _random = new Random();

        private List<string> creerListeDesRoles()
        {
            List<string> listeDesRoles = new List<string>();
            int nombreHabitants = listeDesHabitants.Count;


            listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleLoupGarou);
            listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleLoupGarou);
            listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVoyante);
            listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            
            if(8 < nombreHabitants)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            }
            if (9 < nombreHabitants)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            }
            if (10 < nombreHabitants)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            }
            if (12 < nombreHabitants)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            }
            if (13 < nombreHabitants)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            }
            if (14 < nombreHabitants)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            }
            if (15 < nombreHabitants)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            }
            if (16 < nombreHabitants)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            }
            if (17 < nombreHabitants)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois);
            }

            if (nombreHabitants > 11)
            {
                listeDesRoles.Add(LoupGarou.Core.Properties.Resources.NomRoleLoupGarou);
            }

            int n = listeDesRoles.Count;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(_random.NextDouble() * (n - i));
                string t = listeDesRoles[r];
                listeDesRoles[r] = listeDesRoles[i];
                listeDesRoles[i] = t;
            }

            return listeDesRoles;
        }

        public void donneInformationRole(string nomDuRole, Habitant joueur)
        {
            joueur.afficheInformationRole(descriptionParRole[nomDuRole]);
        }

        public void estUnePartieSimplifie()
        {
            partieSimplifie = true;
        }
    }
}
