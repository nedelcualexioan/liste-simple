using System;

namespace tema_liste.classes
{
    public class Elev
    {
        private String nume;
        private String prenume;
        private int medieInfo = -1;
        private int teza;

        public Elev(int membriiFamilie, int venitLunar, String nume, String prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.membriiFamilie = membriiFamilie;
            this.venitLunar = venitLunar;
        }

        public int MembriiFamilie
        {
            get => membriiFamilie;
            set => membriiFamilie = value;
        }

        public int VenitLunar
        {
            get => venitLunar;
            set => venitLunar = value;
        }

        private int membriiFamilie;
        private int venitLunar;

        public String FullName
        {
            get => this.nume + " " + this.prenume;
        }

        public int MedieSemestriala
        {
            get => (3 * medieInfo + teza) / 4;
        }

        public Elev(String nume, String prenume, int medieInfo, int teza)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.medieInfo = medieInfo;
            this.teza = teza;
        }

        public Elev()
        {
        }

        public override bool Equals(object obj)
        {
            if (obj is Elev e)
            {
                if (e.Nume.Equals(nume) && e.Prenume.Equals(prenume) && e.MedieInfo.Equals(medieInfo) &&
                    e.Teza.Equals(teza))
                    return true;
            }

            return false;
        }

        public String Nume
        {
            get => nume;
            set => nume = value;
        }

        public String Prenume
        {
            get => prenume;
            set => prenume = value;
        }

        public int MedieInfo
        {
            get => medieInfo;
            set => medieInfo = value;
        }

        public int Teza
        {
            get => teza;
            set => teza = value;
        }

        public override String ToString()
        {
            String text = "";

            text += "Nume: " + nume + "\n";
            text += "Prenume: " + prenume + "\n";

            if (medieInfo != -1)
            {
                text += "Medie info: " + medieInfo + "\n";
                text += "Nota teza: " + teza + "\n";
            }
            else
            {
                text += "Membrii familie: " + membriiFamilie + "\n";
                text += "Venit lunar: " + venitLunar + "\n";
            }

            return text;
        }
    }
}