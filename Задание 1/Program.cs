using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double l = double.Parse(Console.ReadLine());
                double r = 1 / (2 * Math.PI);
                Console.WriteLine(r);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();

        }
    }
}
