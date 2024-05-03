using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    internal class Searching<T> where T: IComparable<T>
    {
        public T linearSearchMax(T[] arr)
        {
            T ans = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(ans) > 0)
                {
                    ans = arr[i];
                }
            }
            return ans;
        }
        
    }
}
