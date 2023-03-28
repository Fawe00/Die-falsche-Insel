using System.Runtime.CompilerServices;

class Wald
{
    private String _eingabe;
    private readonly Verabreitung _verarbeitung;

    public string Eingabe { get => _eingabe; set => _eingabe = value; }

    public Wald(Verabreitung verabreitung) 
    {
        _verarbeitung = verabreitung;
    }

    public string WaldMain()
    {
        Console.WriteLine("Wikommen auf der Insel des Waldes");
        while (true)
        {
            Console.WriteLine("Sie können hier folgen Sachen machen:");
            Console.WriteLine("1. Baum fällen");
            Console.WriteLine("2. Material vom Boden ausammeln");
            Console.WriteLine("Geben Sie die Nummer ein die Sie wählen wollen");
            _eingabe = Console.ReadLine();
            if (_eingabe == null)
            {
                switch (_eingabe)
                {
                    case "1":
                        _verarbeitung.Holzhacken();
                        break;
                    case "2":
                        _verarbeitung.SammelnImWald();
                        break;
                    default:
                        Console.WriteLine("Sie haben keien Nummer von 1 - 2 eingeben.");
                        break;
                }
            }
            

        }
    }
}
