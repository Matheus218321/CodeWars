class Program
{
    static void Main()
    {
        while (true)
        {
            string Texto = "";
            Console.WriteLine("Digite um texto: ");
            Texto = Console.ReadLine();
            Console.WriteLine("Esse texto possui uma porcentagem de erro de " + PrinterError(Texto));
        }
    }

    public static string PrinterError(String s)
    {
        int Erros = 0;
        int Digitos = s.Length; 
        char[] Digito = s.ToCharArray();

        for(int i = 0; i < Digitos; i++)
        {
            if (Digito[i] < 'a' || Digito[i] > 'm')
            {
                Erros++;
            }
        }

        return Erros + "/" + Digitos;
        
    }
}
