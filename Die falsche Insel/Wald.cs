using System.Runtime.CompilerServices;

class Wald
{
    private String _eingabe = null;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;

    public Wald(Verabreitung verabreitung, Inventar inventar) 
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
    }

    public string WaldMain()
    {
        Console.WriteLine("Willkommen auf der Insel des Waldes");
        while (true)
        {
            Console.WriteLine("Sie können hier folgen Sachen machen:");
            Console.WriteLine("1. Baum fällen");
            Console.WriteLine("2. Material vom Boden aufsammeln");
            Console.WriteLine("9. Reisen in das Dorf");
            Console.WriteLine("0. Inventar ausgeben lassen");
            Console.WriteLine("Geben Sie die Nummer ein die Sie wählen wollen");
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
                    default:
                        Console.WriteLine("Sie haben keine Nummer von 1 - 3 eingeben.");
                        break;
                }
            }
        }
    }
}
