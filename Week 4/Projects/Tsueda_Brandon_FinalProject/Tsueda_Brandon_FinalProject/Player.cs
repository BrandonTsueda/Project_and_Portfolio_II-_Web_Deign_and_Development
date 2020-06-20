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
        string Name { get; set; }
        /*TODO: int _health { get; set; }
        TODO: int _dmg { get; set; }
        TODO: int _level { get; set; }
        TODO: float _experience { get; set; }*/

        //constructor
        public Player(string name/*, int health, int dmg, int level, int experience*/)
        {
            Name = name;
            /*TODO: this._health = health;
            TODO: this._dmg = dmg;
            TODO: this._level = level;
            this._experience = experience;*/
        }

        //virtual method to deal damge
        public virtual string DealDamage()
        {
            return "The hero dealt damage";
        }


        //method to create a character
        public Player CreatePlayer()
        {
            Name = Validation.ValidateString("Please enter the players name: ");

            Player player = new Player(Name);
            player.CreatePlayerSaveFile(player);

            return player;
        }

        //TODO: method to load character
        public static void LoadPlayer()
        {

        }

        //TODO: method to create a save file for the player
        public void CreatePlayerSaveFile(Player player)
        {

            //variable holding the file path location
            string saveFolderPath = @"../../../..savedgames/";
            //variable to store the save file path
            string saveFilePath = Path.Combine(saveFolderPath, ""+ Name +"savedgame.json");
            //serializes player info into json format
            string jsonString = JsonConvert.SerializeObject(player);

            //writes the data to the designated file
            File.WriteAllText(saveFilePath, jsonString);
        }

        //TODO: method to save player
        public static void SavePlayerToFile()
        {

        }
    }
}
