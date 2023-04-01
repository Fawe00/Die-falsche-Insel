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
}
