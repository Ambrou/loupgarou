using JeuDuLoupGarou.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuLoupGarou.Roles
{
    public class MaitreDuJeu
    {
        public SpeechSynthesizer m_Parole;

        private Narration m_Narration = null;

        public MaitreDuJeu(Narration narration)
        {
            m_Narration = narration;
            //m_Parole = new SpeechSynthesizer();
            //m_Parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            //m_Parole.Rate = -2;
        }

        public virtual void annonceLeProchainMort(string nomDuJoueurMort)
        {
            String texte = "et " + nomDuJoueurMort + " est retrouvé mort.";
            m_Narration.narrer(texte);
        }

        public virtual void annonceLeLeverDuJour()
        {
            m_Narration.narrer("Le jour se léve et le village se réveille");
        }

        public virtual void annonceLeRole(string strNomDuRole)
        {
            m_Narration.narrer("Le village vient de perdre " + strNomDuRole);
        }
    }
}
