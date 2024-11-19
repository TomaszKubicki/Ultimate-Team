
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Xml.Linq;

public class Piłkarz
{
    public string Imie;
    public string Nazwisko;
    public string Klub;
    public string Narodowosc;
    public int Wiek;
    public int Strzelanie;
    public int Podania;
    public int Obrona;
    public int Tempo;

    public Piłkarz(string name, string naz, string club, string nation, int age, int shoot, int pass, int def, int pace)
    {
        Imie = name;
        Nazwisko = naz;
        Klub = club;
        Narodowosc = nation;
        Wiek = age;
        Strzelanie = shoot;
        Podania = pass;
        Tempo = pace;
        Obrona = def;
    }
    public int ovrl()
    {
        return ((Strzelanie + Podania + Obrona + Tempo) / 4);
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Piłkarz[] pilkarze = new Piłkarz[2];
            for(int i=0; i<2; i++)
            {
                Console.WriteLine("Podaj imię piłkarza:");
                string imie = Console.ReadLine();

                Console.WriteLine("Podaj nazwisko piłkarza:");
                string nazwisko = Console.ReadLine();

                Console.WriteLine("Podaj klub piłkarza:");
                string klub = Console.ReadLine();

                Console.WriteLine("Podaj narodowość piłkarza:");
                string narodowosc = Console.ReadLine();

                Console.WriteLine("Podaj wiek piłkarza:");
                int wiek = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj ocenę strzelania (0-100):");
                int strzelanie = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj ocenę podań (0-100):");
                int podania = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj ocenę obrony (0-100):");
                int obrona = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj ocenę tempa (0-100):");
                int tempo = int.Parse(Console.ReadLine());

                pilkarze[i] = new Piłkarz(imie, nazwisko, klub, narodowosc, wiek, strzelanie, podania, obrona, tempo);
                Console.WriteLine();
            }
            Piłkarz[] pilkarzerand = new Piłkarz[]
            {
            new Piłkarz("Mohamed", "Salah", "Liverpool", "Egipt", 31, 90, 85, 60, 89),
            new Piłkarz("Harry", "Kane", "Tottenham", "Anglia", 30, 88, 78, 70, 75),
            new Piłkarz("Kevin", "De Bruyne", "Manchester City", "Belgia", 32, 85, 92, 65, 70),
            new Piłkarz("N'Golo", "Kante", "Chelsea", "Francja", 32, 60, 75, 90, 80),
            new Piłkarz("Bruno", "Fernandes", "Manchester United", "Portugalia", 29, 80, 88, 60, 78),
            new Piłkarz("Son", "Heung-min", "Tottenham", "Korea Południowa", 31, 87, 80, 55, 90),
            new Piłkarz("Riyad", "Mahrez", "Manchester City", "Algieria", 32, 83, 75, 50, 85),
            new Piłkarz("Sadio", "Mane", "Al Nassr", "Senegal", 31, 86, 79, 60, 88),
            new Piłkarz("Virgil", "van Dijk", "Liverpool", "Holandia", 32, 60, 70, 90, 75),
            new Piłkarz("Alisson", "Becker", "Liverpool", "Brazylia", 31, 50, 55, 85, 70),
            new Piłkarz("Marcus", "Rashford", "Manchester United", "Anglia", 25, 82, 80, 50, 87),
            new Piłkarz("Jack", "Grealish", "Manchester City", "Anglia", 28, 75, 82, 55, 80),
            new Piłkarz("Raheem", "Sterling", "Chelsea", "Anglia", 29, 80, 78, 50, 90),
            new Piłkarz("Ruben", "Dias", "Manchester City", "Portugalia", 26, 65, 70, 85, 70),
            new Piłkarz("Ben", "Chilwell", "Chelsea", "Anglia", 26, 70, 75, 70, 80),
            new Piłkarz("Jadon", "Sancho", "Manchester United", "Anglia", 23, 78, 82, 50, 85),
            new Piłkarz("Thiago", "Alcantara", "Liverpool", "Hiszpania", 32, 75, 90, 55, 70),
            new Piłkarz("Ederson", "Moraes", "Manchester City", "Brazylia", 30, 55, 60, 80, 75),
            new Piłkarz("Cesar", "Azpilicueta", "Chelsea", "Hiszpania", 34, 60, 70, 85, 65),
            new Piłkarz("Harry", "Maguire", "Manchester United", "Anglia", 31, 55, 72, 87, 67),
            new Piłkarz("Crisitiano", "Ronaldo", "Al Nassr", "Portugalia", 39, 99, 97, 70, 85),
            new Piłkarz("Lionel", "Messi", "Inter Maiami", "Argentyna", 37, 80, 90, 15, 50),
            new Piłkarz("Sergio", "Ramos", "Brak klubu", "Hiszpania", 38, 50, 55, 90, 69),
            };

            for (int i = 0; i < 2; i++)
            {
                Piłkarz pilkarz = pilkarze[i];
                Console.WriteLine($"Piłkarz {i + 1}: {pilkarz.Imie} {pilkarz.Nazwisko}");
                Console.WriteLine($"Klub: {pilkarz.Klub}");
                Console.WriteLine($"Narodowość: {pilkarz.Narodowosc}");
                Console.WriteLine($"Wiek: {pilkarz.Wiek}");
                Console.WriteLine($"Ocena ogólna: {pilkarz.ovrl()}");
                Console.WriteLine();
            }
        }
    }

}
