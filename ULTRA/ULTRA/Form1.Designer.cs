
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
            this.label1 = new System.Windows.Forms.Label();
            this.ROBO = new System.Windows.Forms.PictureBox();
            this.BarraVoicer = new System.Windows.Forms.ProgressBar();
            this.labelFala = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ROBO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // ROBO
            // 
            this.ROBO.Image = global::ULTRA.Properties.Resources.giphy;
            this.ROBO.Location = new System.Drawing.Point(42, 48);
            this.ROBO.Name = "ROBO";
            this.ROBO.Size = new System.Drawing.Size(232, 347);
            this.ROBO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ROBO.TabIndex = 1;
            this.ROBO.TabStop = false;
            // 
            // BarraVoicer
            // 
            this.BarraVoicer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraVoicer.Location = new System.Drawing.Point(0, 438);
            this.BarraVoicer.Name = "BarraVoicer";
            this.BarraVoicer.Size = new System.Drawing.Size(800, 12);
            this.BarraVoicer.TabIndex = 2;
            // 
            // labelFala
            // 
            this.labelFala.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFala.Location = new System.Drawing.Point(374, 48);
            this.labelFala.Name = "labelFala";
            this.labelFala.Size = new System.Drawing.Size(381, 347);
            this.labelFala.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFala);
            this.Controls.Add(this.BarraVoicer);
            this.Controls.Add(this.ROBO);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultra IA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ROBO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ROBO;
        private System.Windows.Forms.ProgressBar BarraVoicer;
        private System.Windows.Forms.Label labelFala;
    }
}

