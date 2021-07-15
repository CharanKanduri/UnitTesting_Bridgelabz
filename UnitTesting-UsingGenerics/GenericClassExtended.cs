using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_UsingGenerics
{
   public class GenericClassExtended<T> where T : IComparable
    {
        public T[] arrayList;

        //Parameterized Constructor
        public  GenericClassExtended(T[] arrayList)
        {
            this.arrayList = arrayList;
        }

        //Sort Method
        public T[] Sort(T[] arrayList)
        {
            Array.Sort(arrayList);
            return arrayList;
        }
        //to return last value of sorted array
        public T MaximumValueFunction(T[] arrayList)
        {
            var sortarrayval = Sort(arrayList);
            return sortarrayval[^1];
        }
    }
}
