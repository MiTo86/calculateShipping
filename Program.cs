using System;

namespace calculateShipping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the purchase amount:");
            double purchase = Convert.ToDouble(Console.ReadLine());
            double shipCharge = 0.00;
            if (purchase < 0.01)
            {
                shipCharge = 0.00;
            }else if (purchase < 250.00)
            {
                shipCharge = 5.00;
            }else if (purchase < 500.00)
            {
                shipCharge = 8.00;
            }else if (purchase < 1000.00)
            {
                shipCharge = 10.00;
            }else if (purchase < 5000.00)
            {
                shipCharge = 15.00;
            }else if (purchase > 5000.00)
            {
                shipCharge = 20.00;
            }

            if (purchase < 0.01)
            {
                Console.WriteLine("Error incorrect input.");
            }else 
            Console.WriteLine("The shipping charge on a purchse of "+purchase+" is "+shipCharge);
        }
    }
}
