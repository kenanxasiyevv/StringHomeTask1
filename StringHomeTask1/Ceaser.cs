using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHomeTask1
{
    internal class Ceaser
    {
        public static string CeaserMethod()
        {
            //sezar shifrelenmesi
            Console.Write("Nece herf saga surusdurmek isteyirsiniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Herf ve ya sozu daxil edin: ");   
            string s = Console.ReadLine();
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    int b = (s[i] - 64 + a) % 26 + 64;
                    result += (char)b;
                }
                else
                {
                    int c = (s[i] - 96 + a) % 26 + 96;
                    result += (char)c;
                }
            }
            return result;
        }
    }
}
