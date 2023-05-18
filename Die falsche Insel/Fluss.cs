class Fluss
{
    private String _eingabe;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Speicherort _speicherort;
    private readonly Standard _standard;
    private readonly Story _story;

    public Fluss(Verabreitung verabreitung, Inventar inventar, Speicherort speicherort, Standard standard, Story story)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _speicherort = speicherort;
        _standard = standard;
        _story = story;
    }
    public String FlussMain()
    {
        Console.WriteLine("Willkommen auf der Insel des Flusses");
        while (true)
        {
            _standard.StandardInselnWahl();
            Console.WriteLine("1. Beutel mit Wasser füllen");
            Console.WriteLine("2. Lehm stechen");
            Console.WriteLine("3. Sand nehmen");
            Console.WriteLine("8. Reisen zur Insel des Bauerhofes");
            if (_speicherort.Brueckefluss)
            {
                Console.WriteLine("9. Reisen zur Insel der Wiese");
            }
            else
            {
                Console.WriteLine("9. Brücke bauen");
            }
            if (_speicherort.FischerAufgabe)
            {
                Console.WriteLine("F. Fischer");
            }
            _standard.StandardEingabe0Wahl();
            _standard.StandardIhrWahlEingabe();
            _eingabe = Console.ReadLine();
            switch (_eingabe)
            {
                case "1":
                    _verarbeitung.Wasserschoepfen();
                    break;
                case "2":
                    _verarbeitung.LehmStecken();
                    break;
                case "3":
                    _verarbeitung.SandNehmen();
                    break;
                case "8":
                    return "Bauernhof";
                case "9":
                    if (_speicherort.Brueckefluss)
                    {
                        return "Wiese";
                    }
                    else
                    {
                        _verarbeitung.BauenBruecke();
                        break;
                    }
                case "0":
                    _inventar.InventarAusagabe();
                    break;
                case "F":
                    _story.FischerAufgaben();
                    break;
            }
        }
    }
}
