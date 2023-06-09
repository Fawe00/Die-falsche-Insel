﻿class Speicherort
{
    //Allgemein
    private int energie;


    //Material
    private int apfel;
    private int birne;
    private int bier;
    private int baumstamm;
    private int beutel;
    private int fisch;
    private int fliegenpilz;
    private int holzscheite;
    private int holzstucke;
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
    private bool angel = false;
    private bool axt = false;
    private bool sage = false;
    //Bauen
    private bool brueckeFluss = false;
    private bool muhleWiese = false;
    private bool sagewerkWiese = false;


    //Story
    //König
    private bool koenigAugabeErhaeltlich = true;
    private int koenigAugebeStuffe = 0;
    //Bauer
    private bool bauerAufgabeErhalten = true;
    private int bauerAufbabenStuffe = 0;
    //Brauer
    private bool brauerAufgabeErhalten = true;
    private int brauerAufgabeStuffe = 0;
    //Minenarbeiter
    private bool minenarbeiterAufgabeErhalten = false;
    private int minenarbeiterAufgabeStuffe = 0;
    //Schmied
    private bool schmiedAufgabeErhalten = true;
    private int schmiedAufgabeStuffe = 0;
    //Ziegler
    private bool zieglerAufgabeErhalten = true;
    private int zieglerAufgabeStuffe = 0;
    //Fischer
    private bool fischerAufgabeErhalten = false;
    private int fischerAufgabeStuffe = 0;

    //Produktion
    private bool ziegelHerstellen = false;

    public int Energie { get => energie; set => energie = value; }
    public int Apfel { get => apfel; set => apfel = value; }
    public int Birne { get => birne; set => birne = value; }
    public int Bier { get => bier; set => bier = value; }
    public int Baumstamm { get => baumstamm; set => baumstamm = value;}
    public int Beutel { get => beutel; set => beutel = value; }
    public int Fisch { get => fisch; set => fisch = value; }
    public int Fliegenpilz { get => fliegenpilz; set => fliegenpilz = value;}
    public int Holzscheite { get => holzscheite; set => holzscheite = value; }
    public int Holzstuck { get => holzstucke; set => holzstucke = value; }
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

    public bool Angel { get => angel; set => angel = value; }
    public bool Axt { get => axt; set => axt = value; }
    public bool Sage { get => sage; set => sage = value; }

    public bool BrueckeFluss { get => brueckeFluss; set => brueckeFluss = value; }
    public bool MuhleWiese { get => muhleWiese; set => muhleWiese = value; }
    public bool SagewerkWiese { get => sagewerkWiese; set => sagewerkWiese = value; }

    public bool KoenigAufgabe { get => koenigAugabeErhaeltlich; set => koenigAugabeErhaeltlich = value;}
    public int KoenigAugabenStuffe { get => koenigAugebeStuffe; set => koenigAugebeStuffe = value;}
    public bool BauerAufgabe { get => bauerAufgabeErhalten; set => bauerAufgabeErhalten = value;}
    public int BauerAufgabeStuffe { get => bauerAufbabenStuffe; set => bauerAufbabenStuffe = value;}
    public bool BrauerAufgabe { get => brauerAufgabeErhalten; set => brauerAufgabeErhalten = value;}
    public int BrauerAufgabeStuffe { get => brauerAufgabeStuffe; set => brauerAufgabeStuffe = value;}
    public bool MinenarbeiterAufgabe { get => minenarbeiterAufgabeErhalten; set => minenarbeiterAufgabeErhalten = value; }
    public int MinenarbeiterAufgabeStuffe { get => minenarbeiterAufgabeStuffe; set => minenarbeiterAufgabeStuffe= value;}
    public bool SchmiedAufgabe { get => schmiedAufgabeErhalten; set => schmiedAufgabeErhalten = value;}
    public int SchmiedAufgabeStuffe { get => schmiedAufgabeStuffe; set => schmiedAufgabeStuffe = value;}
    public bool ZieglerAufgabe { get => zieglerAufgabeErhalten; set => zieglerAufgabeErhalten = value;}
    public int ZieglerAufgabeStuffe { get => zieglerAufgabeStuffe; set => zieglerAufgabeStuffe = value;}
    public bool FischerAufgabe { get => fischerAufgabeErhalten; set => fischerAufgabeErhalten = value;}
    public int FischerAufgabeStuffe { get => fischerAufgabeStuffe; set => fischerAufgabeStuffe = value; }
    public bool ZiegelHerstellen { get => ziegelHerstellen; set => ziegelHerstellen = value;}
    public Speicherort(int energie,int apfel, int birne,int bier, int beutel, int baumstamm, int fisch, int fliegenpilz, int karotten, int kartoffeln, int kraut, int lehm, int pilz, int stein, int stock, int wasserbeutel, int ziegel)
    {
        Energie = energie;
        Apfel = apfel;
        Birne = birne;
        Bier = bier;
        Beutel = beutel;
        Baumstamm = baumstamm;
        Fisch = fisch;
        Fliegenpilz = fliegenpilz;
        Karotten = karotten;
        Kartoffeln = kartoffeln;
        Kraut = kraut;
        Lehm = lehm;
        Pilz = pilz;
        Stein = stein;
        Stock = stock;
        WasserBeutel = wasserbeutel;
        Ziegel = ziegel;
    }
}