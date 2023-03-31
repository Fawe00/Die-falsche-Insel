﻿class Inventar
{
    private readonly Speicherort _speicherort;

    public Inventar(Speicherort speicherort)
    {
        _speicherort = speicherort;
    }
    public void InventarAusagabe()
    {
        Console.WriteLine("Energie:" + _speicherort.Energie);
        Console.WriteLine("Baumstamm:" + _speicherort.Baumstamm);
        Console.WriteLine("Fiegenpilz:" + _speicherort.Fliegenpilz);
        Console.WriteLine("Kräuter" + _speicherort.Kraut);
        Console.WriteLine("Pilz:" + _speicherort.Pilz);
        Console.WriteLine("Stock:" + _speicherort.Stock);
    }
}
