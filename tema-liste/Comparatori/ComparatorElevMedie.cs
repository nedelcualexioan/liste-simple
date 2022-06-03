using System;
using System.Collections.Generic;
using tema_liste.classes;

namespace tema_liste.Comparatori
{
    public class ComparatorElevMedie : Comparer<Elev>
    {
        public override int Compare(Elev x, Elev y)
        {
            if (x.MedieInfo.CompareTo(y.MedieInfo) > 0)
            {
                return 1;
            }
            else if (x.MedieInfo.CompareTo(y.MedieInfo) < 0)
            {
                return -1;
            }

            return 0;
        }
    }
}