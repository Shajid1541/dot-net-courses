using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    internal class test
    {
        public class nonPrimitive
        {
            public enum ShippingMethod
            {
                Regular = 1,
                Express = 2
            }

            public static void enumTest()
            {
                var method = ShippingMethod.Regular;
                Console.WriteLine("Normal enum " + method);
                var methodname = method.ToString();
                Console.WriteLine("Enums name " + methodname);
                var methodid = (int)method;
                Console.WriteLine(methodid);

            }
            public static void numsintoString(int[] numbers)
            {
                string list = string.Join(", ", numbers);
                Console.WriteLine(list);

            }
            public static void numsVerbatim(int[] numbers)
            {
                string s = @$"
                            {numbers[0]}
                            {numbers[1]}
                            {numbers[2]}";
                Console.WriteLine(s);
            }


        }
    }
}
