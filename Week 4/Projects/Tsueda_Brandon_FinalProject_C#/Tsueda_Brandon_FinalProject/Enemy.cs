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
        public string Name { get; set; }
        public int Health { get; set; }
        public int Dmg { get; set; }

        public Enemy(string name, int health, int dmg)
        {
            Name = name;
            Health = health;
            Dmg = dmg;
        }

        //enemy attack
        public void Attack(Player player)
        {
            if (player.Health <= 0)
            {
                player.PlayerDeathCheck();
                player.PlayerIsDead();
            }

            else if(this.Health <= 0)
            {
                this.EnemyIsDead();
            }

            else
            {
                Random random = new Random();
                int attack = random.Next(Dmg);

                if (attack >= player.Health)
                {
                    player.Health -= attack;
                    player.PlayerDeathCheck();
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    Console.ReadKey();
                    player.Health -= attack;
                    Console.WriteLine("The " + Name +" attcked you for " + attack + " damage!\n");
                }
                player.Attack(this);
            }
        }

        
        public virtual void EnemyDeathCheck()
        {
            this.EnemyIsDead();
            Console.WriteLine("The enemy has been defeated!");

        }

        public bool EnemyIsDead()
        {
            if (this.Health <= 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
