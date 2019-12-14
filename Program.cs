using System;
using static System.Console;

namespace tip_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double billCharge,
                   tipCharge,
                   totalCharge;
            const double LOW_TIP = 0.15,
                         GOOD_TIP = 0.2;

            // Compile-time initialization is not specified
            Write("Total bill charge: ");
            billCharge = ReadCharge();
            WriteLine("{0, 5} {1:C2}", "Bill:", billCharge);
        }

        static double ReadCharge()
        {
            double charge;
            string userInput = ReadLine();
            while (double.TryParse(userInput, out charge) == false)
            {
                WriteLine("Invalid input! Use dollars and cents.");
                Write("Total bill charge: ");
                userInput = ReadLine();
            }
            return charge;
        }
    }
}
