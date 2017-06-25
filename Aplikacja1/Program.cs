using Aplikacja1.Figury;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fab Fabryka = new Fab();
            List<Figura> figury = new List<Figura>();
            //Wszystkie pozycje nalezy wczesniej zdefiniowac
            Pozycja p = new Pozycja("B5");
            Pozycja p2 = new Pozycja("D4");
            //4.2
            figury.Add(Fabryka.nowa("Goniec", p, Kolor.KOLOR_BIALY));
            figury.Add(Fabryka.nowa("Pionek", p2, Kolor.KOLOR_CZARNY));
            /*2.2
            Figura f = new Pionek(p,Kolor.KOLOR_BIALY);
            Console.WriteLine(f.CzyMoznaPrzesunac(p2));
            Pionek pp = new Pionek(p, Kolor.KOLOR_BIALY);
            pp.JakasMetoda();
            Figura ff = pp;
            ff.JakasMetoda();
            */
            Console.ReadKey();//Zeby nie gaslo instant

        }
    }
}
