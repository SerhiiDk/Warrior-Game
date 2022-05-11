using WarriorWars;
using WarriorWars.Enum;

namespace WarrirWars
{
    class EntryPoint
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("Bob", Faction.GoogGuy);
            Warrior badGuy = new Warrior("Joe", Faction.BadGuy);

            
            while(goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }
        } 
    }
}