class Verarbeitung
{
    private readonly Speicherort _speicherort;
    private readonly Standard _standard;
    private int zaehlerSammeln = 1;


    public Verarbeitung(Speicherort speicherort, Standard standard)
    {
        _speicherort = speicherort;
        _standard = standard;
    }
    public void Holzhacken()
    {
        int energie = _speicherort.Energie;
        int baumstamm = _speicherort.Baumstamm;
        if (energie >= 5 && _speicherort.Axt)
        {
            energie -= 5;
            baumstamm++;
            _standard.StandardWasBekommen(1, "Baumstamm");
        }
        else
        {
            Console.WriteLine("Sie haben zu wenig Energie oder keine Axt.");
        }
        _speicherort.Energie = energie;
        _speicherort.Baumstamm = baumstamm;
    }
    public void SammelnImWald()
    {
        int energie = _speicherort.Energie;
        int fliegenpilz = _speicherort.Fliegenpilz;
        int kraut = _speicherort.Kraut;
        int pilz = _speicherort.Pilz;
        int stock = _speicherort.Stock;
        if(energie >= 1)
        {
            energie -= 1;
            switch (zaehlerSammeln)
            {
                case 0:
                    fliegenpilz++;
                    zaehlerSammeln++;
                    _standard.StandardWasBekommen(1, "Fliegenpilz");
                    break;
                case 1:
                    pilz++;
                    zaehlerSammeln++;
                    _standard.StandardWasBekommen(1, "Pilz");
                    break;
                case 2:
                    stock++;
                    zaehlerSammeln++;
                    _standard.StandardWasBekommen(1, "Stock");
                    break;
                case 3:
                    kraut++;
                    zaehlerSammeln = 0;
                    _standard.StandardWasBekommen(1, "Kraut");
                    break;

            }
            _speicherort.Stock = stock;
            _speicherort.Fliegenpilz = fliegenpilz;
            _speicherort.Kraut = kraut;
            _speicherort.Pilz = pilz;
            _speicherort.Energie = energie;
        }else
        {
            _standard.StandardEnergieMangelAusfurlich(1);
        }
    }
    public void SteinAbBauen()
    {
        int energie = _speicherort.Energie;
        int stein = _speicherort.Stein;
        if (energie >= 4)
        {
            energie -= 4;
            stein++;
            _standard.StandardWasBekommen(1, "Stein");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(4);
        }
        _speicherort.Energie = energie;
        _speicherort.Stein = stein;
    }
    public void KarottenErnten()
    {
        int energie = _speicherort.Energie;
        int karotten = _speicherort.Karotten;
        if (energie >= 1)
        {
            energie -= 1;
            karotten++;
            _standard.StandardWasBekommen(1, "Karotten");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(1);
        }
        _speicherort.Energie = energie;
        _speicherort.Karotten = karotten;
    }
    public void KartoffelnErnten()
    {
        int energie = _speicherort.Energie;
        int kartoffeln = _speicherort.Kartoffeln;
        if (energie >= 3)
        {
            energie -= 3;
            kartoffeln++;
            _standard.StandardWasBekommen(1, "Kartoffeln");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(3);
        }
        _speicherort.Energie = energie;
        _speicherort.Kartoffeln = kartoffeln;
    }
    public void ApfelPlucken()
    {
        int energie = _speicherort.Energie;
        int apfel = _speicherort.Apfel;
        if (energie >= 1)
        {
            energie -= 1;
            apfel++;
            _standard.StandardWasBekommen(1, "Apfel");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(1);
        }
        _speicherort.Apfel = apfel;
        _speicherort.Energie = energie;
    }
    public void BirnePlucken()
    {
        int energie = _speicherort.Energie;
        int birne = _speicherort.Birne;
        if (energie >= 1)
        {
            energie -= 1;
            birne++;
            _standard.StandardWasBekommen(1, "Birne");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(1);
        }
        _speicherort.Birne = birne;
        _speicherort.Energie = energie;
    }
    public void Wasserschoepfen()
    {
        int energie = _speicherort.Energie;
        int beutel = _speicherort.Beutel;
        int wasserbeutel = _speicherort.WasserBeutel;
        if (energie >= 1)
        {
            if (beutel >= 1)
            {
                beutel--;
                energie--;
                wasserbeutel++;
                _standard.StandardWasBekommen(1, "Wasserbeutel");
            }
            else
            {
                Console.WriteLine("Sie haben keine Beutel zum befüllen mit Wasser.");
            }
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(1);
        }
        _speicherort.Energie = energie;
        _speicherort.Beutel = beutel;
        _speicherort.WasserBeutel = wasserbeutel;
    }
    public void LehmStecken()
    {
        int energie = _speicherort.Energie;
        int lehm = _speicherort.Lehm;
        if (energie >= 2)
        {
            lehm++;
            energie -= 2;
            _standard.StandardWasBekommen(1, "Lehm");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(2);
        }
        _speicherort.Energie = energie;
        _speicherort.Lehm = lehm;
    }
    public void SandNehmen()
    {
        int energie = _speicherort.Energie;
        int sand = _speicherort.Sand;
        if( energie >= 2)
        {
            sand++;
            energie -= 2;
            _standard.StandardWasBekommen(1, "Sand");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(2);
        }
        _speicherort.Energie = energie;
        _speicherort.Sand = sand;
    }
    public void HolzSagen()
    {
        int energie = _speicherort.Energie;
        int holzstucke = _speicherort.Holzstuck;
        int baumstamm = _speicherort.Baumstamm;
        if(energie >= 4)
        {
            holzstucke += 4;
            energie -= 4;
            baumstamm--;
            _standard.StandardWasBekommen(4, "Holzstücke");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(4);
        }
        _speicherort.Baumstamm = baumstamm;
        _speicherort.Energie = energie;
        _speicherort.Holzstuck = holzstucke;
    }
    public void HolzSpalten()
    {
        int energie = _speicherort.Energie;
        int holzstucke = _speicherort.Holzstuck;
        int holzscheite = _speicherort.Holzscheite;
        if(energie >= 7)
        {
            energie -= 7;
            holzstucke--;
            holzscheite += 8;
            _standard.StandardWasBekommen(8, "Scheite");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(7);
        }
        _speicherort.Energie = energie;
        _speicherort.Holzscheite = holzscheite;
        _speicherort.Holzstuck = holzstucke;
    }
    public void ZiegelHerstellen()
    {
        int energie = _speicherort.Energie;
        int ziegel = _speicherort.Ziegel;
        int holzscheite = _speicherort.Holzscheite;
        int lehm = _speicherort.Lehm;
        if(energie >= 2)
        {
            energie -= 2;
            lehm -= 2;
            holzscheite -= 5;
            ziegel++;
            _standard.StandardWasBekommen(1, "Ziegel");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(2);
        }
        _speicherort.Energie = energie;
        _speicherort.Ziegel = ziegel;
        _speicherort.Lehm = lehm;
        _speicherort.Holzscheite = holzscheite;
    }
    public void Fischen()
    {
        int energie = _speicherort.Energie;
        int fisch = _speicherort.Fisch;
        if(energie >= 2)
        {
            energie -= 2;
            fisch++;
            _standard.StandardWasBekommen(1, "Fisch");
        }
        else
        {
            _standard.StandardEnergieMangelAusfurlich(2);
        }
        _speicherort.Fisch = fisch;
        _speicherort.Energie = energie;
    }

    // Bauen von Objekten
    public void BauenBruecke()
    {
        int energie = _speicherort.Energie;
        int stein = _speicherort.Stein;
        int baumstamm = _speicherort.Baumstamm;
        Console.WriteLine("Haben sie 10 Baumstämme und 9 Stein?");
        String eingabe = Console.ReadLine();
        if(eingabe != null)
        {
            bool janein = JaNeinGross(eingabe);
            if (janein) {

                if (baumstamm >= 10 && stein >= 9)
                {
                    if (energie >= 25)
                    {
                        Console.WriteLine("Die brücke ist jetzt fertig, Sie können sie jetzt vorsichtig begehen");
                        energie -= 25;
                        stein -= 9;
                        baumstamm -= 10;
                        _speicherort.BrueckeFluss = true;
                        Console.WriteLine("Die Brücke ist erstellt.");
                    }
                    else
                    {
                        _standard.StandardEnergieMangelAusfurlich(25);
                    }
                }
                else
                {
                    Console.WriteLine("Es fehlen Resouressen!");
                    Console.WriteLine("Dann kann die Brücke nicht gebaut werden");
                }
            }
        }
        _speicherort.Stein = stein;
        _speicherort.Baumstamm = baumstamm;
        _speicherort.Energie = energie;
    }
    public bool JaNeinGross(String eingabe)
    {
        switch (eingabe)
        {
            case "j":
            case "y":
            case "ja":
            case "J":
            case "Y":
            case "Ja":
                return true;
            case "n":
            case "nein":
            case "N":
            case "Nein":
                return false;
            default:
                return false;
        }
    }
}