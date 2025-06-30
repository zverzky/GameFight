using GameFight;

public class Program
{
    public static void Main(string[] args)
    {
        Character rogue = new Rogue("Летучий", 20, 100, 100);
        Character warrior = new Warrior("Воин", 15, 80, 80);

        Battle battle = new Battle(warrior, rogue);
        battle.StartBattle();
    }
}