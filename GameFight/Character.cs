using GameFight;

public class Character : ICharacter
{
    private string name;
    private double powerAttack;
    private double health;
    private double deffirence;
    private double maxHealth;
    private int attackCount = 0;
    private int level;
    private double expirience;

    public Character(string name, double powerAttack, double health, double maxHealth, double deffirence, int level, double expirience)
    {
        this.name = name;
        this.powerAttack = powerAttack;
        this.health = health;
        this.maxHealth = maxHealth;
        this.deffirence = deffirence;
        Console.WriteLine($"Защита {name} = {deffirence}");
        this.level = level;
        Console.WriteLine($"Уровень - {level}");
        this.expirience = expirience;
        Console.WriteLine($"Опыт - {expirience}");
    }

    public string Name => name;
    public double PowerAttack => powerAttack;
    public double Health => health;
    public double MaxHealth => maxHealth;
    public double Deffirence => deffirence;
    public int Level => level;
    public double Expirience => expirience;

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
            expirience += 20;
            if (expirience >= 50)
            {
                LevelUp();
            }
        }

        if (attackCount % 4 == 0)
        {
            SpecialSkill(target);
        }
    }

    private void LevelUp()
    {
        level += 1;
        expirience -= 50;
        Console.WriteLine($"Ваш уровень был повышен с {level - 1} до {level}. Ваш текущий опыт: {expirience}");

        powerAttack += 10;
        maxHealth += 20;
        health = maxHealth;

        Console.WriteLine($"Ваши статы были повышены до: " +
            $"powerAttack - {powerAttack}, " +
            $"maxHealth - {maxHealth}, " +
            $"Здоровье восполнено до - {health}");
    }

    public virtual void SpecialSkill(ICharacter target)
    {
    }
}