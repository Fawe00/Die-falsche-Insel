class Programm
{
    private readonly Dorf _dorf;
    private readonly Wald _wald;
    private readonly Burg _burg;
    private readonly Berg _berg;
    private readonly Bauerhof _bauerhof;
    private readonly Fluss _fluss;

    private String runde = "Burg";

    public Programm(Wald wald, Dorf dorf, Burg burg, Berg berg, Bauerhof bauerhof, Fluss fluss)
    {
        _wald = wald;
        _dorf = dorf;
        _burg = burg;
        _berg = berg;
        _bauerhof = bauerhof;
        _fluss = fluss;
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
                case "Bauernhof":
                    runde = _bauerhof.BauerhofMain();
                    break;
                case "Fluss":
                    runde = _fluss.FlussMain();
                    break;
                default:
                    runde = "Wald";
                    break;
            }
        }
    }
}
