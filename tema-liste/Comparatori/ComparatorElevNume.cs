using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema_liste.classes;

namespace tema_liste.Comparatori
{
    public class ComparatorElevNume : Comparer<Elev>
    {
        public override int Compare(Elev x, Elev y)
        {
            if (x.FullName.CompareTo(y.FullName) > 0)
            {
                return 1;
            }

            if (x.FullName.CompareTo(y.FullName) < 0)
            {
                return -1;
            }

            return 0;
        }
    }
}
