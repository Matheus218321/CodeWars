class Program
{
    static void Main(string[] args)
    {
        while (true) { 
        int Numero = 0;
        Console.WriteLine("Digite um número:");
        Numero = Convert.ToInt32(Console.ReadLine());
        
        if(Narci(Numero) == true)
        {
            Console.WriteLine("esse número é narcissista!");
        }
        else
        {
            Console.WriteLine("Esse núumero não é narcissista!");
        }

        }
    }

    static bool Narci(int value)
    {
        string NumeroString = value.ToString();
        int Digitos = 0;
        int Digito = 0;
        Digitos = NumeroString.Length;
        int Soma = 0;

        for (int i = 0; i < Digitos; i++)
        {
            Digito = (int)NumeroString[i].ToString();
            Soma = Soma + (int)Math.Pow(Digito, Digitos);
        }

        Console.WriteLine(Soma);

        if (Soma == value)
        {
            return true;
        }

        return false;

    }
}
