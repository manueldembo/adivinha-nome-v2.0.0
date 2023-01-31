using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace adivinha_nome
{
    public partial class frmJogo : Form
    {
        int pontuacao = 0;
        int pos = 0;
        int contador = 0;
        int[] pontuacoes;
        ArrayList respostas = new ArrayList();
        ArrayList opcoes = new ArrayList();
        ArrayList imagens = new ArrayList();
        clOperacoes ope = new clOperacoes();

        public frmJogo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            pontuacoes = ope.LerPontuacoes();
            respostas.AddRange(vars.respostasPersonagens);
            imagens.AddRange(vars.imagensPersonagens);
            opcoes.AddRange(vars.opcoesResposta);
        }
        
        private void frmJogo_Load(object sender, EventArgs e)
        {
            GerarPergunta();
        }
        private void GerarPergunta() {
            contador = 0;
            LimaparBotoes();

            Random rd = new Random();
            int pos = rd.Next(0, respostas.Count);
            picImagem.Image = Image.FromFile(vars.pastaPersonagens + imagens[pos]);
            picTempo.BackgroundImage = Image.FromFile(vars.caminhoTemporizador + vars.imagensTemporizador[0]);
            this.pos = pos;

            GerarOpcoes();
            tempo.Start();
        }
        private void LimaparBotoes() {
            foreach (Control controle in this.Controls)
                if (controle is Button)
                    ((Button)(controle)).Text = "";
        }
        private void GerarOpcoes() {
            Random rd = new Random();
            int index = rd.Next(0, 4);
            int index2 = 0;
            #region gerar resposta
            switch (index) {
                case 0:
                    cmd01.Text = respostas[pos].ToString().ToUpper();
                    break;
                case 1:
                    cmd02.Text = respostas[pos].ToString().ToUpper();
                    break;
                case 2:
                    cmd03.Text = respostas[pos].ToString().ToUpper();
                    break;
                case 3:
                    cmd04.Text = respostas[pos].ToString().ToUpper();
                    break;
            }
            #endregion

            #region outras
            for (int i = 0; i < 3; i++)
            {
                do {
                    index2 = rd.Next(0, opcoes.Count);
                } while (opcoes[index2].ToString() == respostas[pos].ToString());

                if (cmd01.Text == "")
                    cmd01.Text = opcoes[index2].ToString().ToUpper();

                else if (cmd02.Text == "")
                    cmd02.Text = opcoes[index2].ToString().ToUpper();

                else if (cmd03.Text == "")
                    cmd03.Text = opcoes[index2].ToString().ToUpper();

                else if(cmd04.Text == "")
                    cmd04.Text = opcoes[index2].ToString().ToUpper();
            }
            #endregion
        }

        private void RespostaCerta() {
            pontuacao++;
            lblRespostas.Text = $"Respostas: {pontuacao}";
            respostas.RemoveAt(pos);
            imagens.RemoveAt(pos);
            contador = 0;
            picTempo.BackgroundImage = Image.FromFile(vars.caminhoTemporizador + vars.imagensTemporizador[0]);

            if (pontuacao == 10)
                tempo.Interval = 700;
            if (pontuacao == 20)
                tempo.Interval = 500;
            if (pontuacao == 30)
                tempo.Interval = 200;

            if (pontuacao == vars.respostasPersonagens.Length)
            {
                MessageBox.Show("Parabéns você ganhou");
                this.Close();
                ope.GravarPontuacoes(pontuacao, pontuacoes);
            }
            else
                GerarPergunta();
        }

        private void ValidarResposta(string resposta, Button cmd) {
            if (resposta == respostas[pos].ToString().ToUpper()) 
                RespostaCerta();
            else
            {
                tempo.Stop();
                cmd.ForeColor = Color.Red;
                MessageBox.Show($"Você perdeu!\nPontuação: {pontuacao}");
                ope.GravarPontuacoes(pontuacao, pontuacoes);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarResposta(cmd01.Text, cmd01);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ValidarResposta(cmd02.Text, cmd02);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ValidarResposta(cmd03.Text, cmd03);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ValidarResposta(cmd04.Text, cmd04);
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            if (contador == 15)
            {
                tempo.Stop();
                ValidarResposta("ERRO", cmd01);
            }
            else
                picTempo.BackgroundImage = Image.FromFile(vars.caminhoTemporizador + vars.imagensTemporizador[contador++]);
        }
    }
}
