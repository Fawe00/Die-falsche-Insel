class Essen
{
    private readonly Speicherort _speicherort;
    private readonly Standard _standard;
    private string eingabe;

    public Essen(Speicherort speicherort, Standard standard)
    {
        _speicherort = speicherort;
        _standard = standard;
    }

    public void Saal()
    {
        int energie = _speicherort.Energie;
        if (energie <= 1000)
        {
            Console.WriteLine("Was wollen Sie essen oder trinken?");
            Console.WriteLine("1. Apfel");
            Console.WriteLine("2. Birne");
            Console.WriteLine("3. Karotte");
            Console.WriteLine("4. Bier");
            eingabe = Console.ReadLine();
            if (eingabe != null)
            {
                switch (eingabe)
                {
                    case "1":
                        EssenApfel();
                        break;
                    case "2":
                        EssenBirne();
                        break;
                    case "3":
                        EssenKarotte();
                        break;
                    case "4":
                        EssenBier();
                        break;
                    default:
                        _standard.StandardFalscheEingabe();
                        break;

                }
            }
        }
    }
    public void EssenKarotte()
    {
        int energie = _speicherort.Energie;
        int karotte = _speicherort.Karotten;
        if (karotte >= 1)
        {
            karotte--;
            energie += 3;
            _speicherort.Energie = energie;
            _speicherort.Karotten = karotte;
        }
        else
        {
            Console.WriteLine("Sie haben zu wenige Karotten.");
        }
    }
    public void EssenApfel()
    {
        int energie = _speicherort.Energie;
        int apfel = _speicherort.Apfel;
        if (apfel >= 1)
        {
            apfel--;
            energie += 5;
            _speicherort.Energie = energie;
            _speicherort.Apfel = apfel;
        }
        else
        {
            Console.WriteLine("Sie haben zu wenige Äpfel.");
        }
    }
    public void EssenBirne()
    {
        int birne = _speicherort.Birne;
        int energie = _speicherort.Energie;
        if (birne >= 1)
        {
            birne--;
            energie += 5;
            _speicherort.Birne = birne;
            _speicherort.Energie = energie;
        }
        else
        {
            Console.WriteLine("Sie haben zu wenig Birnen.");
        }
    }
    private void EssenBier()
    {
        int bier = _speicherort.Bier;
        int energie = _speicherort.Energie;
        if(bier >= 1)
        {
            bier--;
            energie += 15;
            _speicherort.Bier = bier;
            _speicherort.Energie = energie;
        }
        else
        {
            Console.WriteLine("Sie haben zu wenig Bier.");
        }
    }
}