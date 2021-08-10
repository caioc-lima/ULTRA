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

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSpeech();
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
            labelFala.ResetText();
            labelFala.Text = e.Result.Text;
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

        }
        #endregion


        private List<Grammar> Load_Grammar()
        {
            List<Grammar> gramaticaParaFala = new List<Grammar>();

            #region Choices
            Choices comando = new Choices();
            comando.Add(Gramaticas.quehorassao.ToArray());
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

        private void LoadSpeech()
        {
            try
            {
                engine = new SpeechRecognitionEngine();
                engine.SetInputToDefaultAudioDevice();

                string[] words = { "olá", "bom dia", "boa tarde", "boa noite", "que horas são", "me fale as horas por favor" };

                engine.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(words))));

                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Rec);
                engine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu no LoadSpeech(): " + ex.Message);
            }
        }

    }
}
