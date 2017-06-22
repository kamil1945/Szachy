using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1.Figury
{
    class Szachownica //2.3
    {
        Pozycja[,] ListaPos = new Pozycja[8, 8];
        Figura[] ListaFig = new Figura[32];
        public Szachownica()
        {
            for (int i = 0; i < 32; i++)
                ListaFig = null;
        }
        public void DodajPozycje(Pozycja p)
        {
            ListaPos[p.X, p.X] = p;
        }
        public void UsunPozycje(Pozycja p)
        {
            ListaPos[p.X, p.X] = null;
        }
        public void DodajFigure(Figura f)
        {
            for (int i = 0; i < 32; i++)
                if (ListaFig[i] == null)
                {
                    ListaFig[i] = f;
                    break;
                }
        }
        public void UsunFigure(Figura f)
        {
            for (int i = 0; i < 32; i++)
                if (ListaFig[i] == f)
                {
                    ListaFig[i] = null;
                    break;
                }
        }
        public int IleFigur()//Prawie jak enumerable XD - przez przypadek zrobilem 3.3 zanim je przeczytalem
        {
            int counter = 0;
            for (int i = 0; i < 32; i++)
                if (ListaFig[i] != null)
                    counter++;
            return counter;
        }

    }
}
