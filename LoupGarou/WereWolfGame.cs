using JeuDuLoupGarou.Roles;
using LoupGarou.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JeuDuLoupGarou
{
    public class WereWolfGame
    {
        public Dictionary<String, String> attributionDesRolesParJoueur = new Dictionary<String, String>();
        public Dictionary<String, int> resultatDElection = new Dictionary<String, int>();
        public List<VillageoisAyantVote> villageoisAyantVote;
        
        public void attribueLeRoleDeVoyanteA(string NomDuJoueur)
        {
            attribueLeRoleDeA(JeuDuLoupGarou.WereWolfGameRes.Voyante, NomDuJoueur);
        }

        public void attribueLeRoleDeSorciereA(string NomDuJoueur)
        {
            attribueLeRoleDeA(JeuDuLoupGarou.WereWolfGameRes.Sorciere, NomDuJoueur);
        }

        public void attribueLeRoleDeLoupA(string NomDuJoueur)
        {
            attribueLeRoleDeA(JeuDuLoupGarou.WereWolfGameRes.LoupGarou, NomDuJoueur);
        }

        public void attribueLeRoleDeVillageoisA(string NomDuJoueur)
        {
            attribueLeRoleDeA(JeuDuLoupGarou.WereWolfGameRes.Villageois, NomDuJoueur);
        }

        public void attribueLeRoleDeChasseurA(string NomDuJoueur)
        {
            attribueLeRoleDeA(JeuDuLoupGarou.WereWolfGameRes.Chasseur, NomDuJoueur);
        }

        private void attribueLeRoleDeA(string RoleDuJoueur, string NomDuJoueur)
        {
            attributionDesRolesParJoueur.Add(NomDuJoueur, RoleDuJoueur);
            resultatDElection.Add(NomDuJoueur, 0);
        }

        public virtual String estLeProchainMort()
        {
            string NomDuProchainMort = "";

            if (villageoisAyantVote.Count(villageois => villageois.ayantVote == false ) == 0)
            {
                int nbVoteMax = 0;

                foreach (var resultat in resultatDElection)
                {
                    if (nbVoteMax < resultat.Value)
                    {
                        nbVoteMax = resultat.Value;
                        NomDuProchainMort = resultat.Key;
                    }
                }

                if (nbVoteMax != 0)
                {
                    if (resultatDElection.Count(element => element.Value == nbVoteMax) > 1)
                    {
                        NomDuProchainMort = "";
                    }
                }
            }
            return NomDuProchainMort;
        }

        public void voteContre(string NomDuVillageois, string strNomDeLElu)
        {
            resultatDElection[strNomDeLElu] += 1;
            villageoisAyantVote.Where(villageois => villageois.nomDuJoueur == NomDuVillageois).Select(villageois => { villageois.ayantVote = true; return villageois; }).ToList();
        }

        public void commencerLeDebat()
        {
            var liste = from joueur in attributionDesRolesParJoueur
                        select new VillageoisAyantVote() { nomDuJoueur = joueur.Key, ayantVote = false };
            villageoisAyantVote = liste.ToList();
        }

        public void activerLesLoups()
        {
            activer(JeuDuLoupGarou.WereWolfGameRes.LoupGarou);
        }

        public void commencerLaChasse()
        {
            activer(JeuDuLoupGarou.WereWolfGameRes.Chasseur);
        }

        private void activer(string nomDuRole)
        {
            var liste = from joueur in attributionDesRolesParJoueur
                        where joueur.Value == nomDuRole
                        select new VillageoisAyantVote() { nomDuJoueur = joueur.Key, ayantVote = false };
            villageoisAyantVote = liste.ToList();
        }

        public string devoileLeRoleDe(string NomDuJoueur)
        {
            return attributionDesRolesParJoueur[NomDuJoueur];
        }
        public void leverDuSoleil(MaitreDuJeu maitreDuJeu)
        {
            maitreDuJeu.annonceLeLeverDuJour();
            maitreDuJeu.annonceLeProchainMort(estLeProchainMort());
            maitreDuJeu.annonceLeRole(attributionDesRolesParJoueur[estLeProchainMort()]);
        }
    }
}
