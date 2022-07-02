namespace FlappyBird
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            pipeDown.AutoSize = false;
            pipeTop.AutoSize = false;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chao = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFim = new System.Windows.Forms.Label();
            this.lblReiniciar = new System.Windows.Forms.Label();
            this.ceu = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chao
            // 
            this.chao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chao.Image = ((System.Drawing.Image)(resources.GetObject("chao.Image")));
            this.chao.Location = new System.Drawing.Point(0, 671);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(439, 50);
            this.chao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao.TabIndex = 0;
            this.chao.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(61, 349);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(80, 60);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // lblPlacar
            // 
            this.lblPlacar.AutoSize = true;
            this.lblPlacar.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacar.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.Location = new System.Drawing.Point(392, 9);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(37, 41);
            this.lblPlacar.TabIndex = 4;
            this.lblPlacar.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.Location = new System.Drawing.Point(196, 151);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(0, 39);
            this.lblFim.TabIndex = 6;
            this.lblFim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblReiniciar
            // 
            this.lblReiniciar.AutoSize = true;
            this.lblReiniciar.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReiniciar.Location = new System.Drawing.Point(196, 204);
            this.lblReiniciar.Name = "lblReiniciar";
            this.lblReiniciar.Size = new System.Drawing.Size(0, 39);
            this.lblReiniciar.TabIndex = 8;
            this.lblReiniciar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReiniciar.Click += new System.EventHandler(this.lblReiniciar_Click);
            // 
            // ceu
            // 
            this.ceu.BackColor = System.Drawing.Color.Transparent;
            this.ceu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ceu.Location = new System.Drawing.Point(0, 0);
            this.ceu.Name = "ceu";
            this.ceu.Size = new System.Drawing.Size(439, 0);
            this.ceu.TabIndex = 9;
            this.ceu.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image")));
            this.pipeTop.Location = new System.Drawing.Point(471, 727);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(110, 694);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown.Image")));
            this.pipeDown.Location = new System.Drawing.Point(471, 683);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(110, 721);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 721);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.lblReiniciar);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.ceu);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FLAPPY BIRD";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.chao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chao;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblReiniciar;
        private System.Windows.Forms.PictureBox ceu;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeDown;
    }
}

