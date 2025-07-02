using GameFight.Interface;
using GameFight.Experience;
using GameFight.Manager;

namespace GameFight.Character
{
    public class Character : ICharacter
    {
        private string name;
        private double powerAttack;
        private double health;
        private double deffirence;
        private double maxHealth;
        private int attackCount = 0;
        private int level;
        private ExperienceProvider experienceProvider;

        public Character(string name, double powerAttack, double health, double maxHealth, double deffirence, int level)
        {
            this.name = name;
            this.powerAttack = powerAttack;
            this.health = health;
            this.maxHealth = maxHealth;
            this.deffirence = deffirence;
            this.level = level;
            experienceProvider = new ExperienceProvider(); 
        }

        public string Name => name;
        public double PowerAttack => powerAttack;
        public double Health => health;
        public double MaxHealth => maxHealth;
        public double Deffirence => deffirence;
        public int Level => level;
        public double Expirience => experienceProvider.Experience;

        public virtual void TakeDamage(double damage)
        {
            double effectiveDamage = damage * (1 - deffirence / 100);
            health -= effectiveDamage;
            if (health < 0)
            {
                health = 0;
            }
        }

        public virtual void Attack(ICharacter target)
        {
            attackCount += 1;
            Console.WriteLine($"Атак {attackCount}");
            if (attackCount % 2 == 0)
            {
                experienceProvider.GainExperience(20); 
                LevelManager levelManager = new LevelManager(experienceProvider);
                levelManager.UpdateLevel(ref level);
            }

            if (attackCount % 4 == 0)
            {
                SpecialSkill(target);
            }
        }

        public virtual void SpecialSkill(ICharacter target)
        {
            
        }
    }
}