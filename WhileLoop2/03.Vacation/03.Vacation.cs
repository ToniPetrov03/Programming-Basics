using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());

            int spendCounter = 0;
            int daysCounter = 0;

            while (moneyOnHand < neededMoney && spendCounter < 5)
            {
                string spendOrSave = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (spendOrSave == "spend")
                {
                    if (moneyOnHand - money < 0)
                    {
                        moneyOnHand = 0;
                    }
                    else
                    {
                        moneyOnHand -= money;
                    }

                    spendCounter++;
                }
                else
                {
                    moneyOnHand += money;

                    spendCounter = 0;
                }

                daysCounter++;
            }

            if (spendCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            else if (moneyOnHand >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
