using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    internal class GenericUt<T> : IGeneric<T>
    {
        public bool isEqual(T a, T b)
        {
            return a.Equals(b);
        }

        public void print(List<T> value)
        {
            foreach(var Val in value)
            {
                Console.WriteLine(Val);
            }
        }

        public void print(List<T> a, List<T> b)
        {
            if(a.Count != b.Count){
                Console.WriteLine("Lists not have the same size!!");
            }
            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("List 1: {0} List 2: {1}", a[i], b[i]);
            }

        }
    }
}
