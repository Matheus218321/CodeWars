class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string Texto = "";
            Console.WriteLine("Digite um texto: ");
            Texto = Console.ReadLine();
            Console.WriteLine("Seu texto sem pontos de exclamação: " + RemoverExclamacao(Texto));
        }
    }

    static string RemoverExclamacao(string Texto)
    {
        string TextoFinal = "";

        for (int i = 0; i < Texto.Length; i++)
        {
            if (Texto[i].ToString() != "!")
            {
                TextoFinal += Texto[i];
            }
        }

        return TextoFinal;
    }
}