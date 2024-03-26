using System.Collections.Frozen;

class Program
{
    static void Main()
    {

    }

    public static string CreatePhoneNumber(int[] numbers)
    {
        string NumeroTelefone = "";
        char[] Caracteres = new char[numbers.Length];

        for(int i = 0; i < numbers.Length; i++)
        {
            Caracteres[i] = Convert.ToChar(numbers[i] + '0');
        }

        NumeroTelefone = string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", Caracteres[0], Caracteres[1], Caracteres[2], Caracteres[3], Caracteres[4], Caracteres[5], Caracteres[6], Caracteres[7], Caracteres[8], Caracteres[9]);
        return NumeroTelefone;
    }
}
