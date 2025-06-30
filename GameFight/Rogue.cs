using System;

namespace GameFight;

    public class Rogue : Character
    {
        public Rogue(string name, double powerAttack, double health, double maxHealth)
            : base(name, powerAttack, health, maxHealth)
        {
        }

        public override void Attack(ICharacter target)
        {
            double attackPower = this.PowerAttack;

            if (this.MaxHealth == this.Health)
            {
                attackPower *= 2;
            }

            Console.WriteLine($"{this.Name} has a power attack of {attackPower}");
            target.TakeDamage(attackPower);
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
    }