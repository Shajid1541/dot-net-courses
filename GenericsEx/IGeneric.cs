using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    internal interface IGeneric<T>
    {
        bool isEqual(T val1, T val2);
        void print(List<T> value);
        void print(List<T> value, List<T> value1);

    }
}
