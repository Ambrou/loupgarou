using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuLoupGarou.Helpers
{
    public class NarrationOral : Narration
    {
        public SpeechSynthesizer m_Narrateur = new SpeechSynthesizer();

        public NarrationOral()
        {
            m_Narrateur.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            m_Narrateur.Rate = -2;
        }

        public void narrer(string strHistoire)
        {
            m_Narrateur.Speak(strHistoire);
        }
    }
}
