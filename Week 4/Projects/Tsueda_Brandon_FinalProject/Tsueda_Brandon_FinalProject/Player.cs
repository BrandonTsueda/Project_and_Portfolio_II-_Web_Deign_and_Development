using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tsueda_Brandon_FinalProject
{
    public class Player
    {
        //declare variables for a character
        string _name { get; set; }
        int _health = 100;
        int _dmg { get; set; }

        //constructor
        public Player(string name, int health, int dmg)
        {
            this._name = name;
            this._health = health;
            this._dmg = dmg;
        }

        //virtual method to deal damge
        public virtual string DealDamage()
        {
            return "The hero dealt damage";
        }
    }
}
