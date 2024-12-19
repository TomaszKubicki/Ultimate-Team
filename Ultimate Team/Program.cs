
using System;
using System.ComponentModel.Design;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static Menu;

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
    Menu:
        Console.Clear();
        Console.WriteLine("=== TRYB GRY ===");
        Console.WriteLine("1. Gra z komputerem");
        Console.WriteLine("2. Gra z drugim graczem");
        Console.Write("Wybierz tryb: ");

        string gameMode = Console.ReadLine();

        switch (gameMode)
        {
            case "1":
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("=== USTAWIENIA ===");
                    Console.WriteLine("1. Podaje sam graczy");
                    Console.WriteLine("2. Wybieram z listy");
                    Console.WriteLine("3. Zmień tryb gry");
                    Console.Write("Wybierz opcję: ");
                    string trybGry = Console.ReadLine();

                    if (trybGry == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Rozpoczynasz grę z komputerem...");
                        Console.WriteLine();
                        Piłkarz[] pilkarzerand = new Piłkarz[]
                        {
                    new Piłkarz("Lionel", "Messi", "Paris Saint-Germain", "Argentyna", 37, 92, 94, 70, 85),
                    new Piłkarz("Cristiano", "Ronaldo", "Al Nassr", "Portugalia", 39, 91, 89, 72, 83),
                    new Piłkarz("Kylian", "Mbappé", "Paris Saint-Germain", "Francja", 25, 93, 88, 65, 96),
                    new Piłkarz("Erling", "Haaland", "Manchester City", "Norwegia", 24, 92, 80, 75, 90),
                    new Piłkarz("Kevin", "De Bruyne", "Manchester City", "Belgia", 33, 85, 95, 60, 85),
                    new Piłkarz("Robert", "Lewandowski", "FC Barcelona", "Polska", 36, 91, 85, 70, 75),
                    new Piłkarz("Neymar", "Jr", "Al Hilal", "Brazylia", 32, 87, 88, 58, 90),
                    new Piłkarz("Luka", "Modrić", "Real Madryt", "Chorwacja", 38, 78, 92, 60, 80),
                    new Piłkarz("Vinícius", "Jr", "Real Madryt", "Brazylia", 24, 85, 82, 60, 95),
                    new Piłkarz("Sadio", "Mané", "Al Nassr", "Senegal", 32, 88, 85, 75, 92),
                    new Piłkarz("Harry", "Kane", "Bayern Monachium", "Anglia", 31, 90, 82, 68, 75),
                    new Piłkarz("Mohamed", "Salah", "Liverpool", "Egipt", 31, 90, 85, 60, 89),
                    new Piłkarz("Joshua", "Kimmich", "Bayern Monachium", "Niemcy", 29, 75, 90, 85, 80),
                    new Piłkarz("Marco", "Reus", "Borussia Dortmund", "Niemcy", 35, 82, 88, 70, 82),
                    new Piłkarz("Leroy", "Sané", "Bayern Monachium", "Niemcy", 28, 85, 80, 70, 90),
                    new Piłkarz("Gerard", "Piqué", "FC Barcelona", "Hiszpania", 37, 60, 70, 90, 60),
                    new Piłkarz("Thibaut", "Courtois", "Real Madryt", "Belgia", 32, 35, 50, 95, 60),
                    new Piłkarz("Jan", "Oblak", "Atlético Madryt", "Słowenia", 31, 30, 45, 95, 58),
                    new Piłkarz("Marc-André", "ter Stegen", "FC Barcelona", "Niemcy", 32, 25, 50, 94, 60),
                    new Piłkarz("Kalidou", "Koulibaly", "Al Hilal", "Senegal", 33, 70, 75, 90, 70),
                    new Piłkarz("Raphaël", "Varane", "Manchester United", "Francja", 31, 70, 75, 85, 75),
                    new Piłkarz("Virgil", "van Dijk", "Liverpool", "Holandia", 33, 75, 70, 90, 72),
                    new Piłkarz("Aymeric", "Laporte", "Al Nassr", "Hiszpania", 30, 75, 80, 85, 73),
                    new Piłkarz("Frenkie", "de Jong", "FC Barcelona", "Holandia", 27, 75, 90, 60, 85),
                    new Piłkarz("Jude", "Bellingham", "Real Madryt", "Anglia", 20, 80, 85, 70, 88),
                    new Piłkarz("Bukayo", "Saka", "Arsenal", "Anglia", 22, 85, 82, 65, 89),
                    new Piłkarz("Martin", "Ødegaard", "Arsenal", "Norwegia", 25, 80, 90, 65, 85),
                    new Piłkarz("Phil", "Foden", "Manchester City", "Anglia", 24, 85, 87, 60, 88),
                    new Piłkarz("Mason", "Mount", "Manchester United", "Anglia", 25, 75, 85, 60, 80),
                    new Piłkarz("Declan", "Rice", "Arsenal", "Anglia", 25, 70, 80, 85, 75),
                    new Piłkarz("Casemiro", "Casemiro", "Manchester United", "Brazylia", 32, 75, 80, 90, 72),
                    new Piłkarz("Rodri", "Rodrigo Hernández", "Manchester City", "Hiszpania", 27, 75, 82, 85, 80),
                    new Piłkarz("Jadon", "Sancho", "Manchester United", "Anglia", 24, 80, 85, 65, 87),
                    new Piłkarz("Antoine", "Griezmann", "Atlético Madryt", "Francja", 33, 80, 85, 60, 88),
                    new Piłkarz("João", "Félix", "Chelsea", "Portugalia", 24, 84, 87, 55, 90),
                    new Piłkarz("Ansu", "Fati", "FC Barcelona", "Hiszpania", 21, 82, 80, 55, 91),
                    new Piłkarz("Ousmane", "Dembélé", "Paris Saint-Germain", "Francja", 27, 85, 87, 60, 92),
                    new Piłkarz("Gerard", "Moreno", "Villarreal", "Hiszpania", 32, 79, 81, 70, 85),
                    new Piłkarz("Raheem", "Sterling", "Chelsea", "Anglia", 29, 83, 85, 62, 90),
                    new Piłkarz("Dominik", "Szoboszlai", "Liverpool", "Węgry", 23, 80, 88, 65, 85),
                    new Piłkarz("Martin", "Braithwaite", "Espanyol", "Dania", 33, 75, 78, 65, 80),
                    new Piłkarz("Carlos", "Solér", "Paris Saint-Germain", "Hiszpania", 27, 78, 82, 60, 85),
                    new Piłkarz("Ben", "White", "Arsenal", "Anglia", 26, 70, 75, 80, 80),
                    new Piłkarz("Dani", "Carvajal", "Real Madryt", "Hiszpania", 32, 65, 75, 88, 75),
                    new Piłkarz("Serge", "Gnabry", "Bayern Monachium", "Niemcy", 28, 86, 80, 70, 88),
                    new Piłkarz("Ibrahima", "Konaté", "Liverpool", "Francja", 25, 75, 72, 88, 85),
                    new Piłkarz("David", "Alaba", "Real Madryt", "Austria", 32, 80, 80, 85, 75),
                    new Piłkarz("Mats", "Hummels", "Borussia Dortmund", "Niemcy", 35, 70, 65, 90, 60),
                    new Piłkarz("Julian", "Brandt", "Borussia Dortmund", "Niemcy", 27, 75, 81, 60, 84),
                    new Piłkarz("Kieran", "Trippier", "Newcastle United", "Anglia", 33, 60, 82, 85, 75),
                    new Piłkarz("Marcos", "Llorente", "Atlético Madryt", "Hiszpania", 29, 80, 78, 80, 82),
                    new Piłkarz("Rodrigo", "Bento", "Real Madryt", "Brazylia", 23, 77, 82, 65, 80),
                    new Piłkarz("César", "Azpilicueta", "Chelsea", "Hiszpania", 34, 65, 75, 85, 70),
                    new Piłkarz("André", "Onana", "Manchester United", "Kamerun", 28, 30, 50, 90, 60),
                    new Piłkarz("Benjamin", "Pavard", "Bayern Monachium", "Francja", 28, 72, 75, 85, 80),
                    new Piłkarz("Nicolas", "Otamendi", "Benfica", "Argentyna", 36, 70, 65, 90, 70),
                    new Piłkarz("Toni", "Kroos", "Real Madryt", "Niemcy", 34, 75, 92, 60, 70),
                    new Piłkarz("Riyad", "Mahrez", "Al Ahli", "Algieria", 33, 85, 80, 60, 85),
                    new Piłkarz("Mauro", "Icardi", "Galatasaray", "Argentyna", 31, 85, 78, 60, 75),
                    new Piłkarz("Jules", "Koundé", "FC Barcelona", "Francja", 25, 70, 75, 85, 82),
                    new Piłkarz("Aaron", "Wan-Bissaka", "Manchester United", "Anglia", 26, 60, 65, 85, 80),
                    new Piłkarz("Nuno", "Tavares", "Olympique Marsylia", "Portugalia", 23, 65, 70, 75, 87),
                    new Piłkarz("Marquinhos", "Marquinhos", "Paris Saint-Germain", "Brazylia", 29, 70, 75, 88, 80),
                    new Piłkarz("Kalvin", "Phillips", "Manchester City", "Anglia", 28, 70, 75, 80, 75),
                    new Piłkarz("Dani", "Olmo", "RB Leipzig", "Hiszpania", 25, 78, 85, 55, 85),
                    new Piłkarz("Hugo", "Lloris", "Tottenham Hotspur", "Francja", 37, 30, 40, 92, 65),
                    new Piłkarz("Yassine", "Bounou", "Sevilla", "Maroko", 33, 30, 45, 90, 70),
                    new Piłkarz("Sergio", "Ramos", "Al Hilal", "Hiszpania", 37, 65, 70, 90, 75),
                    new Piłkarz("Milan", "Škriniar", "Paris Saint-Germain", "Słowacja", 29, 70, 70, 88, 78),
                    new Piłkarz("Gareth", "Bale", "Los Angeles FC", "Walia", 35, 80, 75, 55, 85),
                    new Piłkarz("Christian", "Pulisic", "AC Milan", "USA", 25, 80, 85, 60, 86),
                    new Piłkarz("Ciro", "Immobile", "Lazio", "Włochy", 34, 89, 75, 55, 75),
                    new Piłkarz("Pierre-Emerick", "Aubameyang", "Chelsea", "Gabon", 34, 85, 75, 60, 85),
                    new Piłkarz("Alexandre", "Lacazette", "Lyon", "Francja", 33, 84, 72, 55, 80),
                    new Piłkarz("Wilfried", "Zaha", "Galatasaray", "Wybrzeże Kości Słoniowej", 31, 82, 78, 65, 87),
                    new Piłkarz("Timo", "Werner", "RB Leipzig", "Niemcy", 28, 83, 70, 60, 90),
                    new Piłkarz("Theo", "Hernández", "AC Milan", "Francja", 26, 80, 75, 70, 92),
                    new Piłkarz("Marcos", "Acuña", "Sevilla", "Argentyna", 32, 75, 80, 78, 82),
                    new Piłkarz("Nabil", "Fekir", "Real Betis", "Francja", 30, 78, 85, 60, 85),
                    new Piłkarz("Fikayo", "Tomori", "AC Milan", "Anglia", 26, 70, 75, 85, 82),
                    new Piłkarz("Sergi", "Roberto", "FC Barcelona", "Hiszpania", 32, 70, 80, 75, 80),
                    new Piłkarz("David", "Silva", "Real Sociedad", "Hiszpania", 38, 75, 90, 60, 70),
                    new Piłkarz("Michaël", "Cuisance", "Marseille", "Francja", 24, 75, 78, 60, 85),
                    new Piłkarz("Héctor", "Bellerín", "Real Betis", "Hiszpania", 29, 70, 75, 75, 90),
                    new Piłkarz("Youssef", "En-Nesyri", "Sevilla", "Maroko", 27, 82, 75, 65, 84),
                    new Piłkarz("David", "Clarke", "Aston Villa", "Anglia", 30, 70, 78, 65, 80)
                        };
                        int[] wyniki = new int[5];

                        Random random = new Random();
                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine("Runda: " + i);
                            Console.WriteLine();
                            int losowaLiczba = random.Next(0, pilkarzerand.Length);
                            Console.WriteLine($"Wylosowana numer piłkarza: {losowaLiczba}");
                            Console.WriteLine($"Imię: {pilkarzerand[losowaLiczba].Imie}");
                            Console.WriteLine($"Nazwisko: {pilkarzerand[losowaLiczba].Nazwisko}");
                            Console.WriteLine($"Klub: {pilkarzerand[losowaLiczba].Klub}");
                            Console.WriteLine($"Narodowość: {pilkarzerand[losowaLiczba].Narodowosc}");
                            Console.WriteLine($"Wiek: {pilkarzerand[losowaLiczba].Wiek}");
                            Console.WriteLine($"Strzelanie: {pilkarzerand[losowaLiczba].Strzelanie}");
                            Console.WriteLine($"Podania: {pilkarzerand[losowaLiczba].Podania}");
                            Console.WriteLine($"Obrona: {pilkarzerand[losowaLiczba].Obrona}");
                            Console.WriteLine($"Tempo: {pilkarzerand[losowaLiczba].Tempo}");
                            double ocena = (pilkarzerand[losowaLiczba].Podania + pilkarzerand[losowaLiczba].Obrona + pilkarzerand[losowaLiczba].Tempo + pilkarzerand[losowaLiczba].Strzelanie) / 4;
                            Console.WriteLine("Ocena tego piłkarza to: " + ocena);
                            Console.WriteLine();
                            Console.WriteLine("Podaj swojego piłkarza!!!");
                            string imie = Dane("Podaj imię piłkarza:");

                            string nazwisko = Dane("Podaj nazwisko piłkarza:");

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
                            double ocena1 = (podania + tempo + obrona + strzelanie) / 4;
                            Console.WriteLine();
                            if (ocena > ocena1)
                            {
                                wyniki[i - 1] = 0;
                            }
                            else
                            {
                                wyniki[i - 1] = 1;
                            }
                            Thread.Sleep(500);
                            Console.WriteLine();
                        }
                        int score = 0;
                        foreach (int i in wyniki)
                        {
                            score += i;

                        }
                        if (score > 3)
                        {
                            Console.WriteLine("Wygrałeś tą rozgrywkę!!!");
                            Console.WriteLine("Wynik: " + score + "-" + (5 - score));

                        }
                        else
                        {
                            Console.WriteLine("Przegrałeś z komuterem");
                            Console.WriteLine("Wynik: " + score + "-" + (5 - score));
                        }
                    }

                    else if (trybGry == "2")
                    {

                        Drużyna druzyna = new Drużyna();
                        Console.Clear();
                        Console.WriteLine("Lista wszystkich piłkarzy:");
                        for (int i = 0; i < druzyna.Pilkarze.Length; i++)
                        {
                            Piłkarz wybranyPilkarz = druzyna.Pilkarze[i];
                            Console.Write(i + ". ");
                            Console.WriteLine(wybranyPilkarz);
                        }
                        int[] wyniki = new int[5];
                        for (int j = 1; j <= 5; j++)
                        {
                            int index = -1;
                            bool validIndex = false;

                            while (!validIndex)
                            {
                                Console.WriteLine("Podaj indeks piłkarza (0 - " + (druzyna.Pilkarze.Length - 1) + "):");

                                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < druzyna.Pilkarze.Length)
                                {
                                    validIndex = true;
                                }
                                else
                                {
                                    Console.WriteLine("Nieprawidłowy indeks. Proszę spróbować ponownie.");
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("Wybrałeś: ");
                            Piłkarz wybranyPilkarz = druzyna.Pilkarze[index];
                            Console.WriteLine(wybranyPilkarz);

                            Random random = new Random();
                            int losowaLiczba = random.Next(0, druzyna.Pilkarze.Length);
                            Console.WriteLine("Komputer wylosował: ");
                            Piłkarz wybranyPilkarz1 = druzyna.Pilkarze[losowaLiczba];
                            Console.WriteLine(wybranyPilkarz1);

                            double ovrl = (wybranyPilkarz.Strzelanie + wybranyPilkarz.Obrona + wybranyPilkarz.Podania + wybranyPilkarz.Tempo) / 4;
                            double ovrl1 = (wybranyPilkarz1.Strzelanie + wybranyPilkarz1.Obrona + wybranyPilkarz1.Podania + wybranyPilkarz1.Tempo) / 4;

                            if (ovrl1 > ovrl)
                            {
                                wyniki[j - 1] = 0;
                            }
                            else
                            {
                                wyniki[j - 1] = 1;
                            }
                        }

                        int score = 0;
                        foreach (int i in wyniki)
                        {
                            score += i;

                        }
                        if (score > 3)
                        {
                            Console.WriteLine("Wygrałeś tą rozgrywkę!!!");
                            Console.WriteLine("Wynik: " + score + "-" + (5 - score));

                        }
                        else
                        {
                            Console.WriteLine("Przegrałeś z komuterem");
                            Console.WriteLine("Wynik: " + score + "-" + (5 - score));
                        }
                        break;

                    }
                    else if (trybGry == "3")
                    {
                        goto Menu;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Niepoprawny wybór. Naciśnij dowolny klawisz, aby spróbować ponownie.");
                    }
                }
                Thread.Sleep(10000);
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

    static string Dane(string prompt)
    {
        string input;
        while (true)
        {
            Console.WriteLine(prompt);
            input = Console.ReadLine();
            if (IsValidName(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Wprowadź poprawne dane (tylko litery).");
            }
        }
    }

    static bool IsValidName(string input)
    {
        return Regex.IsMatch(input, @"^[a-zA-Z]+$");
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
public class Drużyna
{
    public Piłkarz[] Pilkarze { get; private set; }

    public Drużyna()
    {
        Pilkarze = new Piłkarz[]
        {
                    new Piłkarz("Lionel", "Messi", "Paris Saint-Germain", "Argentyna", 37, 92, 94, 70, 85),
                    new Piłkarz("Cristiano", "Ronaldo", "Al Nassr", "Portugalia", 39, 91, 89, 72, 83),
                    new Piłkarz("Kylian", "Mbappé", "Paris Saint-Germain", "Francja", 25, 93, 88, 65, 96),
                    new Piłkarz("Erling", "Haaland", "Manchester City", "Norwegia", 24, 92, 80, 75, 90),
                    new Piłkarz("Kevin", "De Bruyne", "Manchester City", "Belgia", 33, 85, 95, 60, 85),
                    new Piłkarz("Robert", "Lewandowski", "FC Barcelona", "Polska", 36, 91, 85, 70, 75),
                    new Piłkarz("Neymar", "Jr", "Al Hilal", "Brazylia", 32, 87, 88, 58, 90),
                    new Piłkarz("Luka", "Modrić", "Real Madryt", "Chorwacja", 38, 78, 92, 60, 80),
                    new Piłkarz("Vinícius", "Jr", "Real Madryt", "Brazylia", 24, 85, 82, 60, 95),
                    new Piłkarz("Sadio", "Mané", "Al Nassr", "Senegal", 32, 88, 85, 75, 92),
                    new Piłkarz("Harry", "Kane", "Bayern Monachium", "Anglia", 31, 90, 82, 68, 75),
                    new Piłkarz("Mohamed", "Salah", "Liverpool", "Egipt", 31, 90, 85, 60, 89),
                    new Piłkarz("Joshua", "Kimmich", "Bayern Monachium", "Niemcy", 29, 75, 90, 85, 80),
                    new Piłkarz("Marco", "Reus", "Borussia Dortmund", "Niemcy", 35, 82, 88, 70, 82),
                    new Piłkarz("Leroy", "Sané", "Bayern Monachium", "Niemcy", 28, 85, 80, 70, 90),
                    new Piłkarz("Gerard", "Piqué", "FC Barcelona", "Hiszpania", 37, 60, 70, 90, 60),
                    new Piłkarz("Thibaut", "Courtois", "Real Madryt", "Belgia", 32, 35, 50, 95, 60),
                    new Piłkarz("Jan", "Oblak", "Atlético Madryt", "Słowenia", 31, 30, 45, 95, 58),
                    new Piłkarz("Marc-André", "ter Stegen", "FC Barcelona", "Niemcy", 32, 25, 50, 94, 60),
                    new Piłkarz("Kalidou", "Koulibaly", "Al Hilal", "Senegal", 33, 70, 75, 90, 70),
                    new Piłkarz("Raphaël", "Varane", "Manchester United", "Francja", 31, 70, 75, 85, 75),
                    new Piłkarz("Virgil", "van Dijk", "Liverpool", "Holandia", 33, 75, 70, 90, 72),
                    new Piłkarz("Aymeric", "Laporte", "Al Nassr", "Hiszpania", 30, 75, 80, 85, 73),
                    new Piłkarz("Frenkie", "de Jong", "FC Barcelona", "Holandia", 27, 75, 90, 60, 85),
                    new Piłkarz("Jude", "Bellingham", "Real Madryt", "Anglia", 20, 80, 85, 70, 88),
                    new Piłkarz("Bukayo", "Saka", "Arsenal", "Anglia", 22, 85, 82, 65, 89),
                    new Piłkarz("Martin", "Ødegaard", "Arsenal", "Norwegia", 25, 80, 90, 65, 85),
                    new Piłkarz("Phil", "Foden", "Manchester City", "Anglia", 24, 85, 87, 60, 88),
                    new Piłkarz("Mason", "Mount", "Manchester United", "Anglia", 25, 75, 85, 60, 80),
                    new Piłkarz("Declan", "Rice", "Arsenal", "Anglia", 25, 70, 80, 85, 75),
                    new Piłkarz("Casemiro", "Casemiro", "Manchester United", "Brazylia", 32, 75, 80, 90, 72),
                    new Piłkarz("Rodri", "Rodrigo Hernández", "Manchester City", "Hiszpania", 27, 75, 82, 85, 80),
                    new Piłkarz("Jadon", "Sancho", "Manchester United", "Anglia", 24, 80, 85, 65, 87),
                    new Piłkarz("Antoine", "Griezmann", "Atlético Madryt", "Francja", 33, 80, 85, 60, 88),
                    new Piłkarz("João", "Félix", "Chelsea", "Portugalia", 24, 84, 87, 55, 90),
                    new Piłkarz("Ansu", "Fati", "FC Barcelona", "Hiszpania", 21, 82, 80, 55, 91),
                    new Piłkarz("Ousmane", "Dembélé", "Paris Saint-Germain", "Francja", 27, 85, 87, 60, 92),
                    new Piłkarz("Gerard", "Moreno", "Villarreal", "Hiszpania", 32, 79, 81, 70, 85),
                    new Piłkarz("Raheem", "Sterling", "Chelsea", "Anglia", 29, 83, 85, 62, 90),
                    new Piłkarz("Dominik", "Szoboszlai", "Liverpool", "Węgry", 23, 80, 88, 65, 85),
                    new Piłkarz("Martin", "Braithwaite", "Espanyol", "Dania", 33, 75, 78, 65, 80),
                    new Piłkarz("Carlos", "Solér", "Paris Saint-Germain", "Hiszpania", 27, 78, 82, 60, 85),
                    new Piłkarz("Ben", "White", "Arsenal", "Anglia", 26, 70, 75, 80, 80),
                    new Piłkarz("Dani", "Carvajal", "Real Madryt", "Hiszpania", 32, 65, 75, 88, 75),
                    new Piłkarz("Serge", "Gnabry", "Bayern Monachium", "Niemcy", 28, 86, 80, 70, 88),
                    new Piłkarz("Ibrahima", "Konaté", "Liverpool", "Francja", 25, 75, 72, 88, 85),
                    new Piłkarz("David", "Alaba", "Real Madryt", "Austria", 32, 80, 80, 85, 75),
                    new Piłkarz("Mats", "Hummels", "Borussia Dortmund", "Niemcy", 35, 70, 65, 90, 60),
                    new Piłkarz("Julian", "Brandt", "Borussia Dortmund", "Niemcy", 27, 75, 81, 60, 84),
                    new Piłkarz("Kieran", "Trippier", "Newcastle United", "Anglia", 33, 60, 82, 85, 75),
                    new Piłkarz("Marcos", "Llorente", "Atlético Madryt", "Hiszpania", 29, 80, 78, 80, 82),
                    new Piłkarz("Rodrigo", "Bento", "Real Madryt", "Brazylia", 23, 77, 82, 65, 80),
                    new Piłkarz("César", "Azpilicueta", "Chelsea", "Hiszpania", 34, 65, 75, 85, 70),
                    new Piłkarz("André", "Onana", "Manchester United", "Kamerun", 28, 30, 50, 90, 60),
                    new Piłkarz("Benjamin", "Pavard", "Bayern Monachium", "Francja", 28, 72, 75, 85, 80),
                    new Piłkarz("Nicolas", "Otamendi", "Benfica", "Argentyna", 36, 70, 65, 90, 70),
                    new Piłkarz("Toni", "Kroos", "Real Madryt", "Niemcy", 34, 75, 92, 60, 70),
                    new Piłkarz("Riyad", "Mahrez", "Al Ahli", "Algieria", 33, 85, 80, 60, 85),
                    new Piłkarz("Mauro", "Icardi", "Galatasaray", "Argentyna", 31, 85, 78, 60, 75),
                    new Piłkarz("Jules", "Koundé", "FC Barcelona", "Francja", 25, 70, 75, 85, 82),
                    new Piłkarz("Aaron", "Wan-Bissaka", "Manchester United", "Anglia", 26, 60, 65, 85, 80),
                    new Piłkarz("Nuno", "Tavares", "Olympique Marsylia", "Portugalia", 23, 65, 70, 75, 87),
                    new Piłkarz("Marquinhos", "Marquinhos", "Paris Saint-Germain", "Brazylia", 29, 70, 75, 88, 80),
                    new Piłkarz("Kalvin", "Phillips", "Manchester City", "Anglia", 28, 70, 75, 80, 75),
                    new Piłkarz("Dani", "Olmo", "RB Leipzig", "Hiszpania", 25, 78, 85, 55, 85),
                    new Piłkarz("Hugo", "Lloris", "Tottenham Hotspur", "Francja", 37, 30, 40, 92, 65),
                    new Piłkarz("Yassine", "Bounou", "Sevilla", "Maroko", 33, 30, 45, 90, 70),
                    new Piłkarz("Sergio", "Ramos", "Al Hilal", "Hiszpania", 37, 65, 70, 90, 75),
                    new Piłkarz("Milan", "Škriniar", "Paris Saint-Germain", "Słowacja", 29, 70, 70, 88, 78),
                    new Piłkarz("Gareth", "Bale", "Los Angeles FC", "Walia", 35, 80, 75, 55, 85),
                    new Piłkarz("Christian", "Pulisic", "AC Milan", "USA", 25, 80, 85, 60, 86),
                    new Piłkarz("Ciro", "Immobile", "Lazio", "Włochy", 34, 89, 75, 55, 75),
                    new Piłkarz("Pierre-Emerick", "Aubameyang", "Chelsea", "Gabon", 34, 85, 75, 60, 85),
                    new Piłkarz("Alexandre", "Lacazette", "Lyon", "Francja", 33, 84, 72, 55, 80),
                    new Piłkarz("Wilfried", "Zaha", "Galatasaray", "Wybrzeże Kości Słoniowej", 31, 82, 78, 65, 87),
                    new Piłkarz("Timo", "Werner", "RB Leipzig", "Niemcy", 28, 83, 70, 60, 90),
                    new Piłkarz("Theo", "Hernández", "AC Milan", "Francja", 26, 80, 75, 70, 92),
                    new Piłkarz("Marcos", "Acuña", "Sevilla", "Argentyna", 32, 75, 80, 78, 82),
                    new Piłkarz("Nabil", "Fekir", "Real Betis", "Francja", 30, 78, 85, 60, 85),
                    new Piłkarz("Fikayo", "Tomori", "AC Milan", "Anglia", 26, 70, 75, 85, 82),
                    new Piłkarz("Sergi", "Roberto", "FC Barcelona", "Hiszpania", 32, 70, 80, 75, 80),
                    new Piłkarz("David", "Silva", "Real Sociedad", "Hiszpania", 38, 75, 90, 60, 70),
                    new Piłkarz("Michaël", "Cuisance", "Marseille", "Francja", 24, 75, 78, 60, 85),
                    new Piłkarz("Héctor", "Bellerín", "Real Betis", "Hiszpania", 29, 70, 75, 75, 90),
                    new Piłkarz("Youssef", "En-Nesyri", "Sevilla", "Maroko", 27, 82, 75, 65, 84),
                    new Piłkarz("David", "Clarke", "Aston Villa", "Anglia", 30, 70, 78, 65, 80)
        };
    }
}
public class Trener
{
    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    public string Narodowosc { get; private set; }
    public int Wiek { get; private set; }
    public string Liga { get; private set; }

    public Trener(string imie, string nazwisko, string narodowosc, int wiek, string liga)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Narodowosc = narodowosc;
        Wiek = wiek;
        Liga = liga;
    }

    public override string ToString()
    {
        return $"{Imie} {Nazwisko}, Narodowość: {Narodowosc}, Wiek: {Wiek}, Liga: {Liga}";
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
    public override string ToString()
    {
        return $"{Imie} {Nazwisko} {Klub} {Narodowosc} {Wiek} {Strzelanie} {Podania} {Tempo} {Obrona}";
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
    }
}