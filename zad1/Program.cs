using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Samochod
    {
        public string marka;
        public static int liczbaKol=4;
        public int predkosc;
        public string kolor = "Czarny";
        int rocznik = 2016;

        public Samochod(string marka, int predkosc, string kolor, int rocznik)
        {
            this.marka = marka;
            this.predkosc = predkosc;
            this.kolor = kolor;
            this.rocznik = rocznik;
        }

        public Samochod(string marka, int predkosc)
        {
            this.marka = marka;
            this.predkosc = predkosc;
        }

        public void Jedz(int predkosc)
        {
            Console.WriteLine("Samochod jedzie z predkoscia " + predkosc + " km/h");
        }
        public void Hamuj()
        {
            Console.WriteLine("Samochod hamuje");
        }
        
    }
    
    class Program
    {
        public static List<Samochod> lista = new List<Samochod>();

        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod("Fiat", 300);
            samochod1.Jedz(100);
            samochod1.Hamuj();
            Samochod samochod2 = new Samochod("Opel", 230);
            samochod2.Jedz(200);
            samochod2.Hamuj();
            Samochod samochod3 = new Samochod("Skoda", 200);
            samochod3.Jedz(170);
            samochod3.Hamuj();

            lista.Add(samochod1);
            lista.Add(samochod2);
            lista.Add(samochod3);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("{0} samochód marki {1} jedzie z prędkością {2}", lista[i].kolor, lista[i].marka, lista[i].predkosc);
                Console.WriteLine("Domyślna ilość kół używanych jednocześnie w samochodzie to {0}", Samochod.liczbaKol);
            }
            Console.ReadLine();
        }

    }
}
