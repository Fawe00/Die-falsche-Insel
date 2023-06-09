﻿class Wald
{
    private String _eingabe = null;
    private readonly Verarbeitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Standard _standard;

    public Wald(Verarbeitung verabreitung, Inventar inventar, Standard standard) 
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
        _standard = standard;
    }

    public string WaldMain()
    {
        Console.WriteLine("Willkommen auf der Insel des Waldes");
        while (true)
        {
            _standard.StandardInselnWahl();
            Console.WriteLine("1. Baum fällen");
            Console.WriteLine("2. Material vom Boden aufsammeln");
            Console.WriteLine("8. Reisen auf dem Berg");
            Console.WriteLine("9. Reisen in das Dorf");
            _standard.StandardEingabe0Wahl();
            _standard.StandardIhrWahlEingabe();
            _eingabe = Console.ReadLine();
            if (_eingabe != null)
            {
                switch (_eingabe)
                {
                    case "1":
                        _verarbeitung.Holzhacken();
                        break;
                    case "2":
                        _verarbeitung.SammelnImWald();
                        break;
                    case "0":
                        _inventar.InventarAusagabe();
                        break;
                    case "9":
                        return "Dorf";
                    case "8":
                        return "Berg";
                    default:
                        Console.WriteLine("Die Angabe stimmt nicht überein.");
                        break;
                }
            }
        }
    }
}
