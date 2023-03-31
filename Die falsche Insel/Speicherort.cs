class Speicherort
{
    //Algemein
    private int energie;


    //Material
    private int baumstamm;
    private int fliegenpilz;
    private int pilz;
    private int stein;
    private int stock;


    public int Energie { get => energie; set => energie = value; }
    public int Baumstamm { get => baumstamm; set => baumstamm = value;}
    public int Fliegenpilz { get => fliegenpilz; set => fliegenpilz = value;}
    public int Pilz { get => pilz; set => pilz = value;}
    public int Stein { get =>  stein; set => stein = value;}
    public int Stock { get => stock; set => stock = value;}

    public Speicherort(int energie, int baumstamm, int fliegenpilz, int pilz, int stein, int stock)
    {
        Energie = energie;
        Baumstamm = baumstamm;
        Fliegenpilz = fliegenpilz;
        Pilz = pilz;
        Stein = stein;
        Stock = stock;
    }
}