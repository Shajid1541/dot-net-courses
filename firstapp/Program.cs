namespace firstapp
{
    internal class Program
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
                Console.WriteLine("Normal enum "+method);
                var methodname = method.ToString();
                Console.WriteLine("Enums name "+  methodname);
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
        static void Main(string[] args)
        {
            int number = 0;


            Console.WriteLine("Hello, World!"+number);
            Console.WriteLine("{0} {1}",int.MaxValue, int.MinValue);
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
            catch (Exception){
                Console.WriteLine("Can't conver to byte!");
            }

            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            nonPrimitive.numsintoString(nums);
            nonPrimitive.numsVerbatim(nums);
            nonPrimitive.enumTest();


        }
    }
}
