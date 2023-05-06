class Inventar
{
    private readonly Speicherort _speicherort;

    public Inventar(Speicherort speicherort)
    {
        _speicherort = speicherort;
    }
    public void InventarAusagabe()
    {
        Console.WriteLine("Energie:" + _speicherort.Energie);
        Console.WriteLine("Apfel: " + _speicherort.Apfel);
        Console.WriteLine("Birne: " + _speicherort.Birne);
        Console.WriteLine("Bier:" + _speicherort.Bier);
        Console.WriteLine("Baumstamm:" + _speicherort.Baumstamm);
        Console.WriteLine("Beutel: " + _speicherort.Beutel);
        Console.WriteLine("Fiegenpilz:" + _speicherort.Fliegenpilz);
        Console.WriteLine("Karotten: " + _speicherort.Karotten);
        Console.WriteLine("Kartoffeln: " + _speicherort.Kartoffeln);
        Console.WriteLine("Kräuter: " + _speicherort.Kraut);
        Console.WriteLine("Lehm: " + _speicherort.Lehm);
        Console.WriteLine("Pilz:" + _speicherort.Pilz);
        Console.WriteLine("Sand: " + _speicherort.Sand);
        Console.WriteLine("Stein: " + _speicherort.Stein);
        Console.WriteLine("Stock:" + _speicherort.Stock);
    }
}
