
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Xml.Linq;
public class Menu
{
    public void ShowMainMenu()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("=== MENU GŁÓWNE ===");
            Console.WriteLine("1. Rozpocznij Grę");
            Console.WriteLine("2. O Grze");
            Console.WriteLine("3. Wyjście");
            Console.Write("Wybierz opcję: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    ShowAbout();
                    break;
                case "3":
                    isRunning = false;
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór. Naciśnij dowolny klawisz, aby spróbować ponownie.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void StartGame()
    {
        Console.Clear();
        Console.WriteLine("=== TRYB GRY ===");
        Console.WriteLine("1. Gra z komputerem");
        Console.WriteLine("2. Gra z drugim graczem");
        Console.Write("Wybierz tryb: ");

        string gameMode = Console.ReadLine();

        switch (gameMode)
        {
            case "1":
                Console.WriteLine("Rozpoczynasz grę z komputerem...");
                // Tutaj dodaj logikę gry z komputerem
                break;
            case "2":
                
                Console.WriteLine("Rozpoczynasz grę z drugim graczem...");
                Thread.Sleep(1000);
                Dodawanie();
                break;
            default:
                Console.WriteLine("Niepoprawny wybór. Naciśnij dowolny klawisz, aby spróbować ponownie.");
                Console.ReadKey();
                break;
        }
       
    }
    private void Dodawanie()
    {
        Console.Clear();
        Console.WriteLine("Wybierz z listy 1");
        Console.WriteLine("wprowadź gracza 2");
        string gameMode2 = Console.ReadLine();

        switch (gameMode2)
        {
            case "1":
                Console.WriteLine("wybierz graczy z listy");

                break;
            case "2":
                Console.WriteLine("wprowadz dane gracza");
                Thread.Sleep(1000);
                ZarządzeniePiłkarzami zarzadzenie = new ZarządzeniePiłkarzami();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Dodaj piłkarza {i + 1}:");
                    zarzadzenie.DodajPiłkarza();
                };

                break;
        }

    }

    private void ShowAbout()
    {
        Console.Clear();
        Console.WriteLine("=== GRA WZOROWANA NA POPULARNEJ GRZE FIFA ULTIMATE TEAM W WERSJI COMANDLINE ===");
        Console.WriteLine("Grę stworzyli uczniowie klasy 5a technikum komunikacji jako projekt pracowni programowania");
        Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu.");
        Console.ReadKey();
    }
}
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
}
public class ZarządzeniePiłkarzami
{
    private Piłkarz[] pilkarze;
    private int count;

    public ZarządzeniePiłkarzami()
    {
        pilkarze = new Piłkarz[5];
        count = 0;
    }

    public void DodajPiłkarza()
    {
        if (count >= pilkarze.Length)
        {
            Console.WriteLine("Nie można dodać więcej piłkarzy, tablica jest pełna.");
            return;
        }

        Console.WriteLine("Podaj imię piłkarza:");
        string imie = Console.ReadLine();

        Console.WriteLine("Podaj nazwisko piłkarza:");
        string nazwisko = Console.ReadLine();

        Console.WriteLine("Podaj klub piłkarza:");
        string klub = Console.ReadLine();

        Console.WriteLine("Podaj narodowość piłkarza:");
        string narodowosc = Console.ReadLine();

        int wiek = 0;
        while (true)
        {
            Console.WriteLine("Podaj wiek piłkarza:");
            if (int.TryParse(Console.ReadLine(), out wiek) && wiek > 0)
                break;
            else
                Console.WriteLine("Niepoprawny wiek. Proszę podać liczbę całkowitą większą od 0.");
        }

        int strzelanie = 0;
        while (true)
        {
            Console.WriteLine("Podaj ocenę strzelania (0-100):");
            if (int.TryParse(Console.ReadLine(), out strzelanie) && strzelanie >= 0 && strzelanie <= 100)
                break;
            else
                Console.WriteLine("Niepoprawna ocena strzelania. Proszę podać liczbę całkowitą w zakresie 0-100.");
        }

        int podania = 0;
        while (true)
        {
            Console.WriteLine("Podaj ocenę podań (0-100):");
            if (int.TryParse(Console.ReadLine(), out podania) && podania >= 0 && podania <= 100)
                break;
            else
                Console.WriteLine("Niepoprawna ocena podań. Proszę podać liczbę całkowitą w zakresie 0-100.");
        }

        int obrona = 0;
        while (true)
        {
            Console.WriteLine("Podaj ocenę obrony (0-100):");
            if (int.TryParse(Console.ReadLine(), out obrona) && obrona >= 0 && obrona <= 100)
                break;
            else
                Console.WriteLine("Niepoprawna ocena obrony. Proszę podać liczbę całkowitą w zakresie 0-100.");
        }

        int tempo = 0;
        while (true)
        {
            Console.WriteLine("Podaj ocenę tempa (0-100):");
            if (int.TryParse(Console.ReadLine(), out tempo) && tempo >= 0 && tempo <= 100)
                break;
            else
                Console.WriteLine("Niepoprawna ocena tempa. Proszę podać liczbę całkowitą w zakresie 0-100.");
        }

        Piłkarz nowyPilkarz = new Piłkarz(imie, nazwisko, klub, narodowosc, wiek, strzelanie, podania, obrona, tempo);
        pilkarze[count] = nowyPilkarz;
        count++;
        Console.WriteLine("Piłkarz dodany pomyślnie!\n");
    }
    public void PokażPiłkarzy()
    {
        Console.WriteLine("Lista piłkarzy:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(pilkarze[i]);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.ShowMainMenu();

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

       

    }
}
