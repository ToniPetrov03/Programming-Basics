using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numOfPj = int.Parse(Console.ReadLine());
            int hours = numOfPj * 3;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, hours, numOfPj);
        }
    }
}
