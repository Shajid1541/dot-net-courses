namespace GenericsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var ss = new GenericUt<double>();
            Console.WriteLine(ss.isEqual(5.9, 5.9));
            ss.print(new List<double> { 8.0, 7.9, 8.99, 10.84 });
            ss.print(new List<double> { 8.0, 7.9, 8.99, 10.84 }, new List<double> { 3.0, 1.9, 2.99, 11.84 });
        }
    }
}
