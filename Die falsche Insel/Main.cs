class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Das Program wird gestartet");
        Speicherort speicherort = new Speicherort(100, 0, 0, 0, 0);
        Inventar inventar = new Inventar(speicherort);
        Verabreitung verabreitung = new Verabreitung(speicherort);
        Wald wald = new Wald(verabreitung, inventar);
        Programm programm = new Programm(wald);
        programm.Runde();

    }
}