class Program
{
    static int TotalPontos(string[] games)
    {
        int Total = 0;

        foreach (string jogo in games)
        {
            string[] Pontuacao = jogo.Split(':');

            int PontosCasa = Convert.ToInt32(Pontuacao[0]);
            int PontosInimigo = Convert.ToInt32(Pontuacao[1]);

            if (PontosCasa > PontosInimigo)
            {
                Total += 3;
            }

            if (PontosCasa == PontosInimigo)
            {
                Total += 1;
            }

        }

        return Total;
    }
}
