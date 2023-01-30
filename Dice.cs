using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHW
{
    public class Dice<T> where T : IComparable<T>
    {
        public virtual T BaseDie { get; set; }

        public Dice(T y)
        {
            this.BaseDie = y;
        }

        public virtual T Roll() { T item=default; return item; }
    }
}
