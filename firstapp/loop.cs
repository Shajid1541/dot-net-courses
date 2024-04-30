using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    internal class loop
    {
        public static void randomEx()
        {
            var random = new Random();
            var pass = new char[10];
            for (int i = 0; i < pass.Length; i++) {
                pass[i] = (char)('A'+ random.Next(0,26));
            }
            var s = new string(pass);
            Console.WriteLine(s);
        }
    }
}
