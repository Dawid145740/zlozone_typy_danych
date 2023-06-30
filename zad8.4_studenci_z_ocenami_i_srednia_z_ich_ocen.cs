using System;

public class Program
{
    public enum Plec
    {
        Kobieta,
        Mezczyzna
    }

    public struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public double Ocena;
        public Plec Plec;

        public void WypelnijStudenta(string nazwisko, int nrAlbumu, double ocena, Plec plec)
        {
            Nazwisko = nazwisko;
            NrAlbumu = nrAlbumu;
            Ocena = Math.Round(Math.Max(2.0, Math.Min(5.0, ocena)), 2);
            Plec = plec;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Student: {Nazwisko}, Nr albumu: {NrAlbumu}, Ocena: {Ocena}, Płeć: {Plec}");
        }
    }

    public static double SredniaOcen(Student[] grupa)
    {
        double suma = 0;
        foreach (var student in grupa)
        {
            suma += student.Ocena;
        }

        return Math.Round(suma / grupa.Length, 2);
    }

    public static void Main(string[] args)
    {
        Student[] grupa = new Student[5];
        Random random = new Random();

        grupa[0].WypelnijStudenta("Kowalski", 12345, Math.Round(random.NextDouble() * 4 + 2, 2), Plec.Mezczyzna);
        grupa[1].WypelnijStudenta("Nowak", 23456, Math.Round(random.NextDouble() * 4 + 2, 2), Plec.Kobieta);
        grupa[2].WypelnijStudenta("Klimek", 34567, Math.Round(random.NextDouble() * 4 + 2, 2), Plec.Mezczyzna);
        grupa[3].WypelnijStudenta("Nycz", 45678, Math.Round(random.NextDouble() * 4 + 2, 2), Plec.Kobieta);
        grupa[4].WypelnijStudenta("Mol", 56789, Math.Round(random.NextDouble() * 4 + 2, 2), Plec.Kobieta);

        foreach (var student in grupa)
        {
            student.WyswietlInformacje();
        }

        double srednia = SredniaOcen(grupa);
        Console.WriteLine($"Średnia ocen w grupie: {srednia}");
    }
}
