using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanulokFeladat.model;

namespace TanulokFeladat.Tarolo
{
    class Tanulok
    {
        List<Tanulo> tanulok;

        public Tanulok()
        {
            tanulok = new List<Tanulo>();
        }

        public void beolvas()
        {
            StreamReader sr = new StreamReader("00tanulok.txt");
            while (!sr.EndOfStream)
            {
                string fajlsor = sr.ReadLine();
                Tanulo t = new Tanulo(fajlsor);
                tanulok.Add(t);
            }
        }

        public int getJegyekSzama()
        {
            return tanulok.Count;
        }

        public void megjelenitJegyet(int sorszam)
        {
            try
            {
                Console.WriteLine(tanulok.ElementAt(sorszam).ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Nincs ilyen sorszámú jegy");
            }
        }

        public int getOtosTanulokSzama()
        {
            return tanulok.Count(t => t.OtosE());
        }
    }
}
