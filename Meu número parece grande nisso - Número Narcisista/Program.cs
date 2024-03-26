using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        SqlConnection con = new SqlConnection(@"Data Source=[];Initial Catalog=TestePrograma;Integrated Security=True;Encrypt=False");
        string Query = "INSERT INTO Narcissista (Numero, Resultado, Narcissista) VALUES (@Numero, @Resultado, @Narcissista)";
        Console.WriteLine("----------------------------------------------Calculadora de números narcissistas---------------------------------------");
        Console.WriteLine();

        while (true)
        {
            try
            {
                con.Open();
                bool ENarcissista = false;
                int Numero = 0;
                Console.Write("Digite um número inteiro: ");
                Numero = Convert.ToInt32(Console.ReadLine());

                ENarcissista = Narci(Numero);

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@Numero", Numero);
                    cmd.Parameters.AddWithValue("@Resultado", CalcularNarci(Numero));
                    
                    if (ENarcissista == true)
                    {
                        cmd.Parameters.AddWithValue("@Narcissista", "Sim");
                    }

                    if(ENarcissista == false)
                    {
                        cmd.Parameters.AddWithValue("@Narcissista", "Não");
                    }

                    cmd.ExecuteNonQuery();
                }

                if (Narci(Numero) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Esse número é narcissista!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Esse número não é narcissista!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

            catch(Exception e)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

            con.Close();
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
            Digito = Convert.ToInt32(NumeroString[i].ToString());
            Soma = Soma + (int)Math.Pow(Digito, Digitos);
        }
        
        Console.WriteLine();
        Console.WriteLine("Resultado: " + Soma);

        if (Soma == value)
        {
            return true;
        }

        return false;

    }

    static int CalcularNarci(int Value)
    {
        string NumeroString = Value.ToString();
        int Digitos = 0;
        int Digito = 0;
        Digitos = NumeroString.Length;
        int Soma = 0;

        for (int i = 0; i < Digitos; i++)
        {
            Digito = Convert.ToInt32(NumeroString[i].ToString());
            Soma = Soma + (int)Math.Pow(Digito, Digitos);
        }

        return Soma;
    }
}
