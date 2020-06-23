using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tsueda_Brandon_FinalProject
{
    class Program
    {
        static Player player;
        public static void Main()
        {
            //define string for users selection
            //define bool program running
            string usersSelection;
            bool programRunning = true;

            //while loop to run until the user chooses to exit
            while (programRunning)
            {
                // Menu
                // GameMenu();
                Console.WriteLine("~~~~Game Menu~~~~\n\n" +
                "   1. Start Game\n" +
                "   2. Create Character\n" +
                "   3. Load Character\n" +
                "   4. Exit\n\n");
                Console.Write("Please select 1 - 4: ");

                //store user input
                usersSelection = Validation.ValidateString("Select a number betweeen 1 and 4   ");

                RubSelection(usersSelection);
            }
        }

        public static void RubSelection(string usersSelection)
        {
            //switch statement with cases for each selection
            switch (usersSelection)
            {
                //TODO: Start Game - Run the game if there is a character loaded
                case "1":
                    {
                        //TODO: if and else statements to make sure there is a character loaded
                        if (player != null)
                        {

                            Console.WriteLine("~~~~Start Game~~~~");
                            Adventure.AdventureTime(player);


                        }

                        else
                        {
                            Console.WriteLine("Please load or create a character first...");
                        }

                        break;
                    }

                //TODO: Create character - prompt user for values needed to create the character
                case "2":
                    {
                        Console.WriteLine("~~~~Create Character~~~~");
                        player = Player.CreatePlayer();

                        break;
                    }

                //TODO: Load character - display a list of generated characters for the user to load and select
                case "3":
                    {
                        Console.WriteLine("~~~~Load Character~~~~");
                        player = Player.LoadPlayer();


                        break;
                    }

                //exit program
                case "4":
                    {
                        Console.WriteLine("Now Exitting Game");
                        // programRunning = false;
                        Environment.Exit('4');
                        break;
                    }

            }

        }
    }
}
