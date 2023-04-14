class Fluss
{
    private String _eingabe;
    private readonly Verabreitung _verarbeitung;
    private readonly Inventar _inventar;

    public Fluss(Verabreitung verabreitung, Inventar inventar)
    {
        _verarbeitung = verabreitung;
        _inventar = inventar;
    }
    public String FlussMain()
    {
        Console.WriteLine("Wikommen auf der Insel des Flusses");
        while (true)
        {

        }
    }
}
