using System;
namespace Tsueda_Brandon_FinalProject
{
    public class Adventure
    {
        public static void AdventureTime(Player player)
        {
            Slime slime = new Slime("Bubble Slime", 30, 13, 15f);
            Zombie zombie = new Zombie("Bob the Zombie", 50, 15, 25f);
            Vampire vampire = new Vampire("Vlad the Vampire", 80, 17, 30f);
            UndeadSpaceForceCadet spaceman = new UndeadSpaceForceCadet("General Naird", 150, 20, 100f);


            Random random = new Random();

            int number = random.Next(6);

            if (number == 1)
            {
                Console.WriteLine("You have encountered " + zombie.Name + "!\n");

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
                Console.WriteLine("You have encountered " + slime.Name + "!\n");

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
                Console.WriteLine("No enemies where found during your last adventure...\n");

                AdventureTime(player);
            }

            else if (number == 4)
            {
                Console.WriteLine("You have encountered " + vampire.Name + "!\n");

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
                Console.WriteLine("You have encountered " + spaceman.Name + "!\n");

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
                Console.WriteLine("Let's continue this adventure!!!\n");

                //the game will re-run the method so the adventure will continue
                AdventureTime(player);
            }
        }
    }
}
