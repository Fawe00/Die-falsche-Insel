class Fluss
{
    private String _eingabe;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Speicherort _speicherort;

    public Fluss(Verabreitung verabreitung, Inventar inventar, Speicherort speicherort)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _speicherort = speicherort;
    }
    public String FlussMain()
    {
        Console.WriteLine("Wikommen auf der Insel des Flusses");
        while (true)
        {
            Console.WriteLine("Sie können hier folgene Sachen machen");
            Console.WriteLine("1. Beutel mit Wasser füllen");
            Console.WriteLine("2. Lehm stechen");
            Console.WriteLine("3. Sand nehmen");
            Console.WriteLine("8. Reisen Bauerhof");
            if (_speicherort.Brueckefluss)
            {
                Console.WriteLine("9. Reisen Wiese");
            }
            else
            {
                Console.WriteLine("9. Brücke Bauen");
            }
            Console.WriteLine("0. Beutel Öffen");
            _eingabe = Console.ReadLine();
            switch (_eingabe)
            {
                case "1":
                    _verarbeitung.Wasserschoepfen();
                    break;
                case "2":
                    _verarbeitung.LehmStecken();
                    break;
                case "3":
                    _verarbeitung.SandNehmen();
                    break;
                case "8":
                    return "Bauernhof";
                case "9":
                    if (_speicherort.Brueckefluss)
                    {
                        return "Wiese";
                    }
                    else
                    {
                        break;
                    }
                case "0":
                    _inventar.InventarAusagabe();
                    break;
            }
        }
    }
}
