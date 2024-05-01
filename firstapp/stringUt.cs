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

        public static void consecutive()
        {
            string str = "";
            string s = "";
            str = Console.ReadLine();
            var s1 = str.Split('-');
            int last = int.Parse(s1[0]);
            for (int i = 1; i < s1.Length; i++)
            {
                if (int.Parse(s1[i]) == last + 1)
                {
                    s = "Consecutive";
                }
                else
                {
                    s = "Not Consecutive";
                    break;
                }
                last = int.Parse(s1[i]);
            }
            Console.WriteLine(s);
        }

        public static void duplicate()
        {
            string str = "";
            string s = "Not Duplicate";
            str = Console.ReadLine();
            if(str == "")
            {
                Console.WriteLine("Empty String");
                return;
            }
            var s1 = str.Split('-');
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = i+1; j < s1.Length; j++)
                {
                    if (s1[i] == s1[j])
                    {
                        s = "Duplicate";
                        break;
                    }
                }
                if (s == "Duplicate")
                {
                    break;
                }
            }
            

            Console.WriteLine(s);
        }
    }
}
