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
                var villageoisAyantRecuUnVote = resultatDElection.Where(r => r.Value != 0).OrderByDescending(r => r.Value).ToList();
                var nbVote = villageoisAyantRecuUnVote.Max(v => v.Value);
                if(villageoisAyantRecuUnVote.Where(v => v.Value == nbVote).Count() == 1)
                {
                    NomDuProchainMort = villageoisAyantRecuUnVote.Where(v => v.Value == nbVote).ToList()[0].Key;
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
            villageoisAyantVote = attributionDesRolesParJoueur.Select(j => new VillageoisAyantVote { nomDuJoueur = j.Key, ayantVote = false }).ToList();
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
            villageoisAyantVote = attributionDesRolesParJoueur.Where(j => j.Value == nomDuRole)
                .Select(j => new VillageoisAyantVote { nomDuJoueur = j.Key, ayantVote = false }).ToList();
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
