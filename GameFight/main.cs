using GameFight;

public class Program
{
    public static void Main(string[] args)
    {
        Character rogue = new Rogue("Летучий", 10, 100, 100, 20, 0, 0);
        Character mage = new Mage("Маг", 10, 100, 100, 15, 0, 0);

        Battle battle = new Battle(mage, rogue);
        battle.StartBattle();
    }
}