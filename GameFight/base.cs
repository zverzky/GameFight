namespace game;

public class Character
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Level { get; set; }
    public double BaseHealth { get; set; } = 100;
    public double BaseDef { get; set; } = 5;
    public double BaseAttack { get; set; } = 10;

    public Character(string name, int level, string description)
    {
        Name = name;
        Level = level;
        Description = description;
    }
    public void Attack(Character target)
    {
        double damage = BaseAttack - target.BaseDef;

        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine($"{Name} атакует {target.Name} и наносит {damage} урона!");

        target.BaseHealth -= damage;

        if (target.BaseHealth <= 0)
        {
            target.BaseHealth = 0;
            Console.WriteLine($"{target.Name} был повержен!");
        }
        else
        {
            Console.WriteLine($"{target.Name} осталось здоровья: {target.BaseHealth}");
        }
    }
}