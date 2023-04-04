class Programm
{
    private readonly Dorf _dorf;
    private readonly Wald _wald;
    private readonly Burg _burg;
    private readonly Berg _berg;

    private String runde = "Burg";

    public Programm(Wald wald, Dorf dorf, Burg burg, Berg berg)
    {
        _wald = wald;
        _dorf = dorf;
        _burg = burg;
        _berg = berg;
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
                case "Berg":
                    runde = _berg.BergMain();
                    break;
                default:
                    runde = "Wald";
                    break;
            }
        }
    }
}
