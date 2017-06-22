using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1.Figury
{
    delegate void Delegat(string s);
    class Figura
    {
        Delegat x = null;//3.2
        public Pozycja pozycja = null; //2.1
        public Pozycja Pozycja
        {
            get
            {
                return pozycja;
            }
        }

        public string kolor;

        protected bool CzyPionowo(Pozycja nowaPozycja)
        {
            return Pozycja.Y == nowaPozycja.Y;
        }

        protected bool CzyPoziomo(Pozycja nowaPozycja)
        {
            return Pozycja.X == nowaPozycja.X;
        }

        protected bool CzySkos(Pozycja nowaPozycja)
        {
            return Math.Abs(Pozycja.Y - nowaPozycja.Y) == Math.Abs(Pozycja.X - nowaPozycja.X);
        }

        public virtual bool CzyMoznaPrzesunac(Pozycja nowaPozycja)
        {
            return CzyPionowo(nowaPozycja) || CzyPoziomo(nowaPozycja) || CzySkos(nowaPozycja);
        }

        public Figura(Pozycja pozycja, string kolor)
        {
            Delegat x = new Delegat(ZmianaPozycji);
            this.pozycja = pozycja;
            this.kolor = kolor;
        }
        public virtual void JakasMetoda()
        {
            Console.WriteLine("Tekst Figury");
        }
        protected virtual void Przesun(Pozycja p) // 3.1
        {
            if(p!=this.pozycja)
                if(CzyMoznaPrzesunac(p))
                {
                    this.pozycja = p;
                    Console.WriteLine("Przesunieto figure");
                    x(p.Pole);//3.2
                }
        }
        protected static void ZmianaPozycji(string s)//3.2
        {
            Console.WriteLine("  Zmiana pozycji, {0}!", s);
        }
    }
}
