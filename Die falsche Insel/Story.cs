﻿class Story
{
    private readonly Speicherort _speicherort;
    private String eingabe;

    public Story(Speicherort speicherort)
    {
        _speicherort = speicherort;
    }
    public void KönigAufgaben()
    {
        if (_speicherort.KoenigAufgabe == true)
        {
            switch (_speicherort.KoenigAugabenStuffe)
            {
                case 0:
                    Console.WriteLine("Hallo Guten Tag ich bin König Balduin und heisse Sie Herzlich Willkommen auf der Burg.");
                    Console.WriteLine("Können Sie bitte mal in den Wald Reisen und dort Kräuter hollen ich habe ihrgend wie etwas fasch gegessen.");
                    _speicherort.KoenigAugabenStuffe = 1;
                    break;
                case 1:
                    Console.WriteLine("Haben Sie die Kräuter?");
                    eingabe = Console.ReadLine();
                    if (eingabe != null)
                    {
                        switch (eingabe)
                        {
                            case "Ja":
                                if (_speicherort.Kraut >= 1)
                                {
                                    _speicherort.Kraut = 0;
                                    Console.WriteLine("Danke für die Kräuter gegal wie viele es waren ich mache mir mal ein Tee, Sie können soweit machen was sie wollen");
                                    _speicherort.KoenigAufgabe = false;
                                    _speicherort.KoenigAugabenStuffe++;
                                }
                                break;
                            case "Nein":
                                Console.WriteLine("Dann hollen Sie es bitte. Gehen sie über das Dorf in den Wald sammel nach einiger Zeit haben sie Kräuter in ihrem Inventar.");
                                break;
                            default:
                                Console.WriteLine("Sie können bei Aufgaben nur Ja oder Nein schreiben");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("")
            }
        }
        else
        {
            Console.WriteLine("Der König hat keine Aufgabe für Sie.");
        }
    }
}
