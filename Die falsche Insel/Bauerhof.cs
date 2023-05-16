class Bauerhof
{
    private String _eingabe = null;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Speicherort _speicherort;
    private readonly Story _story;
    private readonly Standard _standart;

    public Bauerhof(Verabreitung verarbeitung, Inventar inventar, Speicherort speicherort, Story story, Standard standard)
    {
        _verarbeitung = verarbeitung;
        _inventar = inventar;
        _speicherort = speicherort;
        _story = story;
        _standart = standard;
    }
    public string BauerhofMain()
    {
        Console.WriteLine("Willkommen auf dem Bauerhof der Ernte");
        while (true)
        {
            _standart.StardartInselnWahl();
            Console.WriteLine("1. Feldfrüchte ernten");
            Console.WriteLine("2. Obst ernten");
            Console.WriteLine("8. Reisen zum Fluss");
            Console.WriteLine("9. Reisen ins Dorf");
            _standart.StandartEingabe0Wahl();
            if (_speicherort.BauerAufgabe == true)
            {
                Console.WriteLine("B. Mit dem Bauer sprechen");
            }
            _standart.StardartIhrWahlEingabe();
            _eingabe = Console.ReadLine();
            if (_eingabe != null)
            {
                switch (_eingabe)
                {
                    case "1":
                        Console.WriteLine("Felder");
                        Console.WriteLine("1. Kartoffeln");
                        Console.WriteLine("2. Karotten");
                        _eingabe = Console.ReadLine();
                        if (_eingabe != null)
                        {
                            switch (_eingabe)
                            {
                                case "1":
                                    _verarbeitung.KartoffelnErnten();
                                    break;
                                case "2":
                                    _verarbeitung.KarottenErnten();
                                    break;
                                default:
                                    _standart.StandartFalscheEingabe();
                                    break;
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Obstbäume");
                        Console.WriteLine("1. Apfelbaum");
                        Console.WriteLine("2. Birnenbaum");
                        _eingabe = Console.ReadLine();
                        if (_eingabe != null)
                        {
                            switch (_eingabe)
                            {
                                case "1":
                                    _verarbeitung.ApfelPlucken();
                                    break;
                                case "2":
                                    _verarbeitung.BirnePlucken();
                                    break;
                                default:
                                    _standart.StandartFalscheEingabe();
                                    break;
                            }
                        }
                        break;
                    case "8":
                        return "Fluss";
                    case "9":
                        return "Dorf";
                    case "0":
                        _inventar.InventarAusagabe();
                        break;
                    case "B":
                        _story.BauerAufgabe();
                        break;
                    default:
                        _standart.StandartFalscheEingabe();
                        break;
                }
            }
        }
    }
}
