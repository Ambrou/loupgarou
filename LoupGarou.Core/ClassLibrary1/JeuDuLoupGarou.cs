using System;
using System.Collections.Generic;
using System.Linq;

namespace LoupGarou.Core
{
    public class JeuDuLoupGarou
    {
        private Dictionary<string, string> descriptionParRole = new Dictionary<string, string>();
        MaitreDuJeu maitreDuJeu = null;
        public List<Habitant> listeDesHabitants = new List<Habitant>();
        int nombreHabitantsAttendu = 0;
        bool partieSimplifie = false;
        public string estAuTourDe;
        private string joueurCible;
        private int nombreDeJoueurAyantCible;

        public JeuDuLoupGarou()
        {
            descriptionParRole.Add(Properties.Resources.NomRoleVoyante,     Properties.Resources.DescriptionRoleVoyante);
            descriptionParRole.Add(Properties.Resources.NomRoleVillageois,  Properties.Resources.DescriptionRoleVillageois);
            descriptionParRole.Add(Properties.Resources.NomRoleCupidon,     Properties.Resources.DescriptionRoleCupidon);
            descriptionParRole.Add(Properties.Resources.NomRoleSorciere,    Properties.Resources.DescriptionRoleSorciere);
            descriptionParRole.Add(Properties.Resources.NomRolePetiteFille, Properties.Resources.DescriptionrolePetiteFille);
            descriptionParRole.Add(Properties.Resources.NomRoleChasseur,    Properties.Resources.DescriptionRoleChasseur);
            descriptionParRole.Add(Properties.Resources.NomRoleLoupGarou,   Properties.Resources.DescriptionRoleLoupGarou);
            peutCommencer = false;
        }

        internal void habitantCible(string v/*, Habitant accusateur*/)
        {
            if(estAuTourDe == Properties.Resources.NomRoleLoupGarou)
            {
                joueurCible = v;
                nombreDeJoueurAyantCible++;
                if(nombreDeJoueurAyantCible == 2)
                {
                    auTourDe(Properties.Resources.NomRoleVillageois);
                    maitreDuJeu.conter(Properties.Resources.FinTourLoupGarou);
                    maitreDuJeu.conter(Properties.Resources.DebutTourVillageois);
                    Habitant habitant = listeDesHabitants.Single(h => h.Nom == joueurCible);
                    maitreDuJeu.conter(string.Format(Properties.Resources.DecouverteDuCorps, habitant.Nom, habitant.Role));
                    listeDesHabitants.Remove(habitant);
                }
            }
            else if (estAuTourDe == Properties.Resources.NomRoleVillageois)
            {
                joueurCible = v;
                nombreDeJoueurAyantCible++;
                if (nombreDeJoueurAyantCible == listeDesHabitants.Count)
                {
                    auTourDe(Properties.Resources.NomRoleVoyante);
                    Habitant habitant = listeDesHabitants.Single(h => h.Nom == joueurCible);
                    maitreDuJeu.conter(string.Format(Properties.Resources.LynchageVillageois, habitant.Nom, habitant.Role));
                    maitreDuJeu.conter(Properties.Resources.FinTourVillageois);
                    listeDesHabitants.Remove(habitant);
                }
            }
            else if(estAuTourDe == Properties.Resources.NomRoleVoyante)
            {
                joueurCible = v;
                Habitant habitant = listeDesHabitants.Single(h => h.Nom == joueurCible);
                Habitant voyante = listeDesHabitants.Single(h => h.Role == Properties.Resources.NomRoleVoyante);
                maitreDuJeu.chuchoter(voyante, habitant.Role);
                maitreDuJeu.conter(Properties.Resources.FinTourVoyante);
                auTourDe(Properties.Resources.NomRoleLoupGarou);
            }
        }

        public void auTourDe(string v)
        {
            estAuTourDe = v;
        }

        public void creerUnVillageAvecHabitants(int p0)
        {
            nombreHabitantsAttendu = p0;
        }

        internal void ajouterJoueur(Habitant habitant)
        {
            listeDesHabitants.Add(habitant);
            maitreDuJeu.chuchoter(habitant, Properties.Resources.SalutationHabitant);
            if(listeDesHabitants.Count == nombreHabitantsAttendu)
            {
                peutCommencer = true;
                maitreDuJeu.conter(Properties.Resources.VillageComplet);
            }
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
                listeDesHabitants[i].afficheInformation(Properties.Resources.AnnonceRoleDuJoueur + listeDesHabitants[i].Role);
            }
            maitreDuJeu.conter(Properties.Resources.PresentationDuJeu);
        }

        static Random _random = new Random();
        public bool peutCommencer;

        private List<string> creerListeDesRoles()
        {
            List<string> listeDesRoles = new List<string>();
            int nombreHabitants = listeDesHabitants.Count;


            listeDesRoles.Add(Properties.Resources.NomRoleLoupGarou);
            listeDesRoles.Add(Properties.Resources.NomRoleLoupGarou);
            listeDesRoles.Add(Properties.Resources.NomRoleVoyante);
            listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            
            if(8 < nombreHabitants)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            }
            if (9 < nombreHabitants)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            }
            if (10 < nombreHabitants)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            }
            if (12 < nombreHabitants)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            }
            if (13 < nombreHabitants)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            }
            if (14 < nombreHabitants)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            }
            if (15 < nombreHabitants)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            }
            if (16 < nombreHabitants)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            }
            if (17 < nombreHabitants)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleVillageois);
            }

            if (nombreHabitants > 11)
            {
                listeDesRoles.Add(Properties.Resources.NomRoleLoupGarou);
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
            joueur.afficheInformation(descriptionParRole[nomDuRole]);
        }

        public void estUnePartieSimplifie()
        {
            partieSimplifie = true;
        }
    }
}
