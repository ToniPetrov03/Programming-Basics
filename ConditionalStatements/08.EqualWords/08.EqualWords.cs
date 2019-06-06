using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            int x = String.Compare(word1, word2, true);
            
            if (x == 0)
            {
                Console.WriteLine("yes");   
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
