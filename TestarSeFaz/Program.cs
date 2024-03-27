using System.Diagnostics.Tracing;

class Program
{
    static void Main()
    {
        /*
        while (true)
        {
            int Segundos = 0;
            Console.WriteLine("Digite os segundos: ");
            Segundos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Horário: " + GetReadableTime(Segundos));
        }
        */

        //Console.WriteLine((Order("1Matheus 2Sophia Gil3son")));
        wave(" Oi matheus ");
        
    }

    public static string GetReadableTime(int seconds)
    {

        string Horas = "";
        int Hora = 0;
        int Minuto = 0;
        int Segundo = 0;
        
        Hora = seconds / 3600;
        Minuto = (seconds % 3600) / 60;
        Segundo = seconds % 60;

        Horas = String.Format("{0:00}:{1:00}:{2:00}", Hora, Minuto, Segundo);

        return Horas;
    }

    public static string Order(string words)
    {
        //words = "1Matheus 2Sophia Gil3son";
        string[] PalavrasDivi = words.Split(' ');
        
        string Texto = words;
        char[] Caracteres = words.ToCharArray();
        string TextoFormatado = "";
        int Numeros = 0;
        int LetrasPassou = Texto.Length;
        string PalavraUnica = "";
        int Espacos = 0;
        int ComecoPalavra = 0;
        Console.WriteLine(LetrasPassou);

        Console.WriteLine(PalavrasDivi[0] + PalavrasDivi[1] + PalavrasDivi[2]);
        

        Console.WriteLine(Numeros);

        string[] Palavra = new string[Numeros];

        for(int i = 0; i < PalavrasDivi.Length; i++)
        {
            for (int j = 0; j < PalavrasDivi[i].Length; j++)
            {
                if (Char.IsDigit(Convert.ToChar(PalavrasDivi[j])))
                {

                }
            }
        }



















        //words = "1Matheus 2Sophia Gil3son";
        //LetrasPassou = 24

        /*
        for (int i = ComecoPalavra; i < Texto.Length; i++)
        {
            //Detectou um espaço

            if (Char.IsWhiteSpace(Texto[i]) == true)
            {
                
                Espacos++;
                ComecoPalavra = Texto[i].ToString().Length;
                
                
            }

            
        }


        for(int i = 0; i < Texto.Length && i < LetrasPassou; i++)
        {
            Console.WriteLine("oi");

            if (Char.IsWhiteSpace(Texto[i]) == true)
            {
                Espacos++;
                LetrasPassou = Texto[i].ToString().Length;


                for (int j = 0; j < LetrasPassou; j++)
                {
                    PalavraUnica += Texto[j];
                }
            }
        }
        */
        Console.WriteLine(Espacos);

        /*
        for(int i = 0; i < Numeros; i++)
        {
            TextoFormatado += Palavra[Numeros] + " ";
        }
        */

        return TextoFormatado;
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
