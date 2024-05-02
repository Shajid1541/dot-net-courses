using static firstapp.test;
using static firstapp.loop;

namespace firstapp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int number = 0;


            Console.WriteLine("Hello, World!" + number);
            Console.WriteLine("{0} {1}", int.MaxValue, int.MinValue);
            int i = 666666666;
            byte j = (byte)i;
            Console.WriteLine("{0} {1}", i, j);
            string s = "80";
            i = int.Parse(s);
            Console.WriteLine(i);
            s = "9008";
            i = Convert.ToInt32(s);
            Console.WriteLine(i);
            try
            {
                var num = "1234";
                byte b = Convert.ToByte(num);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Can't conver to byte!");
            }

            callsForExamples();

        }

        private static void callsForExamples()
        {
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            nonPrimitive.numsintoString(nums);
            nonPrimitive.numsVerbatim(nums);
            nonPrimitive.enumTest();
            randomEx();
            listEx.example();
            dateEx.example();
            string ss = "ashdkjh a ajshd kjashd sdh ajshdkj hsd  jhakjz dhkjahsd kja ahsd lkas";
            string sss = stringUt.summary(ss, 30);
            Console.WriteLine(sss);
            /*stringUt.consecutive();
            stringUt.duplicate();*/
            dateEx.validtime();
        }
    }
}
