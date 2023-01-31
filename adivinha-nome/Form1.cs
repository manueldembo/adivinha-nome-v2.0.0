using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace adivinha_nome
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Environment.CurrentDirectory + @"\_musicas\Toque2.wav";
            player.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.CurrentDirectory + @"\pontucao.txt"))
                File.CreateText(Environment.CurrentDirectory + @"\pontucao.txt");

            lblTitulo.Text = "Adivinha o nome!!!\n  Se fores á tempo!!!";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do jogo?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void picPontucao_Click(object sender, EventArgs e)
        {
            frmPontuacao frm = new frmPontuacao();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void picJogar_Click(object sender, EventArgs e)
        {
            frmJogo frm = new frmJogo();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void picPontucao_MouseEnter(object sender, EventArgs e)
        {
            picPontucao.Image = Image.FromFile(vars.pontuacaoLuz);
        }

        private void picPontucao_MouseLeave(object sender, EventArgs e)
        {
            picPontucao.Image = Image.FromFile(vars.pontuacao);
        }

        private void picJogar_MouseEnter(object sender, EventArgs e)
        {
            picJogar.Image = Image.FromFile(vars.comecarLuz);
        }

        private void picJogar_MouseLeave(object sender, EventArgs e)
        {
            picJogar.Image = Image.FromFile(vars.comecar);
        }
    }
}
