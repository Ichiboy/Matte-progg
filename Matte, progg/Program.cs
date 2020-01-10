using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matte__progg
{
    class Program
    {
        static void Main(string[] args)
        {

            double punkt1y = 0;
            double punkt1x = 0;
            double punkt2y = 0;
            double punkt2x = 0;

            Console.WriteLine("Vad är X på punkt 1?");
            punkt1x = double.Parse(Console.ReadLine());
            
            

            Console.WriteLine("Vad är Y på punkt 1?");
            punkt1y = double.Parse(Console.ReadLine());
            
            

            Console.WriteLine("Vad är X på punkt 2?");
            punkt2x = double.Parse(Console.ReadLine());
            
            

            Console.WriteLine("Vad är Y på punkt 2?");
            punkt2y = double.Parse(Console.ReadLine());
            
            

            Console.WriteLine("Alltså är Punkt 1" + " (" + punkt1x + "," + punkt1y + ")");
            Console.WriteLine("Alltså är Punkt 2" + " (" + punkt2x + "," + punkt2y + ")");
            Console.ReadKey();

            Console.WriteLine("Dax att räkna ut K!");
            Console.WriteLine("K=" + (punkt2y - punkt1y) / (punkt2x - punkt1x));
            Console.ReadKey();

        
        }
    }
}
