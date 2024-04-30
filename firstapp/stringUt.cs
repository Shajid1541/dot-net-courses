using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    internal class stringUt
    {
        public static string summary(string str, int maxLength)
        {
            var words = str.Split(' ');
            int total = 0;
            var s = new List<string>();
            foreach (var word in words)
            {
                total += word.Length + 1;
                if (total > maxLength)
                {
                    return string.Join(" ", s)+"...";
                }
                s.Add(word);

            }
            return string.Join(" ", s);
        }
    }
}
