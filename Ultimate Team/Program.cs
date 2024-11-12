
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
    public PodajStatystyke(string Statysyka)
        {
        }
}
