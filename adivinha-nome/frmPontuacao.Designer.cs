namespace adivinha_nome
{
    partial class frmPontuacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPontuacao));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblTerceiro = new System.Windows.Forms.Label();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "--- Recordes ---";
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimeiro.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiro.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiro.Location = new System.Drawing.Point(202, 93);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(200, 35);
            this.lblPrimeiro.TabIndex = 0;
            this.lblPrimeiro.Text = "--- Recordes ---";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundo.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.Color.White;
            this.lblSegundo.Location = new System.Drawing.Point(202, 152);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(200, 35);
            this.lblSegundo.TabIndex = 0;
            this.lblSegundo.Text = "--- Recordes ---";
            // 
            // lblTerceiro
            // 
            this.lblTerceiro.AutoSize = true;
            this.lblTerceiro.BackColor = System.Drawing.Color.Transparent;
            this.lblTerceiro.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceiro.ForeColor = System.Drawing.Color.White;
            this.lblTerceiro.Location = new System.Drawing.Point(202, 213);
            this.lblTerceiro.Name = "lblTerceiro";
            this.lblTerceiro.Size = new System.Drawing.Size(200, 35);
            this.lblTerceiro.TabIndex = 0;
            this.lblTerceiro.Text = "--- Recordes ---";
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.Image = global::adivinha_nome.Properties.Resources.voltar;
            this.picVoltar.Location = new System.Drawing.Point(372, 251);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(100, 100);
            this.picVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVoltar.TabIndex = 1;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.picVoltar_Click);
            this.picVoltar.MouseEnter += new System.EventHandler(this.picVoltar_MouseEnter);
            this.picVoltar.MouseLeave += new System.EventHandler(this.picVoltar_MouseLeave);
            // 
            // frmPontuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::adivinha_nome.Properties.Resources.pontuacao_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.lblTerceiro);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblPrimeiro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPontuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prova que você me conhece!---Recordes---";
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblTerceiro;
        private System.Windows.Forms.PictureBox picVoltar;
    }
}