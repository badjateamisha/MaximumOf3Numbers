using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfThree
{
    public class UsingArray<T> where T : IComparable
    {
        public T[] array;

        public UsingArray(T[] array)
        {
            this.array = array;
        }

        public static T MaxValueOfMultipleUsingGenerics<T>(params T[] array)
        {
            Array.Sort(array);
            return array[array.Length - 1];
        }
    }
}