using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema_liste.classes;
using tema_liste.Comparatori;

namespace tema_liste.controllers
{
    class ControllerComplexe
    {
        private Lista list;

        public ControllerComplexe()
        {
            list = new Lista(typeof(Complex));
        }

        public void citire()
        {
            StreamReader read = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"db\complexe.txt");

            String line = "";

            while((line = read.ReadLine()) != null)
            {
                list.addSfarsit(new Complex(int.Parse(line.Split(',')[0]), int.Parse(line.Split(',')[1])));
            }

        }

        private void sterge(int a, int b)
        {
            for(int i = 0; i < list.GetSize(); i++)
            {
                Complex c = list.GetNode(i).Data as Complex;

                if(c.Modul >= a && c.Modul <= b)
                {
                    list.removePoz(i);
                    i--;
                }
            }
        }

        public void afisare(int a, int b)
        {
            sterge(a, b);

            list.SortCrescCompl(new ComparatorComplexeModul());
            list.afisare();
        }
    }
}
