using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFight.Interface;

namespace GameFight.Character;

public class Warrior: Character
{
    public Warrior(string name, double powerAttack, double health, double maxHealth, double deffirence, int level, double expirience)
    : base(name, powerAttack, health, maxHealth, deffirence, level, expirience)
    {
        
    }
    public override void Attack(ICharacter target)
    {
        double attackPower = this.PowerAttack;

        if (this.Health < target.Health)
        {
            attackPower *= 1.5;
        }
        target.TakeDamage(attackPower);
        Console.WriteLine($"{this.Name} has a power attack of {attackPower}");
        base.Attack(target);
    }

    public override void TakeDamage(double damage)
    {
        if (Health < 50)
        {
            Console.WriteLine("Получение урона снижено на 50%");
            damage *= 0.5; 
        }
        base.TakeDamage(damage);
        Console.WriteLine($"{this.Name} now has {this.Health} health");
    }
    public override void SpecialSkill(ICharacter target)
    {
        double specialDamage = this.PowerAttack * 2;
        target.TakeDamage(specialDamage);
        Console.WriteLine($"{target.Name} использует специальный навык и наносит {specialDamage} урона!");
    }
}
