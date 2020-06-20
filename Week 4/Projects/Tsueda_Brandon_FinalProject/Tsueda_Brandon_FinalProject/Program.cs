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
        static void Main(string[] args)
        {
            //define string for users selection
            //define bool program running
            string usersSelection;
            bool programRunning = true;

            //declare values for character stats
            string name = null;
            //TODO: int health = 100;
            //TODO: int dmg = 0;

            Player player = new Player(name);

            //while loop to run until the user chooses to exit
            while (programRunning)
            {
                // Menu
                Console.WriteLine("~~~~Game Menu~~~~\n\n" +
                    "   1. Start Game\n" +
                    "   2. Create Character\n" +
                    "   3. Load Character\n" +
                    "   4. Exit\n\n");
                Console.Write("Please select 1 - 4: ");

                //store user input
                usersSelection = Console.ReadLine();

                //switch statement with cases for each selection
                switch (usersSelection)
                {
                    //TODO: Start Game - Run the game if there is a character loaded
                    case "1":
                        {
                            //TODO: if and else statements to make sure there is a character loaded
                            if(player == null)
                            {
                                Console.WriteLine("Please load or create a character first...");
                            }

                            else
                            {
                                Console.WriteLine("~~~~Start Game~~~~");

                            }

                            break;
                        }

                    //TODO: Create character - prompt user for values needed to create the character
                    case "2":
                        {
                            Console.WriteLine("~~~~Create Character~~~~");
                            Player.CreatePlayerSaveFile();

                            break;
                        }

                    //TODO: Load character - display a list of generated characters for the user to load and select
                    case "3":
                        {
                            Console.WriteLine("~~~~Load Character~~~~");


                            break;
                        }

                    //exit program
                    case "4":
                        {
                            Console.WriteLine("Now Exitting Game");
                            programRunning = false;
                            break;
                        }

                    //display validation message and prompt the user again
                    default:
                        {
                            Console.WriteLine("Please make a valid selection...");
                            break;
                        }
                }
            }
        }

        //TODO: Method for game actions
        //method to begin game
        public void GameMenu()
        {

        }
        public void BeginGame()
        {
            Console.WriteLine("");
        }
    }
}
