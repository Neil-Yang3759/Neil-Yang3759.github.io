using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your annual income : ");
            Decimal input = Decimal.Parse(Console.ReadLine());
            decimal tax = 0;
            if(input >= 10310001)
            {
                tax = Decimal.Multiply((input - 10310000), 0.5m);
                tax += 3294400m;
            }
            else if(input >= 4530001)
            {
                tax = Decimal.Multiply((input - 4530000), 0.4m);
                tax += 982400m;
            }
            else if (input >= 2420001)
            {
                tax = Decimal.Multiply((input - 2420000), 0.3m);
                tax += 349400m;
            }
            else if (input >= 1210001)
            {
                tax = Decimal.Multiply((input - 1210000), 0.2m);
                tax += 107400m;
            }
            else if (input >= 540001)
            {
                tax = Decimal.Multiply((input - 540000), 0.12m);
                tax += 27000m;
            }
            else
            {
                tax = Decimal.Multiply((input), 0.05m);
            }
            Console.WriteLine(tax);

            Console.ReadKey();
        }
    }
}
