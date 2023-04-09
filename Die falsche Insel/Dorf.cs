class Dorf
{
    private String _eingabe = null;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;



    public Dorf(Verabreitung verabreitung, Inventar inventar)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
    }
    public String DorfMain()
    {
        Console.WriteLine("Wikommen im Dorf des Handels");
        while (true)
        {
            Console.WriteLine("Sie können hier folgen Sachen machen:");
            Console.WriteLine("7. Reisen Wald");
            Console.WriteLine("8. Reisen Burg");
            Console.WriteLine("9. Reisen Bauernhof");
            Console.WriteLine("0. Inverntar ausgeben lassen");
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
                    default:
                        Console.WriteLine("Die Angabe stimmt nicht überein.");
                        break;
                }
            }
        }
    }
}
