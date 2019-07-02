using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int days = 1; days <= period; days++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (days % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }

                if (patients < doctors)
                {
                    treatedPatients += patients;
                    continue;
                }

                treatedPatients += doctors;
                patients -= doctors;
                untreatedPatients += patients;
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
