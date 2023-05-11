using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimbolosSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "=+aa=+";
            Console.WriteLine(str);
            Match match = Regex.Match(str, "(?<=[=+])+[a-zA-Z]+(?<=[=+])",
                    RegexOptions.IgnoreCase);
            while (match.Success)
            {
                string key = match.Value;
                Console.Write(key);
                match = match.NextMatch();
            }

            Console.ReadKey();
        }
    }
}
