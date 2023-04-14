class Story
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
                                    Console.WriteLine("Danke für die Kräuter egal wie viele es waren, ich mache mir mal ein Tee, Sie können jetzt machen was sie wollen.");
                                    _speicherort.KoenigAufgabe = false;
                                    _speicherort.KoenigAugabenStuffe++;
                                }
                                break;
                            case "Nein":
                                Console.WriteLine("Dann hollen Sie es bitte. Gehen sie über das Dorf in den Wald sammel nach einiger Zeit haben sie Kräuter in ihrem Bäutel.");
                                break;
                            default:
                                Console.WriteLine("Sie können bei Aufgaben nur Ja oder Nein schreiben!");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Es ist ein Systemfehler aufgetreten.");
                    Console.WriteLine("Sie können einfach weitermachen");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Der König hat keine Aufgabe für Sie.");
        }
    }
    public void BauerAufgabe()
    {
        if (_speicherort.BauerAufgabe)
        {
            switch(_speicherort.BauerAufgabeStuffe)
            {
                case 0:
                    Console.WriteLine("Hallo Fremder wie kommt es zu den das Sie hier auf der insel der Ernte?");
                    Console.WriteLine("Egal wie sie schon hier seit könnt ihr mir ein gefallen helfen?");
                    Console.WriteLine("Könnte ihr mir bitte 1 Birne und 1 Apfel bringen?");
                    Console.WriteLine("Ich will eine Pause machen und habe keine Früchte");
                    _speicherort.BauerAufgabeStuffe++;
                    break;
                case 1:
                    Console.WriteLine("Oh sie sind zurück haben sie die Früchte?");
                    eingabe = Console.ReadLine();
                    if (eingabe != null)
                    {
                        switch(eingabe)
                        {
                            case "Ja":
                                Console.WriteLine("Zeigen sie mal her");
                                if(_speicherort.Apfel >= 1 && _speicherort.Birne >= 1)
                                {
                                    Console.WriteLine("Oh wie schön wiklich sehr frisch.");
                                    _speicherort.Apfel = 0;
                                    _speicherort.Birne = 0;
                                    Console.WriteLine("Danke für die Früchte.");
                                    Console.WriteLine("Sie können jederzeit weiters Essen auch für Sie ernten das sie wieder mehr Energie haben.");
                                    Console.WriteLine("Essen können Sie bei der Burg im Speisesall.");
                                    _speicherort.KoenigAufgabe = true;
                                }
                                else
                                {
                                    Console.WriteLine("Sie haben garkeit oder nur eine Frucht gepückt schauen sie nochmals in ihren Bäute nach was sie nicht haben und gehen sie das Ernten.");
                                }
                                break;
                            case "Nein":
                                Console.WriteLine("Sie können zust zu den Fruchtbäumen und dann dort Äpfel oder Birnen plücken.");
                                break;
                            default:
                                Console.WriteLine("Sie können bei Aufgaben nur Ja oder Nein schreiben!");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Es ist ein Systemfehler aufgetreten.");
                    Console.WriteLine("Sie können einfach weitermachen");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Der Bauer hat keine Aufgabe für Sie.");
        }
    }
}
