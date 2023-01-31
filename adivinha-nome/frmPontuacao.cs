using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adivinha_nome
{
    public partial class frmPontuacao : Form
    {
        int[] pontuacoes;
        public frmPontuacao()
        {
            InitializeComponent();

            clOperacoes ope = new clOperacoes();
            pontuacoes = ope.LerPontuacoes();

            lblPrimeiro.Text = $"---  {pontuacoes[2]} ---";
            lblSegundo.Text = $"---  {pontuacoes[1]} ---";
            lblTerceiro.Text = $"---  {pontuacoes[0]} ---";
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picVoltar_MouseEnter(object sender, EventArgs e)
        {
            picVoltar.Image = Image.FromFile(vars.voltarLuz);
        }

        private void picVoltar_MouseLeave(object sender, EventArgs e)
        {
            picVoltar.Image = Image.FromFile(vars.voltar);
        }
    }
}
