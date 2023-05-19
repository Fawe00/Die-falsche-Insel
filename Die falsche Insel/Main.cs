class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Das Programm wird gestartet");
        Standard standard = new Standard();
        Speicherort speicherort = new Speicherort(1000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        Inventar inventar = new Inventar(speicherort);
        Verabreitung verabreitung = new Verabreitung(speicherort, standard);
        Story story = new Story(speicherort, verabreitung);
        Essen essen = new Essen(speicherort, standard);
        Wald wald = new Wald(verabreitung, inventar, standard);
        Dorf dorf = new Dorf(verabreitung, inventar, standard, speicherort, story);
        Burg burg = new Burg(verabreitung, inventar, speicherort, story, essen, standard);
        Berg berg = new Berg(verabreitung, inventar, standard);
        Bauerhof bauerhof = new Bauerhof(verabreitung, inventar, speicherort, story, standard);
        Fluss fluss = new Fluss(verabreitung, inventar, speicherort, standard, story);
        Programm programm = new Programm(wald, dorf, burg, berg, bauerhof, fluss);
        programm.Runde();

    }
}