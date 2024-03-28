class Program
{
    static void Main()
    {
        while (true)
        {
            string Texto = "";
            Console.WriteLine("Escreva um texto: ");
            Texto = Console.ReadLine();
            Console.WriteLine(DuplicateEncode(Texto));
        }
    }

    public static string DuplicateEncode(string word)
    {
        string Texto = word;
        char[] Digitos = Texto.ToCharArray();
        string TextoFormatado = "";
        char[] DigitosMaiusculos = new char[Digitos.Length];
       
        for(int i = 0; i < Digitos.Length; i++)
        {
            DigitosMaiusculos[i] = Char.ToUpper(Digitos[i]);
        }

        for (int i = 0; i < Digitos.Length; i++)
        {
            VerificarRepete(DigitosMaiusculos[i]);

            if (VerificarRepete(DigitosMaiusculos[i]) == true)
            {
                TextoFormatado += ")";
            }

            else
            {
                TextoFormatado += "(";
            }
        }

        bool VerificarRepete(char Digito)
        {
            int Contagem = 0;

            foreach(char c in DigitosMaiusculos)
            {
                if(c == Digito)
                {
                    Contagem++;
                }
            }

            return Contagem > 1;
        }

        return TextoFormatado;
    }
}
