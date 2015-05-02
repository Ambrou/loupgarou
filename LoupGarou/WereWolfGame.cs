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
            attributionDesRolesParJoueur.Add(NomDuJoueur, JeuDuLoupGarou.WereWolfGameRes.Voyante);
            resultatDElection.Add(NomDuJoueur, 0);
        }

        public void attribueLeRoleDeSorciereA(string NomDuJoueur)
        {
            attributionDesRolesParJoueur.Add(NomDuJoueur, JeuDuLoupGarou.WereWolfGameRes.Sorciere);
            resultatDElection.Add(NomDuJoueur, 0);
        }

        public void attribueLeRoleDeLoupA(string NomDuJoueur)
        {
            attributionDesRolesParJoueur.Add(NomDuJoueur, JeuDuLoupGarou.WereWolfGameRes.LoupGarou); ;
            resultatDElection.Add(NomDuJoueur, 0);
        }

        public void attribueLeRoleDeVillageoisA(string NomDuJoueur)
        {
            attributionDesRolesParJoueur.Add(NomDuJoueur, JeuDuLoupGarou.WereWolfGameRes.Villageois); ;
            resultatDElection.Add(NomDuJoueur, 0);
        }

        public void attribueLeRoleDeChasseurA(string NomDuJoueur)
        {
            attributionDesRolesParJoueur.Add(NomDuJoueur, JeuDuLoupGarou.WereWolfGameRes.Chasseur); ;
            resultatDElection.Add(NomDuJoueur, 0);
        }

        public String estLeProchainMort()
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
            var liste = villageoisAyantVote.Where(villageois => villageois.nomDuJoueur == NomDuVillageois).Select(villageois => { villageois.ayantVote = true; return villageois; }).ToList();

        }

        public void commencerLeDebat()
        {
            var liste = from joueur in attributionDesRolesParJoueur
                        select new VillageoisAyantVote() { nomDuJoueur = joueur.Key, ayantVote = false };
            villageoisAyantVote = liste.ToList();
        }

        public void activerLesLoups()
        {
            var liste = from joueur in attributionDesRolesParJoueur
                        where joueur.Value == JeuDuLoupGarou.WereWolfGameRes.LoupGarou
                        select new VillageoisAyantVote (){ nomDuJoueur = joueur.Key, ayantVote = false };
            villageoisAyantVote = liste.ToList();
        }

        public void commencerLaChasse()
        {
            var liste = from joueur in attributionDesRolesParJoueur
                        where joueur.Value == JeuDuLoupGarou.WereWolfGameRes.Chasseur
                        select new VillageoisAyantVote() { nomDuJoueur = joueur.Key, ayantVote = false };
            villageoisAyantVote = liste.ToList();
        }

        public string devoileLeRoleDe(string NomDuJoueur)
        {
            return attributionDesRolesParJoueur[NomDuJoueur];
        }
    }
}
