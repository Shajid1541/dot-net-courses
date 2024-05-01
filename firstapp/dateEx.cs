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
        public static void validtime()
        {
               Console.WriteLine("Enter time in 24 hour format");
            var date = new DateTime();
            var time = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(time))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            try
            {
                date = Convert.ToDateTime(time);
                Console.WriteLine("valid Time");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
       
            
        }
    }
}
