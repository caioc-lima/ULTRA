using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRA
{
    class Ex
    {
        // Métodos básico de fala

        public static void GetHoras()
        {
            bancksound.Speak(DateTime.Now.ToShortTimeString());
        }

        public static void GetData()
        {
            bancksound.Speak("Hoje é" + DateTime.Now.ToShortDateString());
        }

        public static void GetNome()
        {
            bancksound.Speak("My name is Zenboo");
        }

        public static void GetDog()
        {
            bancksound.Speak("Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi");
        }
    }
}
