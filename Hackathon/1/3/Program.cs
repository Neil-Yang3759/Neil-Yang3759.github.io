using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few words : ");
            string input = Console.ReadLine();
            string[] str = input.Split(' ');
            str = str.Select(s => s.ToLowerInvariant()).ToArray();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string str2 in str)
            {
                if(dic.Keys.Contains(str2))
                {
                    dic[str2]++;
                }
                else
                {
                    dic.Add(str2, 1);
                }
            }
            foreach (KeyValuePair<string, int> item in dic)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.ReadKey();
        }
    }
}
