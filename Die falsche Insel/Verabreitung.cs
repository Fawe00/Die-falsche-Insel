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
        if (energie > 5)
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
                    zaehlerSammeln = 0;
                    break;

            }
            _speicherort.Stock = stock;
            _speicherort.Fliegenpilz = fliegenpilz;
            _speicherort.Pilz = pilz;
        }
    }

}
