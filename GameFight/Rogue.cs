using System;

namespace GameFight;

    public class Rogue : Character
    {
        public Rogue(string name, double powerAttack, double health, double maxHealth, double deffirence)
            : base(name, powerAttack, health, maxHealth, deffirence)
        {
            deffirence = 0.2;
        }

        public override void Attack(ICharacter target)
        {
            double attackPower = this.PowerAttack;

            if (this.MaxHealth == this.Health)
            {
                attackPower *= 2;
            }
            Console.WriteLine($"{this.Name} has a power attack of {attackPower}");
            base.Attack(target);
    }

        public override void TakeDamage(double damage)
        {
            if (this.Health < 50)
            {
                Console.WriteLine("Получение урона снижено на 50%");
                damage *= 0.5;
            }

            base.TakeDamage(damage);
            Console.WriteLine($"{this.Name} now has {this.Health} health");
        }
        public override void SpecialSkill(ICharacter target)
        {
            double specialDamage = target.PowerAttack * 2;
            target.TakeDamage(specialDamage);
            Console.WriteLine($"{target.Name} использует специальный навык и наносит {specialDamage} урона!");
        }
    }