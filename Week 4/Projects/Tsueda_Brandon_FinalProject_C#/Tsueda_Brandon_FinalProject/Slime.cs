using System;
namespace Tsueda_Brandon_FinalProject
{
    public class Slime : Enemy
    {
        public float ExperiencePoints { get; set; }

        public Slime(string name, int health, int dmg, float experiencePoints) : base(name, health, dmg)
        {
            ExperiencePoints = experiencePoints;
        }

        public override void EnemyDeathCheck()
        {
            Console.WriteLine("" + Name + " has been defeated!!!\nYou have been awarded " + ExperiencePoints + "!");
        }
    }
}
