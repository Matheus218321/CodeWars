class Program
{
    static void Main()
    {
        while (true)
        {
            int Gato = 0;
            int Cachorro = 0;

            Console.WriteLine("Digite a idade do Gato: ");
            Gato = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a idade do Cachorro: ");
            Cachorro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A idade do Gato e Cachorro, respectivamente: " + OwnedCatAndDog(Gato, Cachorro));
        }
    }

    public static (int, int) OwnedCatAndDog(int catYears, int dogYears)
    {
        int GatoReal = 0;
        int CachorroReal = 0;

        if (catYears == 15)
        {
            GatoReal = 1;
        }

        if (catYears == 15 + 9)
        {
            GatoReal = 1 + 1;
        }

        if (catYears > 15 + 9)
        {
            GatoReal = (catYears - 24) / 4 + 2;
        }

        if (dogYears == 15)
        {
            CachorroReal = 1;
        }

        if (dogYears == 15 + 9)
        {
            CachorroReal = 1 + 1;
        }

        if (dogYears > 15 + 9)
        {
            CachorroReal = (dogYears - 24) / 5 + 2;
        }

        if (catYears == 15)
        {
            GatoReal = 1;
        }

        if (dogYears == 15)
        {
            CachorroReal = 1;
        }


        return (GatoReal, CachorroReal);
    }
}

