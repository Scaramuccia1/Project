using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mail = @"[a-z0-9]+@[a-z0-9]+\.[a-z]$";
            string s = "Мой номер 123-45-1254";
            string pattern = @"\d{3}-\d{2}-\d{4}";
            match_string(s, pattern);
        }
        public static void match_string(string input, string match)
        {
            Match m = Regex.Match(input, match);
            if (m.Success)
            {
                Console.WriteLine("Номер найден");
            }
            else
            {
                Console.WriteLine("Номер не найден");
            }
            Console.ReadLine();
        }
    }
}
