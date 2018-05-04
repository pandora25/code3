using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = "This C Sharp bootcamp is so AWESOME!";
            char[] strcount = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (strcount[i] == 'a' || strcount[i] == 'A')
                {
                    count++;
                }
            }
            Console.WriteLine($"the total 'a's are {count}");
        }
    }
}
