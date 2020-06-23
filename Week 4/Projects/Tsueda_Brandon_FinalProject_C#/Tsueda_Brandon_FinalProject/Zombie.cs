using System;
namespace Tsueda_Brandon_FinalProject
{
    public class Zombie : Enemy
    {
        public float ExperiencePoints { get; set; }

        public Zombie(string name, int health, int dmg, float experiencePoints) : base(name, health, dmg)
        {
            ExperiencePoints = experiencePoints;
        }

        public override void EnemyDeathCheck()
        {
            Console.WriteLine("" + this.Name + " has been defeated!!!\nYou have been awarded " + this.ExperiencePoints + "!");

        }


    }
}
