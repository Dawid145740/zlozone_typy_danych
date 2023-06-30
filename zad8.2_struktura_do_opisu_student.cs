using System;

public class Program
{
    public struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int NumerIndeksu;
    }

    public struct Przedmiot
    {
        public string Nazwa;
        public string Kod;
        public int ECTS;
    }

    public struct NauczycielAkademicki
    {
        public string Imie;
        public string Nazwisko;
        public string TytulNaukowy;
    }

    public static void Main(string[] args)
    {
        Student student;
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NumerIndeksu = 12345;

        Przedmiot przedmiot;
        przedmiot.Nazwa = "Programowanie";
        przedmiot.Kod = "INF101";
        przedmiot.ECTS = 5;

        NauczycielAkademicki nauczyciel;
        nauczyciel.Imie = "Anna";
        nauczyciel.Nazwisko = "Nowak";
        nauczyciel.TytulNaukowy = "dr";

        Console.WriteLine("Informacje o studencie:");
        Console.WriteLine($"Imię: {student.Imie}");
        Console.WriteLine($"Nazwisko: {student.Nazwisko}");
        Console.WriteLine($"Numer indeksu: {student.NumerIndeksu}");

        Console.WriteLine("\nInformacje o przedmiocie:");
        Console.WriteLine($"Nazwa: {przedmiot.Nazwa}");
        Console.WriteLine($"Kod: {przedmiot.Kod}");
        Console.WriteLine($"ECTS: {przedmiot.ECTS}");

        Console.WriteLine("\nInformacje o nauczycielu akademickim:");
        Console.WriteLine($"Imię: {nauczyciel.Imie}");
        Console.WriteLine($"Nazwisko: {nauczyciel.Nazwisko}");
        Console.WriteLine($"Tytuł naukowy: {nauczyciel.TytulNaukowy}");
    }
}
