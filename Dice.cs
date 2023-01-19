using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHW
{
    public abstract class Dice<T> where T : IComparable<T>
    {
        public T Scalar { get; set; }
        public T BaseDie { get; set; }

        public Dice(T x, T y)
        {
            this.Scalar = x;
            this.BaseDie = y;
        }

        public abstract T Roll();
    }
}
