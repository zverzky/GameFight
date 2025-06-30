using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameFight
{
    public class Character : ICharacter
    {
        private string name;
        private double powerAttack;
        private double health;
        private double deffirence;
        private double maxHealth;
        private int attackCount;

        public Character(string name, double powerAttack, double health,double maxHealth, double deffirence)
        {
            this.name = name;
            this.powerAttack = powerAttack;
            this.health = health;
            this.maxHealth = maxHealth;
            this.attackCount = 0;
            this.deffirence = deffirence;
            Console.WriteLine($"Защита {name} = {deffirence}");
        }

        public string Name => name;
        public double PowerAttack => powerAttack;
        public double Health => health;
        public double MaxHealth => maxHealth;
        public double Deffirence => deffirence;

        public virtual void TakeDamage(double damage)
        {
            health -= damage * (deffirence/100);
            if (health < 0)
            {
                health = 0;
            }
        }
        public virtual void Attack(ICharacter target)
        {
            target.TakeDamage(powerAttack);
            attackCount += 1;
            Console.WriteLine(attackCount);
            if (attackCount % 4 == 0) 
            {
                target.SpecialSkill(target);
            }
        }
        public virtual void SpecialSkill(ICharacter target)
        {

        }
    }
}
