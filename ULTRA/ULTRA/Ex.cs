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
            bancksound.Speak("Hoje é " + DateTime.Now.ToString());
        }

        public static void GetBomDia()
        {
            bancksound.Speak("Bom dia, desconsou?");
        }
        public static void GetBoaTarde()
        {
            bancksound.Speak("Boa tarde meu amigo");
        }
        public static void GetBoaNoite()
        {
            bancksound.Speak("Boa noite humano, já vai dormir bicho preguiça");
        }
        public static void GetDog()
        {
            bancksound.Speak("Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi");
        }

        public static void GetJaPode()
        {
            bancksound.Speak("Já pode ou está cedo ainda? Só bora");
        }

        public static void GetConheceAna()
        {
            bancksound.Speak("Sim, aquela princesinha");
        }

        public static void GetNomeUltron()
        {
            bancksound.Speak("Meu nome é Ultron");
        }

        public static void Getofensa1()
        {
            bancksound.Speak("Hey, você não pode falar isso para mim! Merece levar umas maderadas");
        }

        public static void GetTudoBemUltron()
        {
            bancksound.Speak("Obrigado por perguntar, eu esotu bem e você como esta");
        }

        public static void GetFaladaAnna()
        {
            bancksound.Speak("Ah, sem palavras para falar o quanto ela é especial, se ela soubesse... é verdade que você gosta dela, pode falar minha memória é limpa depois que me fecham");
        }

        public static void GetConheceAdriana()
        {
            bancksound.Speak("Sim, ela parece ser muito brava");
        }
    }
}
