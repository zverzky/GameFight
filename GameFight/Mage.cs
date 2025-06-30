using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GameFight;

public class Mage : Character
{
    public Mage(string name, double powerAttack, double health, double maxHealth,double deffirence)
        : base(name, powerAttack, health, maxHealth, deffirence)
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
        base.Attack(target);
    }

    public override void TakeDamage(double damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"{this.Name} now has {this.Health} health");
    }
    public override void SpecialSkill(ICharacter target)
    {
        double specialDamage = target.Health / 2;
        target.TakeDamage(specialDamage);
        Console.WriteLine($"{target.Name} использует специальный навык и наносит {specialDamage} урона!");
    }
}

