using System;
using System.IO;
using System.Net.Mime;
using tema_liste.classes;

namespace tema_liste.controllers
{
    public class ControllerFractii
    {
        private Lista fractii;

        public ControllerFractii()
        {
            fractii = new Lista(typeof(Fractie));

            Citire();
        }

        private void Citire()
        {
            StreamReader read = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"db\fractii.txt");

            String line = "";

            while ((line = read.ReadLine()) != null)
            {
                fractii.addSfarsit(new Fractie(int.Parse(line.Split('/')[0]), int.Parse(line.Split('/')[1])));
            }
        }

        public void Afisare()
        {
            for (int i = 0; i < fractii.GetSize(); i++)
            {
                Fractie fr= fractii.GetNode(i).Data as Fractie;

                Console.WriteLine(fr.ToString());
            }
        }

        private int cmmdc(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }

        public int FrEchivUlt()
        {
            int k = 0;

            for (int i = 0; i < fractii.GetSize() - 1; i++)
            {
                Fractie fr1 = fractii.GetNode(i).Data as Fractie;
                Fractie fr2 = fractii.GetNode(fractii.GetSize() - 1).Data as Fractie;

                int d1 = cmmdc(fr1.Numarator, fr1.Numitor), d2 = cmmdc(fr2.Numarator, fr2.Numitor);

                if (fr1.Numarator / d1 == fr2.Numarator / d2 && fr1.Numitor / d1 == fr2.Numitor / d2)
                {
                    k++;
                }
            }

            return k;
        }
    }
}