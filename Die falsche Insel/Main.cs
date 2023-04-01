class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Das Program wird gestartet");
        Speicherort speicherort = new Speicherort(1000, 0, 0, 0, 0, 0);
        Inventar inventar = new Inventar(speicherort);
        Verabreitung verabreitung = new Verabreitung(speicherort);
        Story story = new Story(speicherort);
        Wald wald = new Wald(verabreitung, inventar);
        Dorf dorf = new Dorf(verabreitung, inventar);
        Burg burg = new Burg(verabreitung, inventar, speicherort);
        Programm programm = new Programm(wald, dorf, burg);
        programm.Runde();

    }
}