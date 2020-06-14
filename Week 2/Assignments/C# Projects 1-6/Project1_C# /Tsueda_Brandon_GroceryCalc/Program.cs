using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsueda_Brandon_GroceryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Brandon Tsueda
            SDI Section 01
            9/25/2018
            Grocery Calculator
             */

            //Greet the user and prompt for first iteem
            Console.WriteLine("Hello and welcome to the Grocery Calculator, where you can easily add up each item to know the exact cost before you hit the register!");
            Console.WriteLine("Before we begin please give me the price of your apples.");

            //Store the users input
            string priceOne = Console.ReadLine();

            //Convert to decimal
            decimal firstPrice = decimal.Parse(priceOne);

            //Prompt user for next input
            Console.WriteLine("Perfect, now please input the price for your steak.");

            //Store the user input
            string priceTwo = Console.ReadLine();

            //Convert to a decimal
            decimal secondPrice = decimal.Parse(priceTwo);

            //Prompt the user for the last input.
            Console.WriteLine("Perfect, now please let me know the price of the ice cream.");

            //Store user input
            string priceThree = Console.ReadLine();

            //Convert to decimal
            decimal thirdPrice = decimal.Parse(priceThree);

            //Prompt user for quantity of each item
            Console.WriteLine("Great, now, how many apples are you getting?");

            //Store user input
            string firstQuantity = Console.ReadLine();

            //Convert to decimal
            decimal quantityOne = decimal.Parse(firstQuantity);

            //Prompt user for next quantity
            Console.WriteLine("Great, now how many steaks are you getting?");

            //Store user input
            string secondQuantity = Console.ReadLine();

            //Convert to decimal
            decimal quantityTwo = decimal.Parse(secondQuantity);

            //Prompt user for last item quantity
            Console.WriteLine("Perfect, now how much ice cream are you getting?");

            //Store user input
            string thirdQuantity = Console.ReadLine();

            //Convert to decimal
            decimal QuantityThree = decimal.Parse(thirdQuantity);

            //Prompt user for sales tax
            Console.WriteLine("Perfect, the last thing I need is the sales tax in your area?");

            //Store user input
            string areaTax = Console.ReadLine();

            //Convert to decimal
            decimal taxAmount = decimal.Parse(areaTax);

            //Create a value for converting percentage
            decimal T = .01m;
            //Convert Sales tax to percentage
            decimal salesTax = taxAmount * T;            

            //Add up first food price and totals
            decimal appleTotal = firstPrice * quantityOne;
            decimal steakTotal = secondPrice * quantityTwo;
            decimal icecreamTotal = thirdPrice * QuantityThree;

            //get sales tax
            decimal appleTax = appleTotal * salesTax;
            decimal steakTax = steakTotal * salesTax;
            decimal icecreamTax = icecreamTotal * salesTax;

            //Get Totals
            decimal appleFinal = appleTotal + appleTax;
            decimal steakFinal = steakTotal + steakTax;
            decimal icecreamFinal = icecreamTotal + icecreamTax;

            //Total Bill
            decimal totalBill = appleFinal + steakFinal + icecreamFinal;            

            //Give values to user
            Console.WriteLine("Perfect, now for your totals!");
            Console.WriteLine("Your apples came out to $"+appleTotal.ToString("C")+" before tax.  Your taxable total for the apples is $"+appleTax.ToString("C")+", making the total amount for your\r\napples $"+appleFinal.ToString("C")+".");
            Console.WriteLine("Your steak came out to $" + steakTotal + " before tax.  Your taxable total for the steaks is $" + steakTax.ToString("C") + ", making the total amount\r\nfor your steak $" + steakFinal.ToString("C") + ".");
            Console.WriteLine("Your ice cream came out to $" + icecreamTotal.ToString("C") + " before tax.  Your taxable total for the ice cream is $" + icecreamTax.ToString("C") + ", making the\r\ntotal amount for your ice cream $" + icecreamFinal.ToString("C") + ".");
            Console.WriteLine("This makes your total today $"+totalBill.ToString("C")+".");

            //Thank user
            Console.WriteLine("Thank you for using this calulator, and have a great day!");
        }
    }
}
