using System;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
           int ataque =  int.Parse(args[0]);
           int defensa = int.Parse(args[1]);

           Console.WriteLine(Damage(ataque));
           Console.WriteLine(Damage(ataque, defensa));
           Console.WriteLine(CriticalHit(ataque));
        }

        private static int Damage(int attack, int defense)
        {
            if (defense >= 0)
            {
                return attack - defense;
            }
            else
            {
                return attack;
            }
        }
        private static int Damage(int attack)
        {
            return attack;
        }
        private static int CriticalHit(int damage)
        {

            if (damage <= 0)
            {
                damage = 0;
            }
            else
            {
                damage = 1 + Damage(damage, Damage(damage));
            }
            return damage;
        }

        
    }
}
