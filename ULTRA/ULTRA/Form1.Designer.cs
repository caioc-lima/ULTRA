
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraVoicer = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PANEL_CONTENT = new System.Windows.Forms.Panel();
            this.IMG_ULTRON = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.PANEL_DIALOG = new System.Windows.Forms.Panel();
            this.LABEL_DIALOG = new System.Windows.Forms.Label();
            this.IMG_VOICER = new System.Windows.Forms.PictureBox();
            this.IMG_LOADING = new System.Windows.Forms.PictureBox();
            this.TIMER_LOADING = new System.Windows.Forms.Timer(this.components);
            this.IMG_DOG = new System.Windows.Forms.PictureBox();
            this.PANEL_CONTENT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_ULTRON)).BeginInit();
            this.panel1.SuspendLayout();
            this.PANEL_DIALOG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_VOICER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_LOADING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_DOG)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraVoicer
            // 
            this.BarraVoicer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraVoicer.Location = new System.Drawing.Point(0, 494);
            this.BarraVoicer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraVoicer.Maximum = 50;
            this.BarraVoicer.Name = "BarraVoicer";
            this.BarraVoicer.Size = new System.Drawing.Size(917, 8);
            this.BarraVoicer.TabIndex = 2;
            this.BarraVoicer.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PANEL_CONTENT
            // 
            this.PANEL_CONTENT.Controls.Add(this.IMG_DOG);
            this.PANEL_CONTENT.Controls.Add(this.IMG_ULTRON);
            this.PANEL_CONTENT.Controls.Add(this.panel1);
            this.PANEL_CONTENT.Controls.Add(this.labelStatus);
            this.PANEL_CONTENT.Controls.Add(this.PANEL_DIALOG);
            this.PANEL_CONTENT.Controls.Add(this.BarraVoicer);
            this.PANEL_CONTENT.Controls.Add(this.IMG_LOADING);
            this.PANEL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTENT.Location = new System.Drawing.Point(0, 0);
            this.PANEL_CONTENT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PANEL_CONTENT.Name = "PANEL_CONTENT";
            this.PANEL_CONTENT.Size = new System.Drawing.Size(917, 502);
            this.PANEL_CONTENT.TabIndex = 3;
            // 
            // IMG_ULTRON
            // 
            this.IMG_ULTRON.BackColor = System.Drawing.Color.Black;
            this.IMG_ULTRON.Dock = System.Windows.Forms.DockStyle.Top;
            this.IMG_ULTRON.Image = global::ULTRA.Properties.Resources.iron_man_jarvis_gif_3;
            this.IMG_ULTRON.Location = new System.Drawing.Point(0, 50);
            this.IMG_ULTRON.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IMG_ULTRON.Name = "IMG_ULTRON";
            this.IMG_ULTRON.Size = new System.Drawing.Size(917, 307);
            this.IMG_ULTRON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG_ULTRON.TabIndex = 8;
            this.IMG_ULTRON.TabStop = false;
            this.IMG_ULTRON.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 50);
            this.panel1.TabIndex = 1;
            // 
            // labelText
            // 
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelText.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.labelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.labelText.Location = new System.Drawing.Point(0, 0);
            this.labelText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(917, 50);
            this.labelText.TabIndex = 6;
            this.labelText.Text = "sadasdasd";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelText.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Black;
            this.labelStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStatus.Location = new System.Drawing.Point(354, 342);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(181, 11);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Visible = false;
            // 
            // PANEL_DIALOG
            // 
            this.PANEL_DIALOG.BackColor = System.Drawing.Color.Black;
            this.PANEL_DIALOG.Controls.Add(this.LABEL_DIALOG);
            this.PANEL_DIALOG.Controls.Add(this.IMG_VOICER);
            this.PANEL_DIALOG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PANEL_DIALOG.Location = new System.Drawing.Point(0, 362);
            this.PANEL_DIALOG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PANEL_DIALOG.Name = "PANEL_DIALOG";
            this.PANEL_DIALOG.Size = new System.Drawing.Size(917, 132);
            this.PANEL_DIALOG.TabIndex = 5;
            this.PANEL_DIALOG.Visible = false;
            // 
            // LABEL_DIALOG
            // 
            this.LABEL_DIALOG.Dock = System.Windows.Forms.DockStyle.Top;
            this.LABEL_DIALOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_DIALOG.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_DIALOG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.LABEL_DIALOG.Location = new System.Drawing.Point(0, 46);
            this.LABEL_DIALOG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABEL_DIALOG.Name = "LABEL_DIALOG";
            this.LABEL_DIALOG.Size = new System.Drawing.Size(917, 84);
            this.LABEL_DIALOG.TabIndex = 0;
            this.LABEL_DIALOG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LABEL_DIALOG.Click += new System.EventHandler(this.LABEL_DIALOG_Click);
            // 
            // IMG_VOICER
            // 
            this.IMG_VOICER.BackColor = System.Drawing.Color.Black;
            this.IMG_VOICER.Dock = System.Windows.Forms.DockStyle.Top;
            this.IMG_VOICER.Image = global::ULTRA.Properties.Resources.animated_sound_waves;
            this.IMG_VOICER.Location = new System.Drawing.Point(0, 0);
            this.IMG_VOICER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IMG_VOICER.Name = "IMG_VOICER";
            this.IMG_VOICER.Size = new System.Drawing.Size(917, 46);
            this.IMG_VOICER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG_VOICER.TabIndex = 9;
            this.IMG_VOICER.TabStop = false;
            this.IMG_VOICER.Visible = false;
            this.IMG_VOICER.Click += new System.EventHandler(this.IMG_VOICER_Click);
            // 
            // IMG_LOADING
            // 
            this.IMG_LOADING.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMG_LOADING.Image = global::ULTRA.Properties.Resources.loading;
            this.IMG_LOADING.Location = new System.Drawing.Point(0, 0);
            this.IMG_LOADING.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IMG_LOADING.Name = "IMG_LOADING";
            this.IMG_LOADING.Size = new System.Drawing.Size(917, 502);
            this.IMG_LOADING.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG_LOADING.TabIndex = 3;
            this.IMG_LOADING.TabStop = false;
            // 
            // TIMER_LOADING
            // 
            this.TIMER_LOADING.Tick += new System.EventHandler(this.TIMER_LOADING_Tick);
            // 
            // IMG_DOG
            // 
            this.IMG_DOG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IMG_DOG.Image = global::ULTRA.Properties.Resources.scary_angry;
            this.IMG_DOG.Location = new System.Drawing.Point(669, 118);
            this.IMG_DOG.Name = "IMG_DOG";
            this.IMG_DOG.Size = new System.Drawing.Size(164, 108);
            this.IMG_DOG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG_DOG.TabIndex = 9;
            this.IMG_DOG.TabStop = false;
            this.IMG_DOG.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(917, 502);
            this.Controls.Add(this.PANEL_CONTENT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultron IA - Caio Lima";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PANEL_CONTENT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_ULTRON)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PANEL_DIALOG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_VOICER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_LOADING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_DOG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar BarraVoicer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel PANEL_CONTENT;
        private System.Windows.Forms.PictureBox IMG_LOADING;
        private System.Windows.Forms.Timer TIMER_LOADING;
        private System.Windows.Forms.Panel PANEL_DIALOG;
        private System.Windows.Forms.Label LABEL_DIALOG;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox IMG_ULTRON;
        private System.Windows.Forms.PictureBox IMG_VOICER;
        private System.Windows.Forms.PictureBox IMG_DOG;
    }
}

