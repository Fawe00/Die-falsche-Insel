class Wiese
{
    private String _eingabe;
    private readonly Verarbeitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Speicherort _speicherort;
    private readonly Standard _standard;

    public Wiese(Verarbeitung verarbeitung, Inventar inventar, Speicherort speicherort, Standard standard)
    {
        _verarbeitung = verarbeitung;
        _inventar = inventar;
        _speicherort = speicherort;
        _standard = standard;
    }
    public String WieseMain()
    {
        return "Fluss";
        Console.WriteLine("Willkommen aud der Insel der Wiesen und Freiflächen");
        while (true)
        {
            _standard.StandardInselnWahl();
            if (_speicherort.SagewerkWiese)
            {
                Console.WriteLine("1. Sägewerk betreiben");
            }
            else
            {
                Console.WriteLine("1. Sägewerk bauen");
            }
            if (_speicherort.MuhleWiese)
            {
                Console.WriteLine("2. Mühle betreiben");
            }
            else
            {
                Console.WriteLine("2. Mühle bauen");
            }

        }
    }
}