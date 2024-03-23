using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius = 0;
            int fahr;
            while (celsius <= 300) {
            fahr = celsius * 9 / 5 + 32;
            Console.WriteLine($"temp celsius: {celsius} - temp fahr: {fahr}");
            
                celsius += 20;
            }

            
            Console.ReadLine();
            
        }
    }
}
