class Standard
{
    public void StandardFalscheEingabe()
    {
        Console.WriteLine("Die Eingabe ist nicht korrekt.");
        Console.WriteLine("Sie können nur Zahlen oder Buchstaben eingeben, die vorhanden sind.");
    }
    public void StandardEingabe0Wahl()
    {
        Console.WriteLine("0. Beutel öffen");
    }
    public void StandardInselnWahl()
    {
        Console.WriteLine("Sie können folgende Sachen tun:");
    }
    public void StandardIhrWahlEingabe()
    {
        Console.WriteLine("Geben Sie die Nummer oder den Buchstaben ein, den Sie wählen wollen.");
    }
    public void StandardEnergieMangelAusfurlich(int n)
    {
        Console.WriteLine("Sie brachen für diese " + n + " Energie.");
    }
}