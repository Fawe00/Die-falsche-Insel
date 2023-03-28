class Programm
{
    private readonly Wald _wald;

    private String runde = "Wald";

    public Programm(Wald wald)
    {
        _wald = wald;
    }
    public void Runde()
    {
        while (true)
        {
            switch (runde)
            {
                case "Wald":
                    runde = _wald.WaldMain();
                    break;
                case "Dorf":
                    Console.WriteLine("Dorf");
                    break;
                default:
                    runde = "Wald";
                    break;
            }
        }
    }
}
