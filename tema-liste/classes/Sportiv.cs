using System;
using Microsoft.VisualBasic;

namespace tema_liste.classes
{
    public class Sportiv
    {
        private String fullName;
        private int an;
        private int luna;

        public Sportiv(String fullName, int an, int luna)
        {
            this.fullName = fullName;
            this.an = an;
            this.luna = luna;
        }

        public int An
        {
            get => an;
            set => an = value;
        }

        public int Luna
        {
            get => luna;
            set => luna = value;
        }

        public String FullName
        {
            get => this.fullName;
            set => this.fullName = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is Sportiv sportiv)
            {
                return sportiv.FullName.Equals(fullName) && sportiv.An.Equals(an) && sportiv.Luna.Equals(luna);
            }

            return false;
        }

        public override String ToString()
        {
            String text = "";

            text += "Nume: " + fullName + "\n";
            text += "Anul nasterii: " + an + "\n";
            text += "Luna nasterii: " + luna + "\n";

            return text;
        }

        public int GetAge(int year, int month)
        {
            if (month >= luna)
            {
                return year - an;
            }

            return year - an - 1;
        }
    }
}