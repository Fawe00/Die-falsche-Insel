class Dorf
{
    private String _eingabe;
    private readonly Verarbeitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Standard _standard;
    private readonly Speicherort _speicherort;
    private readonly Story _story;



    public Dorf(Verarbeitung verabreitung, Inventar inventar, Standard standard, Speicherort speicherort, Story story)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _standard = standard;
        _speicherort = speicherort;
        _story = story;
    }
    public String DorfMain()
    {
        Console.WriteLine("Willkommen im Dorf des Handels");
        while (true)
        {
            _standard.StandardInselnWahl();
            if (_speicherort.ZiegelHerstellen)
            {
                Console.WriteLine("1. Ziegel herstellen");
            }
            Console.WriteLine("7. Reise auf die Insel des Waldes");
            Console.WriteLine("8. Reise auf die Insel der Burg");
            Console.WriteLine("9. Reise auf die Insel des Bauernhofes");
            _standard.StandardEingabe0Wahl();
            if (_speicherort.BrauerAufgabe == true)
            {
                Console.WriteLine("B. Brauer");
            }
            if (_speicherort.SchmiedAufgabe == true)
            {
                Console.WriteLine("S. Schmied");
            }
            _standard.StandardIhrWahlEingabe();
            _eingabe = Console.ReadLine();
            if ( _eingabe != null )
            {
                switch ( _eingabe )
                {
                    case "7":
                        return "Wald";
                    case "8":
                        return "Burg";
                    case "9":
                        return "Bauernhof";
                    case "0":
                        _inventar.InventarAusagabe();
                        break;
                    case "B":
                        _story.BrauerAufgaben();
                        break;
                    case "S":
                        _story.SchmiedAufgabe();
                        break;
                    case "1":
                        if (_speicherort.ZiegelHerstellen)
                        {
                            _verarbeitung.ZiegelHerstellen();
                            break;
                        }
                        break;
                    default:
                        _standard.StandardFalscheEingabe();
                        break;
                }
            }
        }
    }
}