using System.Diagnostics.Tracing;
using System.Runtime.InteropServices.Marshalling;

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
        /*
        while (true)
        {
            int Numero = 0;
            Console.WriteLine("Digite uma fatorial de um número: ");
            Numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número de zeros à direita: " + TrailingZeros(Numero));
        }
        */
        /*
        while (true)
        {
            int a, b, c, d;
            Console.WriteLine("Digite o 1 número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2 número: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 3 número: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 4 número: ");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Horário: " + LatestClock(a, b, c, d));
        }
        */
        /*
        while (true)
        {
            string Ingredientes = "";
            Console.WriteLine("Digite os ingreientes: ");
            Ingredientes = Console.ReadLine();
            Tacofy(Ingredientes);
        }
        */

        Console.WriteLine(orderWeight("90 192 32 423 12"));

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

    public static int TrailingZeros(int n)
    {
        int Numero = n;
        int Fatorial = 1;
        int Digitos = 0;
        int ZerosDireita = 0;
        int TamanhoDigitos = 0;

        for(int i = 2; i <= Numero; i++)
        {
            Fatorial *= i;
        }

        char[] DigitosFatorial = Fatorial.ToString().ToCharArray();
        TamanhoDigitos = DigitosFatorial.Length;

        for (int i = DigitosFatorial.Length; i > 0; i--)
        {
            if (DigitosFatorial[i - 1] == '0')
            {
                ZerosDireita++;
            }

            else
            {
                i = 0;
            }
        }

        Digitos = Fatorial.ToString().Length;
        Console.WriteLine("Fatorial: " + Fatorial);

        return ZerosDireita;
    }

    public static int HighestRank(int[] arr)
    {
        int[] Numeros = arr;
        int[] Contagem = new int[Numeros.Length];

        foreach(int Numero in Numeros)
        {
            
        }
        
        for(int i = 0; i < Numeros.Length; i++)
        {
            
        }

        
        return Convert.ToInt32(Contagem);
    }

    static string LatestClock(int a, int b, int c, int d)
    {
        int HoraDecimal;
        int Hora;
        int MinutoDecimal;
        int Minuto;
        int[] Numeros = { a, b, c, d };

        foreach(int Numero in Numeros)
        {
            if(Numero <= 2)
            {
                HoraDecimal = Numero;
            }
        }

        string HoraFormatada = string.Format("{0}{1}:{2}{3}", a, b, c, d);
        return HoraFormatada;
    }
    public static bool IsItLetter(char c)
    {
        if(Char.IsLetter(c) == true)
        {
            return true;
        }

        else
        {
            return false;
        }
        
    }

    public static int GetUnique(IEnumerable<int> numbers)
    {
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

        return 0;
    }

    public static string[] Tacofy(string word)
    {
        int Espacobranco = 0;
        char[] Digito = word.ToCharArray();
        string TextoValido = "";
        int IngredienteValido = 0;

        for(int i = 0; i < Digito.Length; i++)
        {
            if (Digito[i] == 'l')
            {
                TextoValido += Digito[i];
            }

            else if (Digito[i] == 't')
            {
                TextoValido += Digito[i];
            }

            else if (Digito[i] == 'c')
            {
                TextoValido += Digito[i];
            }

            else if (Digito[i] == 'g')
            {
                TextoValido += Digito[i];
            }

            else if (Digito[i] == 's')
            {
                TextoValido += Digito[i];
            }

            else if (Digito[i] == 'a' || Digito[i] == 'e' || Digito[i] == 'i' || Digito[i] == 'o' || Digito[i] == 'u')
            {
                TextoValido += Digito[i];
            }
        }

        //sa ----> 0 e 1
        char[] DigitoValido = TextoValido.ToCharArray();

        string[] Pao = new string[Digito.Length + 2];

        Pao[0] = "shell";
        Pao[word.Length + 1] = "shell";

        for (int i = 0; i < Pao.Length; i++)
        {
            if (!string.IsNullOrEmpty(Pao[i]))
            {
                Pao[Espacobranco] = Pao[i];
                Espacobranco++;
            }
        }

        //Array.Resize(ref Pao, Pao.Length - Espacobranco);

        

        Console.WriteLine("Texto corrigido: " + TextoValido);
        Console.WriteLine("Ingredientes válidos: " + IngredienteValido);

        for (int i = 0; i < DigitoValido.Length; i++)
        {
            if (DigitoValido[i] == 'l')
            {
                Pao[i + 1] = "lettuce";
            }

            else if (DigitoValido[i] == 't')
            {
                Pao[i + 1] = "tomato";
            }

            else if (DigitoValido[i] == 'c')
            {
                Pao[i + 1] = "cheese";
            }

            else if (DigitoValido[i] == 'g')
            {
                Pao[i + 1] = "guacamole";
            }

            else if (DigitoValido[i] == 's')
            {
                Pao[i + 1] = "salsa";
            }

            else if (DigitoValido[i] == 'a' || DigitoValido[i] == 'e' || DigitoValido[i] == 'i' || DigitoValido[i] == 'o' || DigitoValido[i] == 'u')
            {
                Pao[i + 1] = "beef";
            }
            
        }

        foreach(string Ingrediente in  Pao)
        {
            Console.WriteLine("Ingrediente: " + Ingrediente);
        }

        foreach(char DigitoValidos in DigitoValido)
        {
            Console.WriteLine(DigitoValidos);
        }
        
        return Pao;
    }

    public static (int,int) OwnedCatAndDog(int Gato, int Cachorro)
    {
        //Idades
        int GatoReal = 0;
        int CachorroReal = 0;

        if(Gato == 15)
        {
            GatoReal = 1;
        }

        if(Gato == 15 + 9)
        {
            GatoReal = 1 + 1;
        }

        if(Gato > 15 + 9)
        {
            GatoReal = (Gato - 24) / 4 + 2;
        }

        if (Cachorro == 15)
        {
            CachorroReal = 1;
        }

        if (Cachorro == 15 + 9)
        {
            CachorroReal = 1 + 1;
        }

        if (Cachorro > 15 + 9)
        {
            GatoReal = (Gato - 24) / 5 + 2;
        }

        return (GatoReal, CachorroReal);
    }

    //Algoritmo de Luhn

    public static string orderWeight(string strng)
    {
        string Texto = strng;
        string[] Pesos = Texto.Split(' ');
        int[] Numeros = new int[Pesos.Length];
        int QuantidadeNumeros = 0;
        int[] SomaDigitos = new int[Numeros.Length];
        
        for(int i = 0; i < Pesos.Length; i++)
        {
            Numeros[i] = Convert.ToInt32(Pesos[i]);
        }

        QuantidadeNumeros = Numeros.Length;

        for(int i = 0; i < QuantidadeNumeros; i++)
        {
            int Numero = 0;
            int Soma = 0;
            Numero = Numeros[i];

            while (Numero != 0)
            {
                Soma += Numero % 10;
                Numero /= 10;
            }

            SomaDigitos[i] = Soma;
        }

        int[] SomaDigitosOrdem = new int[SomaDigitos.Length];

        for(int i = 0; i < SomaDigitos.Length; i++)
        {
            
        }
    
        return QuantidadeNumeros.ToString();
    }


}
