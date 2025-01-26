using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Integer and double variable declarations for principal loan value,
                interest rate, period of loan in years, and interest */
            double principal = 0;
            double rate = 0;
            int years = 0;
            double interest = 0;


            // Output name of the program
            Console.WriteLine("Interest Calculator Program");

            // Output statement prompting user to input the principal
            Console.WriteLine("What is the principal amount of the lone in dollars?");

            /* Collect user input for principal, turn it into a double, 
               and store it in the principal variable */
            principal = double.Parse(Console.ReadLine());


            // Output statement prompting user to input the rate
            Console.WriteLine("What is the interest rate (input 0.05 for 5%)?");

            /* Collect user input for rate, turn it into a double, 
               and store it in the rate variable */
            rate = double.Parse(Console.ReadLine());


            // Output statement prompting user to input the time
            Console.WriteLine("What is the period of the loan in years?");

            /* Collect user input for the period in years, turn it into a 32 integer,
                and store it in the years variable */
            years = Convert.ToInt32(Console.ReadLine());


            // Calculation to determine the interest
            interest = (principal * rate * years);


            // Output statement for interest
            Console.WriteLine($"Total interest of  the loan: {interest} dollars.");


            // Pause screen for user to read output
            Console.ReadLine();
        }
    }
}
