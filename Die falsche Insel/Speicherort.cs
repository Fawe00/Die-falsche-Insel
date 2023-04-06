﻿class Speicherort
{
    //Algemein
    private int energie;


    //Material
    private int apfel;
    private int birne;
    private int baumstamm;
    private int fliegenpilz;
    private int karotten;
    private int kartoffeln;
    private int kraut;
    private int pilz;
    private int stein;
    private int stock;


    //Story
    //König
    private bool koenigAugabeErhaeltlich = true;
    private int koenigAugebeStuffe = 0;

    public int Energie { get => energie; set => energie = value; }
    public int Apfel { get => apfel; set => apfel = value; }
    public int Birne { get => birne; set => birne = value; }
    public int Baumstamm { get => baumstamm; set => baumstamm = value;}
    public int Fliegenpilz { get => fliegenpilz; set => fliegenpilz = value;}
    public int Karotten { get => karotten; set => karotten = value;}
    public int Kartoffeln { get => kartoffeln; set => kartoffeln = value;}
    public int Kraut { get => kraut; set => kraut = value;}
    public int Pilz { get => pilz; set => pilz = value;}
    public int Stein { get =>  stein; set => stein = value;}
    public int Stock { get => stock; set => stock = value;}

    public bool KoenigAufgabe { get => koenigAugabeErhaeltlich; set => koenigAugabeErhaeltlich = value;}
    public int KoenigAugabenStuffe { get => koenigAugebeStuffe; set => koenigAugebeStuffe = value;}

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