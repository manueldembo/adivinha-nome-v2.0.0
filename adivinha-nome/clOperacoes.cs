using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace adivinha_nome
{
    internal class clOperacoes
    {
        string caminhoFicheiroPontucao =Environment.CurrentDirectory + @"\pontucao.txt";
        public int[] LerPontuacoes()
        {
            if (!File.Exists(caminhoFicheiroPontucao))
                File.CreateText(caminhoFicheiroPontucao).Close();

            int[] pontuacoes = new int[3];
            int index = 0;
            try
            {
                StreamReader sr = new StreamReader(caminhoFicheiroPontucao);

                while (!sr.EndOfStream)
                    pontuacoes[index++] = int.Parse(sr.ReadLine());

                sr.Close();
                Array.Sort(pontuacoes);
            }
            catch { }

            return pontuacoes;
        }
        public void GravarPontuacoes(int pontuacao, int[] pontuacoes)
        {
            if (!File.Exists(caminhoFicheiroPontucao))
                File.CreateText(caminhoFicheiroPontucao).Close();

            int[] pontuacoesR = OrdenarPontuacoes(pontuacao, pontuacoes);

            try
            {
                StreamWriter sw = new StreamWriter(caminhoFicheiroPontucao, false);

                for (int i = 0; i < pontuacoes.GetLength(0); i++)
                    sw.WriteLine(pontuacoes[i]);

                sw.Close();
            }
            catch{}
        }
        private int[] OrdenarPontuacoes(int pontuacao, int[] pontuacoes)
        {
            if (pontuacao > pontuacoes[0])
                pontuacoes[0] = pontuacao;
            Array.Sort(pontuacoes);
            return pontuacoes;
        }

    }
}

 