using System;
using System.IO;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;
using tema_liste.classes;

namespace tema_liste.controllers
{
    public class ControllerSportivi
    {
        private Competitie competitie;
        private Lista sportivi;

        public int Count
        {
            get => this.competitie.NrSportivi;
        }

        public ControllerSportivi(Competitie competitie)
        {
            this.competitie = competitie;

            sportivi = new Lista(typeof(Sportiv));

            Citire();
        }

        public void Citire()
        {
            StreamReader read = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"db\database.txt");

            String line = "";

            for (int i = 0; i < competitie.NrSportivi; i++)
            {
                line = read.ReadLine();

                sportivi.addSfarsit(new Sportiv(line.Split(',')[0], int.Parse(line.Split(',')[1]), int.Parse(line.Split(',')[2])));
            }
        }

        public void Afisare()
        {
            for (int i = 0; i < sportivi.GetSize(); i++)
            {
                Console.WriteLine(sportivi.GetNode(i).Data.ToString());
            }
        }

        public int MedieVarsta()
        {
            int sum = 0;

            for (int i = 0; i < sportivi.GetSize(); i++)
            {
                Sportiv sportiv= sportivi.GetNode(i).Data as Sportiv;

                sum += sportiv.GetAge(competitie.An, competitie.Luna);
            }

            return sum / sportivi.GetSize();
        }


        // functie ce afiseaza sportivii cu varsta mai mica decat media
        public void AfisareSportivi()
        {
            for (int i = 0; i < sportivi.GetSize(); i++)
            {
                Sportiv s = sportivi.GetNode(i).Data as Sportiv;

                if (s.GetAge(competitie.An, competitie.Luna) < MedieVarsta())
                {
                    Console.WriteLine(s.ToString());
                }
            }
        }
    }
}