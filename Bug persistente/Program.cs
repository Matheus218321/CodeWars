class Program
{
    static void Main()
    {
        Console.WriteLine(Persistence(39));
    }

    static int Persistence(long Numero)
    {
        long Soma = Numero;
        int Multi = 1;
        int Repeti = 0;
        
        while(Soma >= 10)
        {
            Multi = 1;

            char[] Digito = Soma.ToString().ToCharArray();
            
            foreach(char Digitos in Digito)
            {
                Multi = Multi * (int)Char.GetNumericValue(Digitos);
            }

            Soma = Multi;
            Repeti++;
        }


        return Repeti;
    }
}
