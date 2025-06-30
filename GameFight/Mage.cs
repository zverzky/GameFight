using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFight;

public class Mage : Character
{
    public Mage(string name, double powerAttack, double health, double maxHealth)
        : base(name, powerAttack, health, maxHealth)
    {
    }

    public override void Attack(ICharacter target)
    {
        double attackPower = this.PowerAttack;

        if (target.Health < this.Health)
        {
            attackPower *= 1.5;
        }

        Console.WriteLine($"{this.Name} has a power attack of {attackPower}");
        target.TakeDamage(attackPower);
    }

    public override void TakeDamage(double damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"{this.Name} now has {this.Health} health");
    }
}

