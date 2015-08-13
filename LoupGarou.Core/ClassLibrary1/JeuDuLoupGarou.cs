using System;
using System.Collections.Generic;

namespace LoupGarou.Core
{
    public class JeuDuLoupGarou
    {
        private Dictionary<string, string> descriptionParRole = new Dictionary<string, string>();
        MaitreDuJeu maitreDuJeu = null;

        public JeuDuLoupGarou()
        {
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleVoyante,     LoupGarou.Core.Properties.Resources.DescriptionRoleVoyante);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleVillageois,  LoupGarou.Core.Properties.Resources.DescriptionRoleVillageois);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleCupidon,     LoupGarou.Core.Properties.Resources.DescriptionRoleCupidon);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleSorciere,    LoupGarou.Core.Properties.Resources.DescriptionRoleSorciere);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRolePetiteFille, LoupGarou.Core.Properties.Resources.DescriptionrolePetiteFille);
            descriptionParRole.Add(LoupGarou.Core.Properties.Resources.NomRoleChasseur,    LoupGarou.Core.Properties.Resources.DescriptionRoleChasseur);
        }

        public void attendLesJoueurs()
        {
            throw new NotImplementedException();
        }

        public void avecCommeMaitreDuJeu(MaitreDuJeu maitreDuJeu)
        {
            this.maitreDuJeu = maitreDuJeu;
        }

        public void commencerPartie()
        {
            maitreDuJeu.conter(LoupGarou.Core.Properties.Resources.PresentationDuJeu);
        }

        public void donneInformationRole(string nomDuRole, Joueur joueur)
        {
            joueur.afficheInformationRole(descriptionParRole[nomDuRole]);
        }
    }
}
