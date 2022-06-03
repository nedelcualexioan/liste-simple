namespace tema_liste
{
    public class Competitie
    {
        private int an;
        private int luna;
        private int nrSportivi;

        public Competitie(int an, int luna, int nrSportivi)
        {
            this.an = an;
            this.luna = luna;
            this.nrSportivi = nrSportivi;
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

        public int NrSportivi
        {
            get => nrSportivi;
            set => nrSportivi = value;
        }
    }
}