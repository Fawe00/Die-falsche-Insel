﻿class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Das Program wird gestartet");
        Speicherort speicherort = new Speicherort(1000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        Inventar inventar = new Inventar(speicherort);
        Verabreitung verabreitung = new Verabreitung(speicherort);
        Story story = new Story(speicherort);
        Essen essen = new Essen(speicherort);
        Wald wald = new Wald(verabreitung, inventar);
        Dorf dorf = new Dorf(verabreitung, inventar);
        Burg burg = new Burg(verabreitung, inventar, speicherort, story, essen);
        Berg berg = new Berg(verabreitung, inventar);
        Bauerhof bauerhof = new Bauerhof(verabreitung, inventar, speicherort, story);
        Fluss fluss = new Fluss(verabreitung, inventar, speicherort);
        Programm programm = new Programm(wald, dorf, burg, berg, bauerhof, fluss);
        programm.Runde();

    }
}