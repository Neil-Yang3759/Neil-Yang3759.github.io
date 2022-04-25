using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (must larger than 90) : ");
            int max = int.Parse(Console.ReadLine());
            foreach(int i in Enumerable.Range(1,max-1))
            {
                if(i % 3 == 0 && i % 5 == 0)Console.WriteLine("Dann");
                else if(i % 3 == 0) Console.WriteLine("Build");
                else if(i % 5 == 0) Console.WriteLine("School");
                else Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
