class Fluss
{
    private String _eingabe;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Speicherort _speicherort;
    private readonly Standard _standard;

    public Fluss(Verabreitung verabreitung, Inventar inventar, Speicherort speicherort, Standard standard)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _speicherort = speicherort;
        _standard = standard;
    }
    public String FlussMain()
    {
        Console.WriteLine("Willkommen auf der Insel des Flusses");
        while (true)
        {
            _standard.StardartInselnWahl();
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
                Console.WriteLine("9. Brücke bauen");
            }
            _standard.StandartEingabe0Wahl();
            _standard.StardartIhrWahlEingabe();
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
                        _verarbeitung.BauenBruecke();
                        break;
                    }
                case "0":
                    _inventar.InventarAusagabe();
                    break;
            }
        }
    }
}
