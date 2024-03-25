using System.Text;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string Texto = "";
            Console.WriteLine("Digite um texto: ");
            Texto = Console.ReadLine();
            Console.WriteLine("Texto formatado: " + Replace(Texto));
        }
    }

    static string Replace(string Texto)
    { 
        string Conteudo = Texto.ToUpper();
        string ConteudoNormal = Texto;
        string ConteudoFormatado = Texto;
        
        for(int i = 0; i < Texto.Length; i++)
        {
            char[] Exclamacao = ConteudoFormatado.ToCharArray();
            Exclamacao[i] = '!';

            if (Conteudo[i].ToString() == "A" || Conteudo[i].ToString() == "E" || Conteudo[i].ToString() == "I" || Conteudo[i].ToString() == "O" || Conteudo[i].ToString() == "U")   
            {
                ConteudoFormatado = new string(Exclamacao);
            }
        }

        return ConteudoFormatado;
    }
}
