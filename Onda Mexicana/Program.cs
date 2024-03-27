class Program
{
    static void Main()
    {
        while (true)
        {
            string Texto = "";
            Console.Write("Digite um texto: ");
            Texto = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Onda Mexicana: " + wave(Texto));
        }
    }

    public static List<string> wave(string str)
    {
        List<string> Onda = new List<string>();

        if (str != "")
        {
            string Texto = str;
            string PalavraTratada = "";

            for (int i = 0; i < Texto.Length; i++)
            {
                if (Char.IsWhiteSpace(Convert.ToChar(Texto[i])) == false)
                {
                    char[] Caracteres = Texto.ToCharArray();
                    Caracteres[i] = char.Parse(Texto[i].ToString().ToUpper());
                    PalavraTratada = new string(Caracteres);
                    Onda.Add(PalavraTratada);
                }
            }

            foreach (string n in Onda)
            {
                Console.WriteLine(n);
            }
        }
        else
        {
            return new List<string>();
        }

        return Onda;
    }
}
