using System;
namespace Tsueda_Brandon_FinalProject
{
    public class UndeadSpaceForceCadet : Enemy
    {
        public float ExperiencePoints { get; set; }

        public UndeadSpaceForceCadet(string name, int health, int dmg, float experiencePoints) : base(name, health, dmg)
        {
            ExperiencePoints = experiencePoints;
        }

        public override void EnemyDeathCheck()
        {
            Console.WriteLine("" + Name + " has been defeated!!!\n\nYou have been awarded " + ExperiencePoints + " exerience points!\n");
        }
    }
}
