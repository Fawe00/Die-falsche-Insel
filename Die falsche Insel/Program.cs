class Programm
{
    private readonly Dorf _dorf;
    private readonly Wald _wald;
    private readonly Burg _burg;

    private String runde = "Wald";

    public Programm(Wald wald, Dorf dorf, Burg burg)
    {
        _wald = wald;
        _dorf = dorf;
        _burg = burg;
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
                    runde = _dorf.DorfMain();
                    break;
                case "Burg":
                    runde = _burg.BurgMain();
                    break;
                default:
                    runde = "Wald";
                    break;
            }
        }
    }
}
