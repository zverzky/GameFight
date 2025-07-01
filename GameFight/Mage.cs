namespace GameFight;

public class Mage : Character
{
    public Mage(string name, double powerAttack, double health, double maxHealth,double deffirence, int level, double expirience)
        : base(name, powerAttack, health, maxHealth, deffirence, level, expirience)
    {
        
    }

    public override void Attack(ICharacter target)
    {
        double attackPower = this.PowerAttack;

        if (target.Health < this.Health)
        {
            attackPower *= 1.5;
        }
        target.TakeDamage(attackPower);
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

