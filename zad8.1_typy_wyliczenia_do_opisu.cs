using System;

public class Program
{
    public enum DniTygodnia
    {
        Poniedzialek,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }

    public enum EtapyPrania
    {
        WkladaniePomocnikow,
        WyborProgramu,
        RozpoczeciePrania,
        Pioranie,
        PlynDoPlukania,
        Wirowanie,
        KoniecPrania
    }

    public enum Posilki
    {
        Sniadanie,
        DrugieSniadanie,
        Obiad,
        Podwieczorek,
        Kolacja
    }

    public enum BierkiSzachowe
    {
        Wieza,
        Skoczek,
        Goniec,
        Hetman,
        Krol,
        Pionek
    }

    public static void Main(string[] args)
    {
        Random random = new Random();

        DniTygodnia dzien = (DniTygodnia)random.Next(Enum.GetNames(typeof(DniTygodnia)).Length);
        EtapyPrania etap = (EtapyPrania)random.Next(Enum.GetNames(typeof(EtapyPrania)).Length);
        Posilki posilek = (Posilki)random.Next(Enum.GetNames(typeof(Posilki)).Length);
        BierkiSzachowe bierka = (BierkiSzachowe)random.Next(Enum.GetNames(typeof(BierkiSzachowe)).Length);

        Console.WriteLine($"Dzień tygodnia: {dzien}");
        Console.WriteLine($"Etap prania: {etap}");
        Console.WriteLine($"Posiłek: {posilek}");
        Console.WriteLine($"Bierka szachowa: {bierka}");
    }
}
