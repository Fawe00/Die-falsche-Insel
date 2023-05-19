class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Das Programm wird gestartet");
        Standard standard = new Standard();
        Speicherort speicherort = new Speicherort(1000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        Inventar inventar = new Inventar(speicherort);
        Verarbeitung verarbeitung = new Verarbeitung(speicherort, standard);
        Story story = new Story(speicherort, verarbeitung);
        Essen essen = new Essen(speicherort, standard);
        Wald wald = new Wald(verarbeitung, inventar, standard);
        Dorf dorf = new Dorf(verarbeitung, inventar, standard, speicherort, story);
        Burg burg = new Burg(verarbeitung, inventar, speicherort, story, essen, standard);
        Berg berg = new Berg(verarbeitung, inventar, standard);
        Wiese wiese = new Wiese(verarbeitung, inventar, speicherort);
        Bauerhof bauerhof = new Bauerhof(verarbeitung, inventar, speicherort, story, standard);
        Fluss fluss = new Fluss(verarbeitung, inventar, speicherort, standard, story);
        Programm programm = new Programm(wald, dorf, burg, berg, bauerhof, fluss);
        programm.Runde();

    }
}