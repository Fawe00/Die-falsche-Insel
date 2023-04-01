class Burg
{
    private String _eingabe = null;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Speicherort _speicherort;



    public Burg(Verabreitung verabreitung, Inventar inventar, Speicherort speicherort)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _speicherort = speicherort;
    }
    public String BurgMain()
    {
        Console.WriteLine("Wikommen im Dorf des Handels");
        while (true)
        {
            Console.WriteLine("Sie können hier folgen Sachen machen:");
            Console.WriteLine("9. Reisen Dorf");
            Console.WriteLine("0. Inventar ausgeben lassen");
            if ( _speicherort.KoenigAufgabe == true )
            {
                Console.WriteLine("K. Mit dem König Reden");
            }
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

                    default:
                        Console.WriteLine("Die Angabe stimmt nicht überein.");
                        break;
                }
            }
        }
    }
}
