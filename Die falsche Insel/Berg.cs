class Berg
{
    private String _eingabe = null;
    private readonly Verarbeitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Standard _standard;



    public Berg(Verarbeitung verabreitung, Inventar inventar, Standard standard)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _standard = standard;
    }
    public String BergMain()
    {
        Console.WriteLine("Willkommen auf dem Berg");
        while (true)
        {
            _standard.StandardInselnWahl();
            Console.WriteLine("1. Stein abbauen");
            Console.WriteLine("9. Reise zur Insel des Waldes");
            _standard.StandardEingabe0Wahl();
            _standard.StandardIhrWahlEingabe();
            _eingabe = Console.ReadLine();
            if (_eingabe != null)
            {
                switch (_eingabe)
                {
                    case "1":
                        _verarbeitung.SteinAbBauen();
                        break;
                    case "9":
                        return "Wald";
                    case "0":
                        _inventar.InventarAusagabe();
                        break;
                    default:
                        _standard.StandardFalscheEingabe();
                        break;
                }
            }
        }
    }
}
