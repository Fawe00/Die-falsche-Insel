class Dorf
{
    private String _eingabe = null;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Standard _standard;



    public Dorf(Verabreitung verabreitung, Inventar inventar, Standard standard)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _standard = standard;
    }
    public String DorfMain()
    {
        Console.WriteLine("Willkommen im Dorf des Handels");
        while (true)
        {
            Console.WriteLine("Sie können hier folgen Sachen machen:");
            Console.WriteLine("7. Reisen Wald");
            Console.WriteLine("8. Reisen Burg");
            Console.WriteLine("9. Reisen Bauernhof");
            _standard.StandartEingabe0Wahl();
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
                        _standard.StandartFalscheEingabe();
                        break;
                }
            }
        }
    }
}