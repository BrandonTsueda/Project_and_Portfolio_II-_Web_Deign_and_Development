using System;
namespace Tsueda_Brandon_FinalProject
{
    public class Adventure
    {
        public static void AdventureTime(Player player)
        {
            Zombie zombie = new Zombie("Bob the Zombie", 20, 15, 50f);
            Slime slime = new Slime("Bubble Slime", 20, 13, 50f);
            Vampire vampire = new Vampire("Vlad the Vampire", 20, 17, 50f);
            UndeadSpaceForceCadet spaceman = new UndeadSpaceForceCadet("General Naird", 20, 20, 100f);


            Random random = new Random();

            int number = random.Next(6);

            if (number == 1)
            {
                Console.WriteLine("You have encountered " + zombie.Name + "!");

                while (zombie.EnemyIsDead() != true)
                {
                    zombie.Attack(player);

                    player.ExperiencePoints += zombie.ExperiencePoints;
                    player.LevelUpCheck();

                    player.CreatePlayerSaveFile(player);
                }
            }

            else if (number == 2)
            {
                Console.WriteLine("You have encountered " + slime.Name + "!");

                while (slime.EnemyIsDead() != true)
                {
                    slime.Attack(player);

                    player.ExperiencePoints += slime.ExperiencePoints;
                    player.LevelUpCheck();
                    
                    player.CreatePlayerSaveFile(player);
                }
            }

            else if (number == 3)
            {
                Console.WriteLine("No enemies have been found during your last adventure...");

                AdventureTime(player);
            }

            else if (number == 4)
            {
                Console.WriteLine("You have encountered " + vampire.Name + "!");

                while (vampire.EnemyIsDead() != true)
                {
                    vampire.Attack(player);

                    player.ExperiencePoints += vampire.ExperiencePoints;
                    player.LevelUpCheck();

                    player.CreatePlayerSaveFile(player);
                }
            }

            else if (number == 5)
            {
                Console.WriteLine("You have encountered " + spaceman.Name + "!");

                while (spaceman.EnemyIsDead() != true)
                {
                    spaceman.Attack(player);

                    player.ExperiencePoints += spaceman.ExperiencePoints;
                    player.LevelUpCheck();

                    player.CreatePlayerSaveFile(player);
                }
            }

            else
            {
                Console.WriteLine("Let's continue this adventure!!!");

                //the game will re-run the method so the adventure will continue
                AdventureTime(player);
            }
        }
    }
}
