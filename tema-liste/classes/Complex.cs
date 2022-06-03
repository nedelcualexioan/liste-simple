using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_liste.classes
{
    public class Complex
    {

        private int real;
        private int imaginar;

        public int Real
        {
            get => this.real;
            set => this.real = value;
        }

        public int Imaginar
        {
            get => this.imaginar;
            set => this.imaginar = value;
        }

        public double Modul
        {
            get => Math.Sqrt(real * real + imaginar * imaginar);
        }

        public Complex(int real, int imaginar)
        {
            this.real = real;
            this.imaginar = imaginar;
        }

        public override String ToString()
        {
            if (imaginar > 0)
                return String.Format("z = {0}+{1}i", real, imaginar);

            return String.Format("z = {0}{1}i", real, imaginar);
        }

        public override bool Equals(object obj)
        {
            if(obj is Complex complex)
            {
                return complex.Real == this.real && complex.Imaginar == this.imaginar;
            }

            return false;
        }

    }
}
