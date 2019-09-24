using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanulokFeladat.Tarolo;

namespace TanulokFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanulok t = new Tanulok();
            t.beolvas();
            Console.WriteLine("1. feladat");
            Console.WriteLine("Jegyek száma: " + t.getJegyekSzama()+" db");
            Console.WriteLine("2. feladat");
            Console.WriteLine("Adja meg a jegy sorszámát:");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            t.megjelenitJegyet(sorszam-1);
            Console.WriteLine("3. feladat");
            Console.WriteLine("Ötösök száma:" + t.getOtosTanulokSzama());
            Console.ReadKey();
        }
    }
}
