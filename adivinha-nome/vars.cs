using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinha_nome
{
    public static class vars
    {
        #region caminhos
        public static string caminhoImagens = Environment.CurrentDirectory + @"\_imagens\";
        public static string caminhoMusica = Environment.CurrentDirectory + @"\_musicas\Toque2.wav";
        public static string pastaPersonagens = caminhoImagens + @"\_personagens\";
        public static string pastaAnimes = caminhoImagens + @"\_animes\";

        public static string comecar = caminhoImagens + "comecar.png";
        public static string comecarLuz = caminhoImagens + "comecar-luz.png";
        public static string voltar = caminhoImagens + "voltar.png";
        public static string voltarLuz = caminhoImagens + "voltar-luz.png";
        public static string pontuacao = caminhoImagens + "pontuacao.png";
        public static string pontuacaoLuz = caminhoImagens + "pontuacao-luz.png";
        public static string responder = caminhoImagens + "responder.png";
        public static string responderLuz = caminhoImagens + "responder-luz.png";

        public static string pontuacaoFundo = caminhoImagens + "pontuacao-fundo.png";

        #region caminho do temporizador
        public static string caminhoTemporizador = caminhoImagens + @"_temporizador\";
        public static string[] imagensTemporizador = new string[]{ "temp01.png", "temp02.png", "temp03.png", "temp04.png", "temp05.png", "temp06.png", "temp07.png", "temp08.png", "temp09.png", "temp10.png", "temp11.png", "temp12.png", "temp13.png", "temp14.png", "temp15.png" };
        #endregion
        #endregion

        #region imagens do jogo
        public static string[] imagensPersonagens = { "asta.png", "bakugo.jpg", "bakugo.png", "bils.jpg", "broly.png", "chikamaro.jpg", "chikamaru.jpg", "deku.jpg","deku-2.jpg","gara.jpg", "goku.jpg", "goku-black.jpg", "goku-2.png", "guy.jpg", "hashirama.jpg", "hashirama.png","hashirama-2.png", "hinata.png","hinata-2.jpg", "ichigo.jpg", "itachi.png", "itachi-2.jpg", "kakashi.jpg","lee.jpg", "madara.png", "might.jpg", "minato.jpg","minato-2.jpg", "naruto.jpg", "naruto-3.png", "pain.jpg", "sasuke.jpg","sasuke-2.jpg", "tobirama.png", "zoro.png","zoro-2.png", "sanji.png", "2-agatsuma-zenitsu.png", "2-bakugou.png", "2-eijiro-kirishima.png", "2-endever.png", "2-hashibira-inosuke.png", "2-kamado-tanjiro-2.png", "2-Rengoku.png", "2-rengoku-2.png", "2-shinomiya-kaguya.png", "2-tanjiro.png", "2-tenya-iida.png", "2-Tomura-Shigaraki.png", "3-all.jpg", "3-bakugou.jpg", "3-genus.jpeg", "3-ichigo.jpg", "3-itachi.jpg", "3-levi.jpeg", "3-levi-2.jpeg", "3-light-yagami.jpeg", "3-meliodas.jpg", "3-mokey.jpeg", "3-monkey-d-ruffy.jpeg", "3-nezuko.jpeg", "3-pain.jpg", "3-ranga.jpeg", "3-rimuru-tempest.jpeg", "3-ruffy.jpg", "3-saitama.jpeg", "3-senku.jpeg", "3-senku-ishigami.jpeg", "3-shigaraki-tomura.jpeg", "3-tsuyu.jpeg", "3-tsuyu-asui.jpeg", "3-zoro.jpeg" };
        #endregion

        #region respostas
        public static string[] respostasPersonagens = { "asta", "katsuki bakugou", "katsuki bakugou", "bils", "broly", "nara shikamaru", "nara shikamaru", "midoriya izuku","midoriya izuku","sabaku no gaara", "son goku", "goku black", "son goku", "maito gai", "hashirama senju", "hashirama senju","hashirama senju","hinata hyuuga", "hinata hyuuga", "kurosaki ichigo", "itachi uchiha", "itachi uchiha", "kakashi hatake","rock lee", "madara uchiha","all might", "minato namikaze", "minato namikaze", "naruto uzumaki", "naruto uzumaki", "pain", "sasuke uchiha","sasuke uchiha","tobirama senju", "roro noa zoro", "roro noa zoro", "sanji okay", "agatsuma zenitsu", "katsuki bakugou", "eijiro kirishima", "endever shoto", "hashibira inosuke", "kamado tanjiro", "rengoku", "rengoku", "shinomiya kaguya", "kamado tanjiro", "tenya iida", "tomura shigaraki", "all might", "katsuki bakugou", "genos", "kurosaki ichigo", "itachi uchiha", "levi", "levi", "light yagami", "meliodas", "monkey d. ruffy", "monkey d. ruffy", "nezuko", "pain", "ranga tempest", "rimuru tempest", "monkey d. ruffy", "saitama", "senku ishigami", "senku ishigami", "shigaraki tomura", "tsuyu asui", "tsuyu asui", "roro noa zoro" };
        #endregion

        #region opcões de resposta
        public static string[] opcoesResposta = { "deku", "asta", "black clover", "katsuki bakugou", "son goku","bils","goku", "broly","ino-chika-cho", "nara shikamaru","deku", "midoriya izuku", "all might","sabaku no gaara", "gaara","son goku", "goku black", "maito gai", "primeiro hokague", "hinata uzumaki","hinata hyuuga", "kurosaki", "kurosaki ichigo", "ichigo", "shisui uchiha", "itachi uchiha", "kakashi hatake", "kakashi sensei","lee", "rock lee", "madara uchiha","all might", "minato namikaze", "minato uzumaki", "naruto","naruto uzumaki", "gai", "kakashi", "minato", "madara", "ashira das chamas", "one piece", "shoto", "bakugou", "shoto", "naruto namikaze", "nagato", "pain", "sasuke uchiha","sasuke uchiha","sarutobe", "tobirama senju", "segundo hokague", "espachin", "roro noa zoro", "zoro","sanji okay", "endever", "kirito", "vilão", "zoro", "tanjiro", "kaki"};
        #endregion
    }
}
