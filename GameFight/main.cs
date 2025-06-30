using GameFight;

public class Program
{
    public static void Main(string[] args)
    {
        Character rogue = new Rogue("Летучий", 10, 100, 100, 20);
        Character mage = new Mage("Маг", 10, 100, 100, 15);

        Battle battle = new Battle(mage, rogue);
        battle.StartBattle();
    }
}