using System;
using static System.Console;

namespace tip_calculator
{
    class Program
    {
        // class-level constants
        const double LOW_TIP = 0.15,
                     GOOD_TIP = 0.2;
        static void Main(string[] args)
        {
            double billCharge,
                   tipCharge,
                   totalCharge;

            // Compile-time initialization is not specified
            // so I'll read total bill from user input
            Write("Total bill charge: ");
            billCharge = ReadCharge();
            WriteLine(CalculateTips(billCharge));
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

        static string CalculateTips(double bill)
        {
            string result = String.Format("\nTIP CALCULATOR\n\n");
            result += String.Format("{0, 12} {1, 8:C2}\n\n", "Bill:", bill);
            result += String.Format("{0, 12} {1, 8:C2}\n", "15% Tip:", bill * LOW_TIP);
            result += String.Format("{0, 12} {1, 8:C2}\n\n", "15% Total:", bill * (1 + LOW_TIP));
            result += String.Format("{0, 12} {1, 8:C2}\n", "20% Tip:", bill * GOOD_TIP);
            result += String.Format("{0, 12} {1, 8:C2}\n", "20% Total:", bill * (1 + GOOD_TIP));
            return result;
        }
    }
}
