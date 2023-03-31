class Berg
{
    private String _eingabe = null;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;



    public Berg(Verabreitung verabreitung, Inventar inventar)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
    }
    public String BurgMain()
    {
        Console.WriteLine("Wikommen auf dem Berg");
        while (true)
        {
            Console.WriteLine("Sie können hier folgen Sachen machen:");
            Console.WriteLine("1. Stein abbauen");
            Console.WriteLine("9. Reisen Wald");
            Console.WriteLine("0. Inventar ausgeben lassen");
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
                        Console.WriteLine("Die Angabe stimmt nicht überein.");
                        break;
                }
            }
        }
    }
}
