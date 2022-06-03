using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema_liste.classes;

namespace tema_liste.Comparatori
{
    public class ComparatorComplexeModul : Comparer<Complex>
    {
        public override int Compare(Complex x, Complex y)
        {
            if (x.Modul > y.Modul)
                return 1;
            if (x.Modul < y.Modul)
                return -1;
            return 0;
        }
    }
}
    