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

        int timeLeft = 100;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
                    if(Gramaticas.qualData.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetData();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Hoje é " + DateTime.Now.ToShortDateString();
                    }
                    else if (Gramaticas.quehorassao.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetHoras();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Agora são " + DateTime.Now.ToShortTimeString();
                    }
                    else if(Gramaticas.SeuNome.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetNome();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Meu Nome é Ultra";
                    }
                    else if (Gramaticas.Dog.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 100;
                        timer1.Start();
                        timeLeft = 100;
                        Ex.GetDog();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi, Psi Psi pSi, PsiPsiPsi, Psi Psi";
                        IMG_DOG.Visible = false;
                    }
                    else if (Gramaticas.BoaNoite.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetBoaNoite();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Boa noite";                        
                    }
                    else if (Gramaticas.Saudacao.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetSaudacao();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Eae doidão";
                    }
                    else if (Gramaticas.PrazerETodoMeu.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetPrazerETodoMeu();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Prazer é todo meu";
                    }
                    else if (Gramaticas.VoceeLegal.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetVoceELegal();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Muito obrigado";
                    }
                    else if (Gramaticas.QualSuaIdade.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetQualSuaIdade();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "KKKKKKK, nem queira saber, você irá se assustar";
                    }
                    else if (Gramaticas.MinhaIdade.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetMinhaIdade();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Você me parece ser bem jovem";
                    }
                    else if (Gramaticas.Piada.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetPiada();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Não sou nenhum palhaço";
                    }
                    else if (Gramaticas.Ofensa1.Any(f => f == fala))
                    {
                        timer2.Start();
                        temp = 1000;
                        Ex.GetOfensa1();
                        labelFala.ResetText();
                        labelFala.Visible = true;
                        IMG_BALON.Visible = true;
                        labelFala.Text = "Hey Hey Hey, você não pode dizer isso para mim, vou lavar sua boca com sabão";
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
            comando.Add(Gramaticas.qualData.ToArray());
            comando.Add(Gramaticas.SeuNome.ToArray());
            comando.Add(Gramaticas.Dog.ToArray());
            comando.Add(Gramaticas.BoaNoite.ToArray());
            comando.Add(Gramaticas.Saudacao.ToArray());
            comando.Add(Gramaticas.PrazerETodoMeu.ToArray());
            comando.Add(Gramaticas.VoceeLegal.ToArray());
            comando.Add(Gramaticas.QualSuaIdade.ToArray());
            comando.Add(Gramaticas.MinhaIdade.ToArray());
            comando.Add(Gramaticas.Piada.ToArray());
            comando.Add(Gramaticas.Ofensa1.ToArray());
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
    }
}
