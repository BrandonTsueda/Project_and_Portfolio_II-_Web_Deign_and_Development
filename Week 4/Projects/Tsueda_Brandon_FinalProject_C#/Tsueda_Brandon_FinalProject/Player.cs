using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Tsueda_Brandon_FinalProject
{
    public class Player
    {
        //declare variables for a character
        public string Name { get; set; }
        public int Health { get; set; }
        public int Dmg { get; set; }
        public int Level { get; set; }
        public float ExperiencePoints { get; set; }

        //constructor
        public Player(string name, int health, int dmg, int level, float experiencePoints)
        {
            Name = name;
            Health = health;
            Dmg = dmg;
            Level = level;
            ExperiencePoints = experiencePoints;
        }

        //method to deal damge
        public void Attack(Enemy enemy)
        {
            
            if(enemy.Health <= 0)
            {
                enemy.EnemyDeathCheck();
                enemy.EnemyIsDead();
            }

            else if (Health <= 0)
            {
                this.PlayerIsDead();
            }

            else
            {
                Random random = new Random();
                int attack = random.Next(Dmg);

                if(attack >= enemy.Health)
                {
                    enemy.Health -= attack;                    
                    enemy.EnemyDeathCheck();
                    enemy.EnemyIsDead();
                }

                else
                {
                    enemy.Health -= attack;
                    Console.WriteLine("You have attacked the enemy for " + attack + " damage!\n");
                }
                enemy.Attack(this);
            }
        }

        //method to create a character
        static public Player CreatePlayer()
        {
            string name = Validation.ValidateString("Please enter the players name: ");

            Player player = new Player(name, 150, 30, 1, 0f);
            player.CreatePlayerSaveFile(player);

            return player;
        }

        //load player
        public static Player LoadPlayer()
        {
            //path to folder savedgames
            string saveFolderPath = @"../../../savedgames/";

            //returns the names of the files specified
            string[] arrayOfSaves = Directory.GetFiles(saveFolderPath, "savedgame_*.json");
            List<Player> playerList = new List<Player>();

            foreach (string s in arrayOfSaves)
            {
                Console.WriteLine(Path.GetFileName(s.Substring(1,s.Length-6)));

                string jsonData = File.ReadAllText(s);

                Player player = JsonConvert.DeserializeObject<Player>(jsonData);

                
                playerList.Add(player);
            }

            //ask what player to load
            string playerSelection = Validation.ValidateString("\nEnter the name of the player you want to load: ");

            //created an empty object for use later
            Player playerSelected = null;

            //try and catch
            try
            {
                playerSelected = playerList.Find(player => player.Name.Equals(playerSelection, StringComparison.InvariantCultureIgnoreCase));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Message " + e + "");
                Console.WriteLine("This player does not exist, please select a valid player...\n");
            }

            return playerSelected;
        }

        //create a save file for the player
        public void CreatePlayerSaveFile(Player player)
        {
            //variable holding the file path location
            string saveFolderPath = @"../../../savedgames/";
            //variable to store the save file path
            string saveFilePath = Path.Combine(saveFolderPath, "savedgame_" + Name +".json");
            //serializes player info into json format
            string jsonString = JsonConvert.SerializeObject(player);

            //writes the data to the designated file
            File.WriteAllText(saveFilePath, jsonString);
        }

        public bool PlayerIsDead()
        {
            if (Health <= 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void PlayerDeathCheck()
        {
            //PlayerIsDead();
            Console.WriteLine("" + Name + " has died");

            this.Health = 100;
            Console.Clear();
            Program.Main();
        }

        public void LevelUp()
        {
            Console.WriteLine("You have just leveled up!\n" +
                "Level increased by 1\n" +
                "Health increased by 25\n" +
                "Damage increased by 12\n");
            Level += 1;
            Health += 25;
            Dmg += 12;

            Console.ReadKey();

        }

        public void LevelUpCheck()
        {
            float currentExperience = ExperiencePoints;
            if (currentExperience >= (100 * Level))
            {
                LevelUp();
            }
        }
    }
}
