using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    internal class listEx
    {
        public static void example()
        {
            var items = new List<string>() { "apple","pineapple", "grape"};
            items.Add("Guava");
            var random = new Random();
            items.AddRange(new string[3] { "man", "woman", "chilren" });
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
