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
            Pozycja p = new Pozycja("B5");
            Pozycja p2 = new Pozycja("D4");
            //2.2
            Figura f = new Pionek(p,Kolor.KOLOR_BIALY);
            Console.WriteLine(f.CzyMoznaPrzesunac(p2));
            Pionek pp = new Pionek(p, Kolor.KOLOR_BIALY);
            pp.JakasMetoda();
            Figura ff = pp;
            ff.JakasMetoda();
            //2.2
            Console.ReadKey();//Zeby nie gaslo instant

        }
    }
}
