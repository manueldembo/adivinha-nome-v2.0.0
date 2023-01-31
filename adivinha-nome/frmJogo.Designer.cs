namespace adivinha_nome
{
    partial class frmJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogo));
            this.lblRespostas = new System.Windows.Forms.Label();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.picTempo = new System.Windows.Forms.PictureBox();
            this.cmd01 = new System.Windows.Forms.Button();
            this.cmd02 = new System.Windows.Forms.Button();
            this.cmd03 = new System.Windows.Forms.Button();
            this.cmd04 = new System.Windows.Forms.Button();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRespostas
            // 
            this.lblRespostas.AutoSize = true;
            this.lblRespostas.BackColor = System.Drawing.Color.Transparent;
            this.lblRespostas.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostas.ForeColor = System.Drawing.Color.White;
            this.lblRespostas.Location = new System.Drawing.Point(449, 23);
            this.lblRespostas.Name = "lblRespostas";
            this.lblRespostas.Size = new System.Drawing.Size(116, 24);
            this.lblRespostas.TabIndex = 3;
            this.lblRespostas.Text = "Respostas: 0";
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.Black;
            this.picImagem.Location = new System.Drawing.Point(67, 50);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(500, 300);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // picTempo
            // 
            this.picTempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTempo.Location = new System.Drawing.Point(167, 356);
            this.picTempo.Name = "picTempo";
            this.picTempo.Size = new System.Drawing.Size(300, 30);
            this.picTempo.TabIndex = 9;
            this.picTempo.TabStop = false;
            // 
            // cmd01
            // 
            this.cmd01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(200)))));
            this.cmd01.BackgroundImage = global::adivinha_nome.Properties.Resources.botao;
            this.cmd01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd01.FlatAppearance.BorderSize = 0;
            this.cmd01.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmd01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd01.ForeColor = System.Drawing.Color.White;
            this.cmd01.Location = new System.Drawing.Point(56, 417);
            this.cmd01.Name = "cmd01";
            this.cmd01.Size = new System.Drawing.Size(250, 50);
            this.cmd01.TabIndex = 10;
            this.cmd01.UseVisualStyleBackColor = false;
            this.cmd01.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd02
            // 
            this.cmd02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(200)))));
            this.cmd02.BackgroundImage = global::adivinha_nome.Properties.Resources.botao;
            this.cmd02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd02.FlatAppearance.BorderSize = 0;
            this.cmd02.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmd02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd02.ForeColor = System.Drawing.Color.White;
            this.cmd02.Location = new System.Drawing.Point(56, 473);
            this.cmd02.Name = "cmd02";
            this.cmd02.Size = new System.Drawing.Size(250, 50);
            this.cmd02.TabIndex = 11;
            this.cmd02.UseVisualStyleBackColor = false;
            this.cmd02.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd03
            // 
            this.cmd03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(200)))));
            this.cmd03.BackgroundImage = global::adivinha_nome.Properties.Resources.botao;
            this.cmd03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd03.FlatAppearance.BorderSize = 0;
            this.cmd03.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmd03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd03.ForeColor = System.Drawing.Color.White;
            this.cmd03.Location = new System.Drawing.Point(329, 417);
            this.cmd03.Name = "cmd03";
            this.cmd03.Size = new System.Drawing.Size(250, 50);
            this.cmd03.TabIndex = 12;
            this.cmd03.UseVisualStyleBackColor = false;
            this.cmd03.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmd04
            // 
            this.cmd04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(200)))));
            this.cmd04.BackgroundImage = global::adivinha_nome.Properties.Resources.botao;
            this.cmd04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd04.FlatAppearance.BorderSize = 0;
            this.cmd04.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmd04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd04.ForeColor = System.Drawing.Color.White;
            this.cmd04.Location = new System.Drawing.Point(329, 473);
            this.cmd04.Name = "cmd04";
            this.cmd04.Size = new System.Drawing.Size(250, 50);
            this.cmd04.TabIndex = 13;
            this.cmd04.UseVisualStyleBackColor = false;
            this.cmd04.Click += new System.EventHandler(this.button4_Click);
            // 
            // tempo
            // 
            this.tempo.Interval = 1000;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.cmd04);
            this.Controls.Add(this.cmd03);
            this.Controls.Add(this.cmd02);
            this.Controls.Add(this.cmd01);
            this.Controls.Add(this.picTempo);
            this.Controls.Add(this.lblRespostas);
            this.Controls.Add(this.picImagem);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prova que você me conhece!---Acção---";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Label lblRespostas;
        private System.Windows.Forms.PictureBox picTempo;
        private System.Windows.Forms.Button cmd01;
        private System.Windows.Forms.Button cmd02;
        private System.Windows.Forms.Button cmd03;
        private System.Windows.Forms.Button cmd04;
        private System.Windows.Forms.Timer tempo;
    }
}