class Burg
{
    private String _eingabe = null;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;



    public Burg(Verabreitung verabreitung, Inventar inventar)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
    }
    public String BurgMain()
    {
        Console.WriteLine("Wikommen im Dorf des Handels");
        while (true)
        {
            Console.WriteLine("Sie können hier folgen Sachen machen:");
            Console.WriteLine("9. Reisen Dorf");
            Console.WriteLine("0. Inventar ausgeben lassen");
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
                
                }
            }
        }
    }
}
