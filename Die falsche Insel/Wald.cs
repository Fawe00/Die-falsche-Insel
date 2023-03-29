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
            Console.WriteLine("2. Material vom Boden ausammeln");
            Console.WriteLine("3. Inventar");
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
                    case "3":
                        _inventar.InventarAusagabe();
                        break;
                    default:
                        Console.WriteLine("Sie haben keien Nummer von 1 - 3 eingeben.");
                        break;
                }
            }
            

        }
    }
}
