class Wiese
{
    private String _eingabe;
    private readonly Verarbeitung _verarbeitung;
    private readonly Inventar _inventar;
    private readonly Speicherort _speicherort;

    public Wiese(Verarbeitung verarbeitung, Inventar inventar, Speicherort speicherort)
    {
        _verarbeitung = verarbeitung;
        _inventar = inventar;
        _speicherort = speicherort;
    }
    public String WieseMain()
    {
        // Zuerst korigiren von allen dann weitermachen
        return "Fluss";
    }
}