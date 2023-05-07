class Story
{
    private readonly Speicherort _speicherort;
    private readonly Verabreitung _verabreitung;
    private String eingabe;

    public Story(Speicherort speicherort, Verabreitung verabreitung)
    {
        _speicherort = speicherort;
        _verabreitung = verabreitung;
    }
    public void KönigAufgaben()
    {
        if (_speicherort.KoenigAufgabe == true)
        {
            switch (_speicherort.KoenigAugabenStuffe)
            {
                case 0:
                    Console.WriteLine("Hallo Guten Tag ich bin König Balduin und heisse Sie Herzlich Willkommen auf der Burg.");
                    Console.WriteLine("Können Sie bitte mal in den Wald reisen und dort Kräuter hollen ich habe ihrgend wie etwas falsch gegessen.");
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
                                Console.WriteLine("Dann hollen Sie es bitte. Gehen Sie über das Dorf in den Wald sammeln Sie, nach einiger Zeit haben Sie Kräuter in ihrem Beutel.");
                                break;
                            default:
                                Console.WriteLine("Sie können bei Aufgaben nur Ja oder Nein schreiben!");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Oh ich habe gehört das Sie den Bauer angetroffen haben und im geholfen haben");
                    Console.WriteLine("Wenn Sie ein Platz zum Wohen brachen hinter den Fluss auf der Wiese hat es noch Platz für ein Haus");
                    Console.WriteLine("Natürlich können sie sich auch ein Zimmer im Dorf mieten oder im Wald vor einen Lagerfuer schlafen");
                    Console.WriteLine("Geht das  sicher für Sie so in Ortnung.");
                    _speicherort.BrauerAufgabe = true;
                    break;
                case 3:

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
                    Console.WriteLine("Hallo Fremder wie kommt es zu dem das Sie hier auf der Insel der Ernte?");
                    Console.WriteLine("Egal wie Sie schon hier seit könnt ihr mir ein gefallen helfen?");
                    Console.WriteLine("Könnten Sie mir bitte 1 Birne und 1 Apfel bringen?");
                    Console.WriteLine("Ich will eine Pause machen und habe keine Früchte");
                    _speicherort.BauerAufgabeStuffe++;
                    break;
                case 1:
                    Console.WriteLine("Oh Sie sind zurück haben sie die Früchte?");
                    eingabe = Console.ReadLine();
                    if (eingabe != null)
                    {
                        switch(eingabe)
                        {
                            case "Ja":
                                Console.WriteLine("Zeigen Sie mal her");
                                if(_speicherort.Apfel >= 1 && _speicherort.Birne >= 1)
                                {
                                    Console.WriteLine("Oh wie schön wirklich sehr frisch.");
                                    _speicherort.Apfel = 0;
                                    _speicherort.Birne = 0;
                                    Console.WriteLine("Danke für die Früchte.");
                                    Console.WriteLine("Sie können jederzeit weiters Essen auch für Sie ernten das sie wieder mehr Energie haben.");
                                    Console.WriteLine("Essen können Sie bei der Burg im Speisesall.");
                                    _speicherort.KoenigAufgabe = true;
                                }
                                else
                                {
                                    Console.WriteLine("Sie haben garkeit oder nur eine Frucht gepückt schauen sie nochmals in ihren Beute nach was sie nicht haben und gehen sie das Ernten.");
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
    public void BrauerAufgaben()
    {
        if(_speicherort.BrauerAufgabe)
        {
            switch (_speicherort.BrauerAufgabeStuffe)
            {
                case 0:
                    Console.WriteLine("Hallo Fremder wollt ihr ein kleinens Getränk für unterwegs haben?");
                    eingabe = Console.ReadLine();
                    if (eingabe != null)
                    {
                        bool ft = _verabreitung.JaNeinGross(eingabe);
                        if (ft)
                        {
                            Console.WriteLine("Gut hier bitte sehr.");
                            _speicherort.Bier = 1;
                            _speicherort.BrauerAufgabeStuffe++;

                        } else
                        {
                            Console.WriteLine("Okay dann kommen Sie später nochmals.");
                        }
                    }    
                    break;
                case 1:
                    Console.WriteLine("Und wie war es?");
                    Console.WriteLine("Der gertige geschmakt macht es fast einzigartig.");
                    Console.WriteLine("Ich würde dies gern mehr herstellen doch ich habe hier fast kein platz zu bauen.");
                    Console.WriteLine("Haben Sie ein ort wo sie das machen könnten für mich?");
                    eingabe = Console.ReadLine();
                    if (eingabe != null) 
                    {
                        bool ft = _verabreitung.JaNeinGross(eingabe);
                        if (ft)
                        {
                            Console.WriteLine("Okay sie brache folgen Sachen für diese Aufgabe");
                            Console.WriteLine("Stein: 20");
                            Console.WriteLine("Baumstämme: 14");
                            Console.WriteLine("Ziegel: 25");
                            
                        }else { Console.WriteLine("Wie schade gut bitte der nächste"); }
                    }
                    break;
            }
        }
    }
    public void SchmiedAufgabe()
    {
        if (_speicherort.SchmiedAufgabe)
        {
            switch (_speicherort.SchmiedAufgabeStuffe)
            {
                case 0:
                    Console.WriteLine("Hallo Fremder ich würde mich auch gerne mal vorstellen.");
                    Console.WriteLine("Ich bin Ramon der Schmied und mach mein Handwerk mit Leidenschat und Stolz.");
                    Console.WriteLine("Hier ein Geschenk eine neue Axt das sie besser Holz hacken können.");
                    _speicherort.Axt = true;
                    _speicherort.SchmiedAufgabe = false;
                    break;
                case 1:
                    Console.WriteLine("Oh Sie haben ein schreiben von Ziegler.");
                    Console.WriteLine("Natürlich kann ich ihnen ein Säge geben.");
                    Console.WriteLine("Hier ist sie bitte sehr");
                    _speicherort.Sage = true;
                    _speicherort.SchmiedAufgabe = false;
                    break;

            }
        }
    }
    public void ZieglerAufgabe()
    {
        if(_speicherort.ZieglerAufgabe)
        {
            switch (_speicherort.ZieglerAufgabeStuffe)
            {
                case 0:
                    Console.WriteLine("Hallo du siehst ja aus als könnte du mir helfen ich mache für meine Ziegel aller Art doch leider ist mir das Holz ausgegangen.");
                    Console.WriteLine("Könntest du mir mal was bringen dann zeige ich dir wie das geht.");
                    _speicherort.ZieglerAufgabeStuffe = 1;
                    break;
                case 1:
                    Console.WriteLine("Haben sie das Holz?");
                    eingabe = Console.ReadLine();
                    bool ft = _verabreitung.JaNeinGross(eingabe);
                    if (ft)
                    {
                        if(_speicherort.Baumstamm >= 1)
                        {
                            Console.WriteLine("Okay das ist aber ein bisschen sehr langes Holzstücke hast du eine Säge zum das kleiner zu machen?");
                            eingabe = Console.ReadLine();
                            if (_verabreitung.JaNeinGross(eingabe))
                            {
                                Console.WriteLine("Okay dann komm mich nochmals später besuchen");
                                //Weitemachen
                                break;
                            }else
                            {
                                Console.WriteLine("Okay ich gebe dir ein Schreiben mir das du bei Schmied eine Säge bekommst.");
                                break;
                            }
                        }
                    }
                    break;
            }
        }
    }
}
