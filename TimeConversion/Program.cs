using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string hours = string.Concat(s[0], s[1]);
            string minutes = string.Concat(s[3], s[4]);
            string seconds = string.Concat(s[6], s[7]);
            int hour = Convert.ToInt32(hours);
            if (s[8] == 'P' && hour < 12)
            {
                hour += 12;
                hours = Convert.ToString(hour);
                if (hour == 24)
                    hours = "00";
            }
            if (s[8] == 'A' && hour == 12)
            {
                hours = "00";
            }
            Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
            Console.ReadKey();
        }
    }
}
