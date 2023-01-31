namespace adivinha_nome
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picJogar = new System.Windows.Forms.PictureBox();
            this.picPontucao = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picJogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPontucao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(67, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(350, 126);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "sei lá";
            // 
            // picJogar
            // 
            this.picJogar.BackColor = System.Drawing.Color.Transparent;
            this.picJogar.Image = global::adivinha_nome.Properties.Resources.comecar;
            this.picJogar.Location = new System.Drawing.Point(264, 193);
            this.picJogar.Name = "picJogar";
            this.picJogar.Size = new System.Drawing.Size(100, 100);
            this.picJogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogar.TabIndex = 1;
            this.picJogar.TabStop = false;
            this.picJogar.Click += new System.EventHandler(this.picJogar_Click);
            this.picJogar.MouseEnter += new System.EventHandler(this.picJogar_MouseEnter);
            this.picJogar.MouseLeave += new System.EventHandler(this.picJogar_MouseLeave);
            // 
            // picPontucao
            // 
            this.picPontucao.BackColor = System.Drawing.Color.Transparent;
            this.picPontucao.Image = global::adivinha_nome.Properties.Resources.pontuacao;
            this.picPontucao.Location = new System.Drawing.Point(120, 193);
            this.picPontucao.Name = "picPontucao";
            this.picPontucao.Size = new System.Drawing.Size(100, 100);
            this.picPontucao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPontucao.TabIndex = 0;
            this.picPontucao.TabStop = false;
            this.picPontucao.Click += new System.EventHandler(this.picPontucao_Click);
            this.picPontucao.MouseEnter += new System.EventHandler(this.picPontucao_MouseEnter);
            this.picPontucao.MouseLeave += new System.EventHandler(this.picPontucao_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(394, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manuel Dembo";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(200)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picJogar);
            this.Controls.Add(this.picPontucao);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prova que você me conhece!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picJogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPontucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPontucao;
        private System.Windows.Forms.PictureBox picJogar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
    }
}

