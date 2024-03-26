using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                int Numero = 0;
                Console.Write("Digite um número inteiro: ");
                Numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Esse número é: " + ParImpar(Numero));
            }

            catch
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Resposta não reconhecida!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

        }
    }

    static string ParImpar(int Numero)
    {
        if (Numero % 2 == 0)
        {
            return "Par";
        }

        else
        {
            return "Ímpar";
        }

    }
}
