using System;

public class Program
{
    public enum Rzadkosc
    {
        Powszechny,
        Rzadki,
        Unikalny,
        Epicki
    }

    public enum TypPrzedmiotu
    {
        Bron,
        Zbroja,
        Amulet,
        Pierscien,
        Helm,
        Tarcza,
        Buty
    }

    public struct Przedmiot
    {
        public float Waga;
        public int Wartosc;
        public Rzadkosc Rzadkosc;
        public TypPrzedmiotu Typ;
        public string NazwaWlasna;

        public void WypelnijPrzedmiot(float waga, int wartosc, Rzadkosc rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
        {
            Waga = waga;
            Wartosc = wartosc;
            Rzadkosc = rzadkosc;
            Typ = typ;
            NazwaWlasna = nazwaWlasna;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Informacje o przedmiocie:");
            Console.WriteLine($"Nazwa: {NazwaWlasna}");
            Console.WriteLine($"Typ: {Typ}");
            Console.WriteLine($"Rzadkosc: {Rzadkosc}");
            Console.WriteLine($"Waga: {Waga}");
            Console.WriteLine($"Wartosc: {Wartosc} szt. złota");
        }
    }

    public static Przedmiot LosujPrzedmiot(Przedmiot[] przedmioty)
    {
        Random random = new Random();
        int index = random.Next(przedmioty.Length);
        return przedmioty[index];
    }

    public static void Main(string[] args)
    {
        Przedmiot[] przedmioty = new Przedmiot[4];

        przedmioty[0].WypelnijPrzedmiot(2.5f, 100, Rzadkosc.Powszechny, TypPrzedmiotu.Bron, "Miecz");
        przedmioty[1].WypelnijPrzedmiot(3.0f, 250, Rzadkosc.Rzadki, TypPrzedmiotu.Zbroja, "Pancerz");
        przedmioty[2].WypelnijPrzedmiot(0.5f, 500, Rzadkosc.Unikalny, TypPrzedmiotu.Amulet, "Amulet Mocy");
        przedmioty[3].WypelnijPrzedmiot(1.0f, 1000, Rzadkosc.Epicki, TypPrzedmiotu.Helm, "Hełm Smoczej Czaszki");

        Przedmiot losowyPrzedmiot = LosujPrzedmiot(przedmioty);
        losowyPrzedmiot.WyswietlInformacje();
    }
}
