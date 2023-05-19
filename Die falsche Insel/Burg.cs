class Burg
{
    private String _eingabe;
    private readonly Verarbeitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Speicherort _speicherort;
    private readonly Story _story;
    private readonly Essen _essen;
    private readonly Standard _standard;



    public Burg(Verarbeitung verabreitung, Inventar inventar, Speicherort speicherort, Story story, Essen essen, Standard standard)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _speicherort = speicherort;
        _story = story;
        _essen = essen;
        _standard = standard;
    }
    public String BurgMain()
    {
        Console.WriteLine("Willkommen im Dorf des Handels");
        while (true)
        {
            _standard.StandardInselnWahl();
            Console.WriteLine("1. Essen im Speisesaal");
            Console.WriteLine("9. Reise auf die Insel des Dorfes");
            _standard.StandardEingabe0Wahl();
            if ( _speicherort.KoenigAufgabe == true )
            {
                Console.WriteLine("K. Mit dem König sprechen");
            }
            _standard.StandardIhrWahlEingabe();
            _eingabe = Console.ReadLine();
            if (_eingabe != null)
            {
                switch (_eingabe)
                {
                    case "9":
                        return "Dorf";
                    case "0":
                        _inventar.InventarAusagabe();
                        break;
                    case "K":
                        _story.KönigAufgaben();
                        break;
                    case "1":
                        _essen.Saal();
                        break;
                    default:
                        _standard.StandardFalscheEingabe();
                        break;
                }
            }
        }
    }
}
