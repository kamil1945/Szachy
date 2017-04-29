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
        static void Main(string[] args)//123
        {//
            Pozycja p = new Pozycja("B5");
            Pozycja p2 = new Pozycja("D4");
            Figura f = new Pionek(p,Kolor.KOLOR_BIALY);
            Console.WriteLine(f.CzyMoznaPrzesunac(p2));


        }
    }
}
