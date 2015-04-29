using JeuDuLoupGarou.Roles;
using JeuDuLoupGarou.State;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JeuDuLoupGarou
{
    public class WereWolfGame
    {
        public Voyante voyante = null;
        public Dictionary<String, LoupGarou> loupGarou = new Dictionary<String, LoupGarou>();
        public Dictionary<String, Villageois> villageois = new Dictionary<String, Villageois>();
        public Dictionary<String, String> attributionDesRolesParJoueur = new Dictionary<String, String>();
        public Dictionary<String, int> resultatDElection = new Dictionary<String, int>();
        public Dictionary<String, bool> villageoisAyantVote = new Dictionary<string, bool>();
        
        public void attribueLeRoleDeVoyanteA(string NomDuJoueur)
        {
            attributionDesRolesParJoueur.Add(NomDuJoueur, JeuDuLoupGarou.WereWolfGameRes.Voyante);
            resultatDElection.Add(NomDuJoueur, 0);
            villageois.Add(NomDuJoueur, new Villageois(this));
            voyante = new Voyante(this);
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
            loupGarou.Add(NomDuJoueur, new LoupGarou(this));
            villageois.Add(NomDuJoueur, new Villageois(this));
        }

        public void attribueLeRoleDeVillageoisA(string NomDuJoueur)
        {
            attributionDesRolesParJoueur.Add(NomDuJoueur, JeuDuLoupGarou.WereWolfGameRes.Villageois); ;
            resultatDElection.Add(NomDuJoueur, 0);
            villageois.Add(NomDuJoueur, new Villageois(this));
        }

        public String estLeProchainMort()
        {
            string NomDuProchainMort = "";

            if (villageoisAyantVote.ContainsValue(false) == false)
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
            resultatDElection[strNomDeLElu] = resultatDElection[strNomDeLElu] + 1;
            villageoisAyantVote[NomDuVillageois] = true;
        }

        public void commencerLeDebat()
        {
            villageoisAyantVote.Clear();
            foreach (var joueur in villageois)
            {
                villageoisAyantVote.Add(joueur.Key, false);
            }
        }

        public void activerLesLoups()
        {
            villageoisAyantVote.Clear();
            foreach (var joueur in loupGarou)
            {
                villageoisAyantVote.Add(joueur.Key, false);
            }
        }

        //public Dictionary<String, String> m_PlayerWithRoleList = new Dictionary<String, String>();
        //public List<Role> m_RoleList = new List<Role>();
        //public Role m_strCurrentState;

        //public void addPlayerWithRole(String strPlayerName, String strRole)
        //{
        //    m_PlayerWithRoleList.Add(strPlayerName, strRole);
        //    //m_RoleList.Add(RoleFactory.createRole(strRole, strPlayerName));
        //}

        //public void begin()
        //{
        //    //m_RoleList.Clear();
        //    //foreach (var role in m_PlayerWithRoleList)
        //    //{
        //    //    List<Role>tempoList= m_RoleList.Where(_role => _role.name == role.Value).ToList();
        //    //    if (m_RoleList.Where(_role => _role.name == role.Value).ToList().Count == 0)
        //    //    {
        //    //        m_RoleList.Add(RoleFactory.createRole(role.Value));
        //    //    }
        //    //}
        //    //m_RoleList.Sort((x, y) => x.rolePhase1.CompareTo(y.rolePhase1));
        //    //m_strCurrentState = m_RoleList[0];
        //}

        //public void firstTurnDone()
        //{
        //    //m_RoleList.Clear();
        //    //foreach (var role in m_PlayerWithRoleList)
        //    //{
        //    //    List<Role> tempoList = m_RoleList.Where(_role => _role.name == role.Value).ToList();
        //    //    if (m_RoleList.Where(_role => _role.name == role.Value).ToList().Count == 0)
        //    //    {
        //    //        m_RoleList.Add(RoleFactory.createRole(role.Value));
        //    //    }
        //    //}
        //    //m_RoleList.Sort((x, y) => x.rolePhase2.CompareTo(y.rolePhase2));
        //    //m_strCurrentState = m_RoleList[0];
        //}

        //public void killRole(string strRole)
        //{
        //    //m_RoleList.Remove(strRole);
        //}

        //public void nextRole()
        //{
        //    if (m_RoleList.IndexOf(m_strCurrentState) + 1 >= m_RoleList.Count)
        //    {
        //        m_strCurrentState = m_RoleList[0];
        //    }
        //    else
        //    {
        //        m_strCurrentState = m_RoleList[m_RoleList.IndexOf(m_strCurrentState) + 1];
        //    }
        //}








    }
}
