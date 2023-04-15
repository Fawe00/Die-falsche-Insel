class Verabreitung
{
    private readonly Speicherort _speicherort;
    private int zaehlerSammeln = 1;


    public Verabreitung(Speicherort speicherort)
    {
        _speicherort = speicherort;
    }
    public void Holzhacken()
    {
        int energie = _speicherort.Energie;
        int baumstamm = _speicherort.Baumstamm;
        if (energie >= 5)
        {
            energie -= 5;
            baumstamm++;
            _speicherort.Energie = energie;
            _speicherort.Baumstamm = baumstamm;
        }
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
                    break;
                case 1:
                    pilz++;
                    zaehlerSammeln++;
                    break;
                case 2:
                    stock++;
                    zaehlerSammeln++;
                    break;
                case 3:
                    kraut++;
                    zaehlerSammeln = 0;
                    break;

            }
            _speicherort.Stock = stock;
            _speicherort.Fliegenpilz = fliegenpilz;
            _speicherort.Kraut = kraut;
            _speicherort.Pilz = pilz;
            _speicherort.Energie = energie;
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
            _speicherort.Energie = energie;
            _speicherort.Stein = stein;
        }
    }
    public void KarottenErnten()
    {
        int energie = _speicherort.Energie;
        int karotten = _speicherort.Karotten;
        if (energie >= 1)
        {
            energie -= 1;
            karotten++;
            _speicherort.Energie = energie;
            _speicherort.Karotten = karotten;
        }
    }
    public void KartoffelnErnten()
    {
        int energie = _speicherort.Energie;
        int kartoffeln = _speicherort.Kartoffeln;
        if (energie >= 3)
        {
            energie -= 3;
            kartoffeln++;
            _speicherort.Energie = energie;
            _speicherort.Kartoffeln = kartoffeln;
        }
    }
    public void ApfelPlucken()
    {
        int energie = _speicherort.Energie;
        int apfel = _speicherort.Apfel;
        if (apfel >= 1)
        {
            energie -= 1;
            apfel++;
            _speicherort.Apfel = apfel;
            _speicherort.Energie = energie;
        }
    }
    public void BirnePlucken()
    {
        int energie = _speicherort.Energie;
        int birne = _speicherort.Birne;
        if (energie >= 1)
        {
            energie -= 1;
            birne++;
            _speicherort.Birne = birne;
            _speicherort.Energie = energie;
        }
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
            }
            else
            {
                Console.WriteLine("Sie haben keine Beutel zum befüllen mit Wasser.");
            }
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
        }
        _speicherort.Energie = energie;
        _speicherort.Sand = sand;
    }
}
