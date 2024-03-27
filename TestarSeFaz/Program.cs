class Program
{
    static void Main()
    {
        while (true)
        {
            int Segundos = 0;
            Console.WriteLine("Digite os segundos: ");
            Segundos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Horário: " + GetReadableTime(Segundos));
        }
        
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
}
