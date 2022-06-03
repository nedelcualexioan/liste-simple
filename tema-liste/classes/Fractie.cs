using System;

namespace tema_liste.classes
{
    public class Fractie
    {
        private int numarator;
        private int numitor;

        public Fractie(int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
        }

        public int Numarator
        {
            get => numarator;
            set => numarator = value;
        }

        public int Numitor
        {
            get => numitor;
            set => numitor = value;
        }

        public override String ToString()
        {
            return numarator + "/" + numitor;
        }
        
    }
}