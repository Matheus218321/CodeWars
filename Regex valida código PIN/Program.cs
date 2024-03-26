class Program
{
   static void Main()
    {

    }

    public static bool ValidatePin(string pin)
    {
        char[] Digitos =  pin.ToCharArray();

        if(Digitos.Length == 4 || Digitos.Length == 6)
        {
            foreach(char Digito in Digitos)
            {
                if(Char.IsDigit(Digito) == false)
                {
                    return false;
                }
            }
        }

        else
        {
            return false;
        }

        return true;
    }
}
