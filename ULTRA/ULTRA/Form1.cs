using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms;

namespace ULTRA
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine engine;
        private CultureInfo ci;
        public string NAME_ASSISTENT = "Ultra";
        Random randomziner = new Random();

        int ini;
        int end;
        int temp;

        int timeLoading;
        int timeLeft = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TIMER_LOADING.Start();
            timeLoading = 50;
            Init();
        }

        private void Init()
        {
            try
            {
                ci = new CultureInfo("en-US");
                engine = new SpeechRecognitionEngine(ci);
                SpeechRec();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro em Init()");
            }
        }

        private void setText(string text)
        {
            this.labelText.Text = "Pergunta: " + text;
        }

        private void setColor(string cor)
        {
            switch (cor)
            {
                case "green":
                    this.labelStatus.BackColor = Color.Green;
                    break;
                case "red":
                    this.labelStatus.BackColor = Color.Red;
                    break;
                default:
                    this.labelStatus.BackColor = Color.Black;
                    break;                        
            }
        }

        private void SpeechRec()
        {
            try
            {
                List<Grammar> g = Load_Grammar();

                #region Speech Recognition (Eventos)
                engine.SetInputToDefaultAudioDevice();

                foreach (Grammar gr in g)
                {
                    engine.LoadGrammar(gr);
                }

                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Rec);
                engine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(AudioLevel);
                engine.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(Rejected);
                #endregion

                // Realiza o reconhecimento de voz
                engine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro em SpeechRec");
            }
        }

        #region Evento de reconhecimento
        private void Rec(object s, SpeechRecognizedEventArgs e)
        {
            string fala = e.Result.Text;

            setText(fala);
            setColor("green");

            switch (e.Result.Grammar.Name)
            {
                case "System":
                    // Tudo aqui dentro é correspondente à gramatica System
                    if (Gramaticas.quehorassao.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        IMG_VOICER.Visible = true;
                        Ex.GetHoras();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Agora são " + DateTime.Now.ToShortTimeString();
                    }
                    else if (Gramaticas.QueDiaeHoje.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetData();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Hoje é " + DateTime.Now.ToString();
                    }
                    else if (Gramaticas.BomDia.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetBomDia();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Bom dia, você descansou";
                    }
                    else if (Gramaticas.BoaTarde.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetBoaTarde();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Boa tarde humano";
                    }
                    else if (Gramaticas.Boanoite.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetBoaNoite();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Boa noite, já vai dormir bicho preguiça";
                    }
                    else if (Gramaticas.Dog.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        timer1.Start();
                        timeLeft = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetDog();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi";
                    }
                    else if (Gramaticas.JaPode.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetJaPode();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Ja pode ou está cedo? Só bora";
                    }
                    else if (Gramaticas.ConheceAdriana.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetFaladaAnna();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Sim, ela parece ser muito brava";
                    }
                    else if (Gramaticas.ConheceAnna.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetConheceAna();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Sim, aquela princesinha";
                    }
                    else if (Gramaticas.QualSeuNome.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetNomeUltron();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Meu nome é Ultron";
                    }
                    else if (Gramaticas.Ofensa1.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.Getofensa1();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Hey, você não pode falar isso para mim! Merece levar umas maderadas";
                    }
                    else if (Gramaticas.TudoBemUltron.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetTudoBemUltron();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Meu nome é Ultron";
                    }
                    else if (Gramaticas.SobreAAna.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        IMG_VOICER.Visible = true;
                        Ex.GetFaladaAnna();
                        LABEL_DIALOG.ResetText();
                        LABEL_DIALOG.Visible = true;
                        LABEL_DIALOG.Text = "Ah, sem palavras para falar o quanto ela é especial, se ela soubesse... é verdade que você gosta dela, pode falar minha memória é limpa depois que me fecham";
                    }

                    break;
                        
            }
        }

        private void AudioLevel(object s, AudioLevelUpdatedEventArgs e)
        {
            if (e.AudioLevel > BarraVoicer.Maximum)
            {
                BarraVoicer.Value = BarraVoicer.Maximum;
            }
            else if (e.AudioLevel < BarraVoicer.Minimum)
            {
                BarraVoicer.Value = BarraVoicer.Minimum;
            }
            else
            {
                this.BarraVoicer.Value = e.AudioLevel;
            }
        }

        private void Rejected(object s, SpeechRecognitionRejectedEventArgs e)
        {
            setText(e.Result.Text);
            setColor("red");
        }
        #endregion


        private List<Grammar> Load_Grammar()
        {
            List<Grammar> gramaticaParaFala = new List<Grammar>();

            #region Choices
            Choices comando = new Choices();
            // LISTA DE VOICES COMMANDS
            comando.Add(Gramaticas.quehorassao.ToArray());
            comando.Add(Gramaticas.QueDiaeHoje.ToArray());
            comando.Add(Gramaticas.BomDia.ToArray());
            comando.Add(Gramaticas.BoaTarde.ToArray());
            comando.Add(Gramaticas.Boanoite.ToArray());
            comando.Add(Gramaticas.Dog.ToArray());
            comando.Add(Gramaticas.ConheceAnna.ToArray());
            comando.Add(Gramaticas.QualSeuNome.ToArray());
            comando.Add(Gramaticas.IdadeUltron.ToArray());
            comando.Add(Gramaticas.Ofensa1.ToArray());
            comando.Add(Gramaticas.TudoBemUltron.ToArray());
            comando.Add(Gramaticas.SobreAAna.ToArray());
            comando.Add(Gramaticas.ConheceAdriana.ToArray());

            #endregion
            #region GrammarBuilder
            GrammarBuilder comando_gb = new GrammarBuilder();
            comando_gb.Append(comando);
            #endregion
            #region Grammar
            Grammar gramaticaSystem = new Grammar(comando_gb);
            gramaticaSystem.Name = "System";
            #endregion

            gramaticaParaFala.Add(gramaticaSystem);
            return gramaticaParaFala;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                IMG_DOG.Visible = true;
            }
            else
            {
                timer1.Stop();
                IMG_DOG.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(temp > 0)
            {
                temp--;
            }
        }

        private void TIMER_LOADING_Tick(object sender, EventArgs e)
        {

            if(timeLoading > 0)
            {
                labelText.Text = "Carregando arquivos...";
                timeLoading--;
            }
            else
            {
                // HIDE
                IMG_LOADING.Visible = false;

                // SHOW
                PANEL_DIALOG.Visible = true;
                IMG_ULTRON.Visible = true;
                BarraVoicer.Visible = true;
                TIMER_LOADING.Stop();
                timeLoading = 0;
                labelText.Text = "Pergunta: ";
            }
        }

        private void IMG_VOICER_Click(object sender, EventArgs e)
        {

        }

        private void LABEL_DIALOG_Click(object sender, EventArgs e)
        {

        }
    }
}
