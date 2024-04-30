using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    internal class dateEx
    {
        public static void example()
        {
            var d = DateTime.Now;
            var dd = d.AddDays(1);
            var ts = dd - d;
            Console.WriteLine(ts.TotalMinutes);
        }
    }
}
