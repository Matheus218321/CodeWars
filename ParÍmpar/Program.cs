using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int Numero = 0;
            Console.WriteLine("Digite um número inteiro: ");
            Numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Esse número é: " + ParImpar(Numero));
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

        return "";
    }
}
