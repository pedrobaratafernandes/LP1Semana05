using System;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {

        }

        private static int Damage(int attack, int defense)
        {
            return attack - defense;
        }
        private static int Damage(int attack)
        {
            return damage;
        }
        private static int CriticalHit(int damage)
        {

            if (damage <= 0)
            {
                damage = 0;
            }
            else
            {
                damage = 1 + Damage(damage);
            }
            return damage;
        }
    }
}
