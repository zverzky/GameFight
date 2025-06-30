using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFight
{
    public class Character : ICharacter
    {
        private string name;
        private double powerAttack;
        private double health;
        private double maxHealth;

        public Character(string name, double powerAttack, double health,double maxHealth)
        {
            this.name = name;
            this.powerAttack = powerAttack;
            this.health = health;
            this.maxHealth = maxHealth;
        }

        public string Name => name;
        public double PowerAttack => powerAttack;
        public double Health => health;
        public double MaxHealth => maxHealth;

        public virtual void TakeDamage(double damage)
        {
            health -= damage;
            if (health < 0)
            {
                health = 0;
            }
        }
        public virtual void Attack(ICharacter target)
        {
            target.TakeDamage(powerAttack);
        }
    }
}
