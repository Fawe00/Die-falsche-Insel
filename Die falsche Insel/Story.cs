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
                    Console.WriteLine("Hallo, guten Tag ich bin König Balduin und heisse Sie herzlich Willkommen auf der Burg.");
                    Console.WriteLine("Können Sie bitte mal in den Wald reisen und dort Kräuter sammeln, ich habe etwas falsch gegessen.");
                    _speicherort.KoenigAugabenStuffe = 1;
                    break;
                case 1:
                    Console.WriteLine("Haben Sie die Kräuter gesammelt?");
                    eingabe = Console.ReadLine();
                    if (eingabe != null)
                    {
                        switch (eingabe)
                        {
                            case "Ja":
                                if (_speicherort.Kraut >= 1)
                                {
                                    _speicherort.Kraut = 0;
                                    Console.WriteLine("Danke für die vielen Kräuter, ich braue mir nun daraus einen Tee.");
                                    Console.WriteLine("Sie haben jetzt Freizeit.");
                                    _speicherort.KoenigAufgabe = false;
                                    _speicherort.KoenigAugabenStuffe++;
                                }
                                break;
                            case "Nein":
                                Console.WriteLine(" ok, ich will aber trotzdem dass Sie Kräuter sammeln. Gehen Sie durch das Dorf zum Wald, sammeln Sie und nach einiger Zeit haben Sie genügend Kräuter in ihrem Beutel.");
                                break;
                            default:
                                Console.WriteLine("Sie können bei dieser Aufgaben nur Ja oder Nein schreiben!");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Oh, ich habe gehört das Sie den Bauer angetroffen haben und ihm geholfen haben");
                    Console.WriteLine("Wenn Sie ein Platz zum wohnen brauchen, hinter dem Fluss, auf der Wiese, hat es noch Platz für Häuser.");
                    Console.WriteLine("Natürlich können sie sich auch ein Zimmer im Dorf mieten oder im Wald vor einem Lagerfeuer schlafen.");
                    Console.WriteLine("Geht das sicher für Sie so in Ordnung.");
                    _speicherort.BrauerAufgabe = true;
                    break;
                case 3:

                default:
                    Console.WriteLine("Es ist ein Systemfehler aufgetreten.");
                    Console.WriteLine("Sie können einfach weitermachen.");
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
                    Console.WriteLine("Hallo Fremder, wie kommt es zu dem das Sie hier auf der Insel der Ernte sind?");
                    Console.WriteLine("Egal, wenn Sie schon hier sind, könnt Sie mir helfen?");
                    Console.WriteLine("Könnten Sie mir bitte eine Birne und ein Apfel bringen?");
                    Console.WriteLine("Ich will eine Pause machen und habe keine Früchte");
                    _speicherort.BauerAufgabeStuffe++;
                    break;
                case 1:
                    Console.WriteLine("Oh, Sie sind zurück. Haben Sie die Früchte geplückt?");
                    eingabe = Console.ReadLine();
                    if (eingabe != null)
                    {
                        switch(eingabe)
                        {
                            case "Ja":
                                Console.WriteLine("Zeigen Sie mir die Früchte, bitte.");
                                if(_speicherort.Apfel >= 1 && _speicherort.Birne >= 1)
                                {
                                    Console.WriteLine("Oh wie schön sind diese frischen Früchte.");
                                    _speicherort.Apfel = 0;
                                    _speicherort.Birne = 0;
                                    Console.WriteLine("Danke für die Früchte.");
                                    Console.WriteLine("Sie können jederzeit weiteres Essen für sich ernten, damit Sie wieder mehr Energie haben.");
                                    Console.WriteLine("Essen können Sie bei der Burg im Speisesaal.");
                                    _speicherort.KoenigAufgabe = true;
                                    _speicherort.BauerAufgabe = false;
                                }
                                else
                                {
                                    Console.WriteLine("Es fehlt etwas. Sie haben gar keine oder nur eine Frucht gepflückt.");
                                    Console.WriteLine("Schauen sie nochmals in Ihrem Beutel nach und was fehlt, gehen Sie plücken.");
                                }
                                break;
                            case "Nein":
                                Console.WriteLine("Spazieren Sie zu den Fruchtbäumen und plücken dort Äpfel oder Birnen.");
                                break;
                            default:
                                Console.WriteLine("Sie können bei der Aufgabe nur Ja oder Nein schreiben!");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Es ist ein Systemfehler aufgetreten.");
                    Console.WriteLine("Sie können einfach weitermachen.");
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
                    Console.WriteLine("Hallo Fremder, wollt Ihr ein kleinens Getränk für unterwegs haben?");
                    eingabe = Console.ReadLine();
                    if (eingabe != null)
                    {
                        bool ft = _verabreitung.JaNeinGross(eingabe);
                        if (ft)
                        {
                            Console.WriteLine("Gut, hier bitte sehr.");
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
                    Console.WriteLine("Der gerstige Geschmack macht es einzigartig.");
                    Console.WriteLine("Ich würde gern mehr davon herstellen, doch ich habe hier fast keinen Platz für ein Brauerei zu bauen.");
                    Console.WriteLine("Haben Sie ein Ort, wo sie für mich bauen könnten?");
                    eingabe = Console.ReadLine();
                    if (eingabe != null) 
                    {
                        bool ft = _verabreitung.JaNeinGross(eingabe);
                        if (ft)
                        {
                            Console.WriteLine("Okay sie brauchen folgende Sachen für diese Aufgabe");
                            Console.WriteLine("Stein: 20");
                            Console.WriteLine("Baumstämme: 14");
                            Console.WriteLine("Ziegel: 25");
                            
                        }else { Console.WriteLine("Wie schade gut bitte der Nächste."); }
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Der Brauer hat keine Aufgabe für Sie.");
        }
    }
    public void SchmiedAufgabe()
    {
        if (_speicherort.SchmiedAufgabe)
        {
            switch (_speicherort.SchmiedAufgabeStuffe)
            {
                case 0:
                    Console.WriteLine("Hallo Fremder ich würde mich gerne vorstellen.");
                    Console.WriteLine("Ich bin Ramon, der Schmied und mach mein Handwerk mit Leidenschaft und Stolz.");
                    Console.WriteLine("Hier ein Geschenk für Sie. Es ist eine neue Axt, mit der Sie besser Holz hacken können.");
                    _speicherort.Axt = true;
                    _speicherort.SchmiedAufgabe = false;
                    break;
                case 1:
                    Console.WriteLine("Oh Sie haben ein Schreiben vom Ziegler.");
                    Console.WriteLine("Natürlich kann ich Ihnen ein Säge geben.");
                    Console.WriteLine("Hier ist die Säge, bitte sehr");
                    Console.WriteLine("Leider geht jetzt mir das Eisenerz aus können Sie bitte zum Minenarbeiter gehen und bei ihm neues Kaufen.");
                    Console.WriteLine("Ich zahle ihnen das Geld auch wieder zurück");
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
                    Console.WriteLine("Hallo, Sie sehen aus als könnte Sie mir helfen. Ich brenne Ziegel aller Arten, aber dafür ist mir das Holz leider ausgegangen.");
                    Console.WriteLine("Könnten Sie mir Baumstämme bringen, dann zeige ich Ihnen wie das geht.");
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
                            Console.WriteLine("Okay das ist aber ein bisschen ein sehr langes Holzstück. Hast du ein Säge um es in Stücke zu sägen?");
                            eingabe = Console.ReadLine();
                            if (_verabreitung.JaNeinGross(eingabe))
                            {
                                Console.WriteLine("Okay dann komm mich später nochmals besuchen");
                                if (_speicherort.Sage)
                                {
                                    _speicherort.ZieglerAufgabeStuffe++;
                                }
                                else
                                {
                                    Console.WriteLine("ErrorErlichkeit: Sie haben keine Säge im Beutel.");
                                }
                                break;
                            }else
                            {
                                Console.WriteLine("Okay ich gebe Ihnen ein Schreiben, damit du beim Schmied eine Säge bekommst.");
                                _speicherort.SchmiedAufgabe = true;
                                _speicherort.SchmiedAufgabeStuffe = 2;
                                _speicherort.ZieglerAufgabeStuffe++;
                                break;
                            }
                        }
                    }
                    break;
                case 2:
                    if (_speicherort.Sage)
                    {
                        Console.WriteLine("Oh du hast die Säge wunderbar.");
                        Console.WriteLine("Dann säge bitte den Baumstamm in vier Stücke.");
                        _verabreitung.HolzSagen();
                        if(7 == _speicherort.Holzstuck)
                        {
                            Console.WriteLine("Okay und jetzt noch acht Scheite draus hacken.");
                            _verabreitung.HolzSpalten();    
                        }
                        if(8 == _speicherort.Holzscheite)
                        {
                            Console.WriteLine("Ah danke, jetzt kannst du bei mir immer mit zwei Lehm und fünf Holzscheite.");
                            Console.WriteLine("Ziegel brennen.");
                            _speicherort.ZieglerAufgabe = false;
                            _speicherort.ZiegelHerstellen = true;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sie haben noch nicht die Säge, gehe ein beim Schmied holen.");
                        break;
                    }
            }
        }
        else
        {
            Console.WriteLine("Der Ziegler hat keine Aufgabe für Dich.");
        }
    }
    public void MinenabrbeiterAufgabe()
    {
        if(_speicherort.MinenarbeiterAufgabe)
        {
            switch(_speicherort.MinenarbeiterAufgabeStuffe)
            {
                case 0:
                    Console.WriteLine("Hallo Fremder ich bin ein Minenarbeiter ohne Mine");
                    Console.WriteLine("Können Sie bitte eine neue suchen die letzte hatte ich beim Fluss finde Sie aber dort nicht mehr.");
                    _speicherort.MinenarbeiterAufgabeStuffe++;
                    _speicherort.MinenarbeiterAufgabe = false;
                    break;
                case 1:
                    Console.WriteLine("Oh Sie haben neuigkeiten über die Mine haben Sie gefunden.");
                    eingabe = Console.ReadLine();
                    bool ft =  _verabreitung.JaNeinGross(eingabe);
                    if (ft)
                    {
                        Console.WriteLine("Okay dann geht ich mal zum Fische und versuche mit Ihm etwas zu bauen.");
                        _speicherort.MinenarbeiterAufgabeStuffe++;
                        _speicherort.MinenarbeiterAufgabe = false;
                    }
                    else
                    {
                        Console.WriteLine("Schade vielleicht das nächste mal.");
                    }
                    break;
                case 2:

                    break;

            }
        }
    }
    public void FischerAufgaben()
    {
        if(_speicherort.FischerAufgabe)
        {
            switch (_speicherort.FischerAufgabeStuffe)
            {
                case 0:
                    Console.WriteLine("Hallo Sie, könnten Sie mir helfen ein Fisch will nicht an die Angel.");
                    Console.WriteLine("Hier halten Sie mal.");
                    _speicherort.Angel = true;
                    Console.WriteLine("Sie haben jetz die Angel des Fischers");
                    _verabreitung.Fischen();
                    if(_speicherort.Fisch >= 1)
                    {
                        Console.WriteLine("Oh Sie haben es geschaft toll.");
                        _speicherort.Angel = false;
                        Console.WriteLine("Danke ich probier es selber nochmals.");
                        _speicherort.FischerAufgabeStuffe++;
                    }
                    break;
                case 1:
                    Console.WriteLine("Oh Sie sind wieder da.");
                    Console.WriteLine("Fragen:");
                    Console.WriteLine("1. Kennen Sie hier irgenwo eine Mine?");
                    Console.WriteLine("0. Gehen");
                    eingabe = Console.ReadLine();
                    switch (eingabe)
                    {
                        case "1":
                            Console.WriteLine("Ja sicher hier hinter den Wasserfall.");
                            Console.WriteLine("Sie können leider solang das Wassser dort ruterkommt nicht rein aber sie können das Wassser umleiten.");
                            _speicherort.FischerAufgabe = false;
                            _speicherort.MinenarbeiterAufgabe = true;
                            break;
                    }
                    break;
                case 2:

                    break;
            }
        }
    }
}
