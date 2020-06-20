using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tsueda_Brandon_FinalProject
{
    public class Enemy
    {
        string _name { get; set; }
        int _health { get; set; }
        int _dmg { get; set; }

        public Enemy(string name, int health, int dmg)
        {
            this._name = name;
            this._health = health;
            this._dmg = dmg;
        }

        public virtual string EnemyDealDmg()
        {
            return "The enemy dealt damage";
        }
    }
}
