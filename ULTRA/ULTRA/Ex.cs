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
            bancksound.Speak("Meu nome é Ultra");
        }

        public static void GetDog()
        {
            bancksound.Speak("Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi");
        }

        public static void GetBoaNoite()
        {
            bancksound.Speak("Boa noite");
        }

        public static void GetSaudacao()
        {
            bancksound.Speak("Eae doidão");
        }
        public static void GetPrazerETodoMeu()
        {
            bancksound.Speak("O prazer é todo meu");
        }

        public static void GetVoceELegal()
        {
            bancksound.Speak("Muito obrigado");
        }
        public static void GetQualSuaIdade()
        {
            bancksound.Speak("KKKKKKK, nem queira saber, você irá se assustar");
        }

        public static void GetMinhaIdade()
        {
            bancksound.Speak("Você me parece ser bem jovem");
        }

        public static void GetPiada()
        {
            bancksound.Speak("Não sou nenhum palhaço");
        }

        public static void GetOfensa1()
        {
            bancksound.Speak("Hey Hey Hey, você não pode dizer isso para mim, vou lavar sua boca com sabão");
        }

    }
}
