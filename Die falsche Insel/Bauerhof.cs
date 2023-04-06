class Bauerhof
{
    private String _eingabe = null;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Speicherort _speicherort;
    private readonly Story _story;

    public Bauerhof(string eingabe, Verabreitung verarbeitung, Inventar inventar, Speicherort speicherort, Story story)
    {
        _eingabe = eingabe;
        _verarbeitung = verarbeitung;
        _inventar = inventar;
        _speicherort = speicherort;
        _story = story;
    }
    public string BauerhofMain()
    {
        Console.WriteLine("Willkommen auf dem Bauerhof der Ernte");
        while (true)
        {
            Console.WriteLine("Sie können hier folgen Sachen machen:");
            Console.WriteLine("1. Feldfrüchte ernten");
            Console.WriteLine("2. Baufrüchte ernten");
            Console.WriteLine("9. Reisen in das Dorf");
            Console.WriteLine("0. Inventar ausgeben lassen");
            Console.WriteLine("Geben Sie die Nummer/Buchstabe ein die Sie wählen wollen");
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
                                    Console.WriteLine("Flasche eingabe.");
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
                                    Console.WriteLine("Dies Obstbaum nummer gibt es nicht");
                                    break;
                            }
                        }
                        break;
                    case "3":
                        return "Dorf";
                    case "0":
                        _inventar.InventarAusagabe();
                        break;
                    default:
                        Console.WriteLine("Die Eingabe ist nicht korekt.");
                        break;
                }
            }
        }
    }
}