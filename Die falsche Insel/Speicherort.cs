class Speicherort
{
    //Algemein
    private int energie;


    //Material
    private int apfel;
    private int birne;
    private int bier;
    private int baumstamm;
    private int beutel;
    private int fliegenpilz;
    private int karotten;
    private int kartoffeln;
    private int kraut;
    private int lehm;
    private int pilz;
    private int sand;
    private int stein;
    private int stock;
    private int wasserBeutel;
    private int ziegel;
    //Werkzeug
    private bool axt = false;
    //Bauen
    private bool brueckeFluss = false;


    //Story
    //König
    private bool koenigAugabeErhaeltlich = true;
    private int koenigAugebeStuffe = 0;
    //Bauer
    private bool bauerAufgabeErhalten = true;
    private int bauerAufbabenStuffe = 0;
    //Brauer
    private bool brauerAufgabeErhalten = false;
    private int brauerAufgabeStuffe = 0;
    //Schmied
    private bool schmiedAufgabeErhalten = false;
    private int schmiedAufgabeStuffe = 0;

    public int Energie { get => energie; set => energie = value; }
    public int Apfel { get => apfel; set => apfel = value; }
    public int Birne { get => birne; set => birne = value; }
    public int Bier { get => bier; set => bier = value; }
    public int Baumstamm { get => baumstamm; set => baumstamm = value;}
    public int Beutel { get => beutel; set => beutel = value; }
    public int Fliegenpilz { get => fliegenpilz; set => fliegenpilz = value;}
    public int Karotten { get => karotten; set => karotten = value;}
    public int Kartoffeln { get => kartoffeln; set => kartoffeln = value;}
    public int Kraut { get => kraut; set => kraut = value;}
    public int Lehm { get => lehm; set => lehm = value; }
    public int Pilz { get => pilz; set => pilz = value;}
    public int Sand { get => sand; set => sand = value; }
    public int Stein { get =>  stein; set => stein = value;}
    public int Stock { get => stock; set => stock = value;}
    public int WasserBeutel { get => wasserBeutel; set => stock = value; }
    public int Ziegel { get => ziegel; set => ziegel = value; }

    public bool Axt { get => axt; set => axt = value; }

    public bool Brueckefluss { get => brueckeFluss; set => brueckeFluss = value; }

    public bool KoenigAufgabe { get => koenigAugabeErhaeltlich; set => koenigAugabeErhaeltlich = value;}
    public int KoenigAugabenStuffe { get => koenigAugebeStuffe; set => koenigAugebeStuffe = value;}
    public bool BauerAufgabe { get => bauerAufgabeErhalten; set => bauerAufgabeErhalten = value;}
    public int BauerAufgabeStuffe { get => bauerAufbabenStuffe; set => bauerAufbabenStuffe = value;}
    public bool BrauerAufgabe { get => brauerAufgabeErhalten; set => brauerAufgabeErhalten = value;}
    public int BrauerAufgabeStuffe { get => brauerAufgabeStuffe; set => brauerAufgabeStuffe = value;}
    public bool SchmiedAufgabe { get => schmiedAufgabeErhalten; set => schmiedAufgabeErhalten = value;}
    public int SchmiedAufgabeStuffe { get => schmiedAufgabeStuffe; set => schmiedAufgabeStuffe = value;}
    public Speicherort(int energie,int apfel, int birne,int bier, int beutel, int baumstamm, int fliegenpilz, int karotten, int kartoffeln, int kraut, int lehm, int pilz, int stein, int stock, int wasserbeutel)
    {
        Energie = energie;
        Apfel = apfel;
        Birne = birne;
        Bier = bier;
        Beutel = beutel;
        Baumstamm = baumstamm;
        Fliegenpilz = fliegenpilz;
        Karotten = karotten;
        Kartoffeln = kartoffeln;
        Kraut = kraut;
        Lehm = lehm;
        Pilz = pilz;
        Stein = stein;
        Stock = stock;
        WasserBeutel = wasserbeutel;
    }
}