using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;
using tema_liste.classes;
using tema_liste.Comparatori;

namespace tema_liste.controllers
{
    public class ControllerElevi
    {
        private Lista elevi;

        public ControllerElevi()
        {
            elevi = new Lista(typeof(Elev));

            CitireNew();
        }

        public void Citire()
        {
            StreamReader read = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"db\database.txt");

            String line = "";

            while ((line = read.ReadLine()) != null)
            {
                elevi.addSfarsit(new Elev(line.Split(',')[0], line.Split(',')[1], int.Parse(line.Split(',')[2]),
                        int.Parse(line.Split(',')[3])));
                
            }
        }

        public void CitireNew()
        {
            StreamReader read = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"db\database.txt");

            String line = "";

            while ((line = read.ReadLine()) != null)
            {
                elevi.addSfarsit(new Elev(int.Parse(line.Split(',')[0]), int.Parse(line.Split(',')[1]),
                    line.Split(',')[2], line.Split(',')[3]));
            }
        }

        public void Afisare()
        {
            elevi.afisare();
        }

        public void AfisareNume()
        {
            for (int i = 0; i < elevi.GetSize(); i++)
            {
                Elev elev = elevi.GetNode(i).Data as Elev;

                Console.WriteLine(elev.FullName);
            }
        }

        public int GetMedieClasa()
        {
            int sum = 0;

            for (int i = 0; i < elevi.GetSize(); i++)
            {
                Elev elev = elevi.GetNode(i).Data as Elev;

                sum += elev.MedieInfo;
            }

            return sum / elevi.GetSize();
        } // ex1

        public int MaxMedieSem()
        {
            int max = -1;

            for (int i = 0; i < elevi.GetSize(); i++)
            {
                Elev elev = elevi.GetNode(i).Data as Elev;

                if (elev.MedieSemestriala > max)
                {
                    max = elev.Teza;
                }
            }

            return max;
        } // ex1

        public String EleviMaxMedieSem()
        {
            String text = "";

            for (int i = 0; i < elevi.GetSize(); i++)
            {
                Elev elev = elevi.GetNode(i).Data as Elev;

                if (elev.MedieSemestriala.Equals(MaxMedieSem()))
                {
                    text += elev.ToString();
                }
            }

            return text;
        } // ex1

        public void SortCresc(Comparer<Elev> comparer)
        {
            elevi.sortCresc(comparer);
        }

        public void SortDescresc(Comparer<Elev> comparer)
        {
            elevi.sortDescresc(comparer);
        } // ex2

        public String GetCorigenti()
        {
            String text = "";

            for (int i = 0; i < elevi.GetSize(); i++)
            {
                Elev elev = elevi.GetNode(i).Data as Elev;

                if (elev.MedieSemestriala < 5)
                {
                    text += elev.ToString();
                }
            }

            return text;
        } // ex3

        // functie ce sterge elevii care au dreptul la bursa
        public void StergeElevi(int L)
        {
            for (int i = 0; i < elevi.GetSize(); i++)
            {
                Elev elev = elevi.GetNode(i).Data as Elev;

                if (elev.VenitLunar / elev.MembriiFamilie > L)
                {
                    elevi.removePoz(i);
                    i--;
                }
            }
        }

        // fct ce afiseaza elevii care nu au dreptul la bursa in ordine crescatoare
        public void AfisareElevi(int L)
        {
            StergeElevi(L);

            elevi.sortCresc(new ComparatorElevNume());
            Afisare();
        }


    }
}