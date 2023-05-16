class Berg
{
    private String _eingabe = null;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Standard _standard;



    public Berg(Verabreitung verabreitung, Inventar inventar, Standard standard)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _standard = standard;
    }
    public String BergMain()
    {
        Console.WriteLine("Wikommen auf dem Berg");
        while (true)
        {
            _standard.StardartInselnWahl();
            Console.WriteLine("1. Stein abbauen");
            Console.WriteLine("9. Reisen Wald");
            _standard.StandartEingabe0Wahl();
            _standard.StardartIhrWahlEingabe();
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
                        _standard.StandartFalscheEingabe();
                        break;
                }
            }
        }
    }
}
