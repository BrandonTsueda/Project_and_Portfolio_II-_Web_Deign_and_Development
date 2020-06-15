using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsueda_Brandon_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Brandon Tsueda
             SDI Section 01
             8/15/2018
             Lists Assignment
             */

            /*Create the purchase list.
            string[] purchaseItems = { "diapers", "wipes", "milk", "grapes", "gamingMouse", "gamingPad", "bread" };

            Create the values for the purchase list,
            decimal[] purchasePrice = { 24.99m, 14.99m, .99m, 4.99m, 89.99m, 39.99m, 3.99m };*/

            //Create list of prices
            List<decimal> itemPrices = new List<decimal>();
            itemPrices.Add(24.99M);
            itemPrices.Add(15.99M);
            itemPrices.Add(.99M);
            itemPrices.Add(4.99M);
            itemPrices.Add(3.99M);
            itemPrices.Add(3.99M);

            //Metthod call
            decimal priceTotal = AddUpCosts(itemPrices);

            //Output first set of results
            Console.WriteLine("The sum of the prices in the list is ${0}", priceTotal);

            //Remove and add prices
            itemPrices.Remove(3.99M);
            itemPrices.Remove(3.99M);
            itemPrices.Add(5.99M);

            //Output second set of results
            decimal priceTotalTwo = AddUpCosts(itemPrices);

            Console.WriteLine("The sum of the prices in the list is ${0}", priceTotalTwo);

            /*Test	#1-
            • List- {1.25,	2.56,	5.67,	4,	8.25,	2.99,	9.99}
            o “The	sum	of	the	prices	in the	list	is	$34.71”
            • Next	Remove	2	Prices
            o Remove	9.99	and	5.67
            o Insert	one	price	at	the	start	of	the	list,	6.78
            • Function	Call	to	the	same	method	and	results	are	now:
            o “The	sum	of	the	prices	in the	list	is	$25.83”*/

        }
        //Method
        public static decimal AddUpCosts(List<decimal>itemPrices)
        {
            var numbers = new List<decimal>(itemPrices);
            decimal sum = numbers.Sum();

            return sum;
        }
    }
}
