using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFight.Battle;

public class Battle
{
    private Character character1;
    private Character character2;

    public Battle(Character char1, Character char2)
    {
        character1 = char1;
        character2 = char2;
    }
    public void StartBattle()
    {
        Console.WriteLine($"Бой начинается между {character1.Name} и {character2.Name}");
        while (character1.Health > 0 || character2.Health > 0)
        {
            character1.Attack(character2);
            if (character2.Health <= 0) break;
            character2.Attack(character1);
            if (character1.Health <= 0) break;
        }
        if (character1.Health <= 0 && character2.Health <= 0)
        {
            Console.WriteLine("Оба персонажа пали в бою!");
        }
        else if (character1.Health <= 0)
        {
            Console.WriteLine($"{character2.Name} победил!");
        }
        else
        {
            Console.WriteLine($"{character1.Name} победил!");
        }
    }
}
