using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsueda_Brandon_MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Brandon Tsueda
             SDI Section 01
             9/25/2018
             Mad Libs
             */

            //Greet user and prompt for tthe first set of words needed
            Console.WriteLine("Hello, thank you for helping me write this story today!");
            Console.WriteLine("To begin I need your help coming up with an animal, a name, an adjective, and a food type.");
            Console.WriteLine("So please tell me tthe first animal that pops into your head at this moment.");

            //Store user input
            string animal = Console.ReadLine();

            //Thank user and prompt for next
            Console.WriteLine("Wow, great pick, that will go great in our story!");
            Console.WriteLine("Now tell me what name you want for our protagonist in this story.");

            //Storee input
            string name = Console.ReadLine();

            //Thank user and prompt for next
            Console.WriteLine("Thats a pretty solid name for a protagonist.");
            Console.WriteLine("Now, its time to think of a descriptive adjective to really paint an image to our reader.  Whats the first adjective tha comes to mind?");

            //Store input
            string adj = Console.ReadLine();

            //Thank user and prompt for next
            Console.WriteLine("Great, that will fit perfectly into our story!  Now think of something to eat.  It could be something delicious, or something not so delicious.");
            Console.WriteLine("Like I think of either a steak about an inch thick for something delicious, or a 100 year old chicken egg burried in the dirt for something not so delicious.");
            Console.WriteLine("So, what food item do you want to add to our story?");

            //Store user input
            string food = Console.ReadLine();

            //Thank user and prompt for next
            Console.WriteLine("Perfect, this is going to be a great story!  Now We need to think of a year, a cost, and a random number.");
            Console.WriteLine("So, think of a year you want in this story.  It could be a year from history, or a year in the future, whatever year you want.");

            //Store input
            string year = Console.ReadLine();

            //convert to decimal
            decimal y = decimal.Parse(year);

            //Thank user and prompt for next
            Console.WriteLine("Perfect, so we can see where we are headed with our story.  Now we need a cost to add to our story.  What price comes to mind?");

            //Store input
            string price = Console.ReadLine();

            //Convert to decimal
            decimal cost = decimal.Parse(price);

            //Thank user and prompt for last
            Console.WriteLine("Thank you, and now for the last piece of the puzzle to put our story together.  Tell me a random number, any number.");

            //Store input
            string number = Console.ReadLine();

            //Convert
            decimal random = decimal.Parse(number);

            //Create array for numbers
            decimal[] numb = new decimal[] { y, cost, random };

            //Thank user and begin the story
            Console.WriteLine("Perfect!  Now I will finish the rest of the story and see what you think!");

            Console.WriteLine("There was once a small " + animal + " who was very shy.  This " + animal + "'s name was " + name + ".");
            Console.WriteLine("Now, " + name + " was very fond of this honey badger that would show off her " + adj + " nature to anything coming near her.");
            Console.WriteLine("One day, " + name + " decided to let those feelings be known, despite his being shy.");
            Console.WriteLine("The honey badger was aggressively tearing into " + numb[2] + " " + food  +", while " + name + " watched from a safe distance.");
            Console.WriteLine("" + name + " was thinking to himself those " + food + "'s look really good.");
            Console.WriteLine("As he pondered between the " + food + " and the honey badger, he had an epifany.");
            Console.WriteLine("He decided tha the best way into her heart would be to have more " + food + "!");
            Console.WriteLine("Now back in " + numb[0] + ", this sort of thing was not very common.");
            Console.WriteLine("So, " + name + " went to count his change, he counted " + numb[1] + ".");
            Console.WriteLine("Well that isnt going to go very far!");
            Console.WriteLine("So, " + name + ", decided the only thing left to do is to steal the " + food + ".");
            Console.WriteLine("" + name + " eyed the honey badgers " + food + ", as the honey badger tried to hide it for later.");
            Console.WriteLine("As " + name + " got in close, he began to feel anxious.");
            Console.WriteLine("He grabbed the " + food + " and ran as fast as he could.");
            Console.WriteLine("The honey badger cought him and attacked!");
            Console.WriteLine("It took all his strength to get away, beacuse thee honey badger don't give a crap!");
            

            //Ask user about thougts on the story
            Console.WriteLine("So? Wasnt that a great story?");

            //Store input
            string feeback = Console.ReadLine();

            //Thank user for helping
            Console.WriteLine("Thank you for helping me come up with this story!  I hope you had fun!");

            
            
        }
    }
}
