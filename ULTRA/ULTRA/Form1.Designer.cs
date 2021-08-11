
namespace ULTRA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraVoicer = new System.Windows.Forms.ProgressBar();
            this.labelFala = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.ROBO = new System.Windows.Forms.PictureBox();
            this.IMG_BALON = new System.Windows.Forms.PictureBox();
            this.IMG_DOG = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ROBO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_BALON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_DOG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            // 
            // BarraVoicer
            // 
            this.BarraVoicer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraVoicer.Location = new System.Drawing.Point(0, 356);
            this.BarraVoicer.Margin = new System.Windows.Forms.Padding(2);
            this.BarraVoicer.Maximum = 50;
            this.BarraVoicer.Name = "BarraVoicer";
            this.BarraVoicer.Size = new System.Drawing.Size(600, 10);
            this.BarraVoicer.TabIndex = 2;
            // 
            // labelFala
            // 
            this.labelFala.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFala.Location = new System.Drawing.Point(90, 36);
            this.labelFala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFala.Name = "labelFala";
            this.labelFala.Size = new System.Drawing.Size(394, 88);
            this.labelFala.TabIndex = 3;
            this.labelFala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFala.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(41, 334);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(151, 8);
            this.labelStatus.TabIndex = 5;
            // 
            // labelText
            // 
            this.labelText.Location = new System.Drawing.Point(449, 300);
            this.labelText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(142, 42);
            this.labelText.TabIndex = 6;
            // 
            // ROBO
            // 
            this.ROBO.Image = global::ULTRA.Properties.Resources.giphy;
            this.ROBO.Location = new System.Drawing.Point(40, 150);
            this.ROBO.Margin = new System.Windows.Forms.Padding(2);
            this.ROBO.Name = "ROBO";
            this.ROBO.Size = new System.Drawing.Size(152, 181);
            this.ROBO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ROBO.TabIndex = 1;
            this.ROBO.TabStop = false;
            // 
            // IMG_BALON
            // 
            this.IMG_BALON.Image = global::ULTRA.Properties.Resources.balao_de_fala_transparente11_removebg_preview;
            this.IMG_BALON.Location = new System.Drawing.Point(9, 10);
            this.IMG_BALON.Margin = new System.Windows.Forms.Padding(2);
            this.IMG_BALON.Name = "IMG_BALON";
            this.IMG_BALON.Size = new System.Drawing.Size(552, 188);
            this.IMG_BALON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_BALON.TabIndex = 4;
            this.IMG_BALON.TabStop = false;
            this.IMG_BALON.Visible = false;
            // 
            // IMG_DOG
            // 
            this.IMG_DOG.Image = global::ULTRA.Properties.Resources.scary_angry;
            this.IMG_DOG.Location = new System.Drawing.Point(212, 202);
            this.IMG_DOG.Margin = new System.Windows.Forms.Padding(2);
            this.IMG_DOG.Name = "IMG_DOG";
            this.IMG_DOG.Size = new System.Drawing.Size(140, 136);
            this.IMG_DOG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_DOG.TabIndex = 7;
            this.IMG_DOG.TabStop = false;
            this.IMG_DOG.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.IMG_DOG);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelFala);
            this.Controls.Add(this.ROBO);
            this.Controls.Add(this.IMG_BALON);
            this.Controls.Add(this.BarraVoicer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultra IA - Caio Lima";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ROBO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_BALON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_DOG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ROBO;
        private System.Windows.Forms.ProgressBar BarraVoicer;
        private System.Windows.Forms.Label labelFala;
        private System.Windows.Forms.PictureBox IMG_BALON;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.PictureBox IMG_DOG;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

