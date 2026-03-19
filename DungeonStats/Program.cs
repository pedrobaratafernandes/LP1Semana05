using System;
using Spectre.Console;
namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {



            // Console.WriteLine(Damage(ataque));
            // Console.WriteLine(Damage(ataque, defensa));
            // Console.WriteLine(CriticalHit(ataque));

            var table = new Table();

            if (args.Length == 2)

            {
                int ataque = int.Parse(args[0]);
                int defensa = int.Parse(args[1]);
                table.AddColumn("Operation");
                table.AddColumn("Result");
                table.AddRow($"Damage({ataque})", Damage(ataque).ToString());
                table.AddRow($"Damage({ataque}, {defensa})", Damage(ataque, defensa).ToString());
                table.AddRow($"CriticalHit({Damage(ataque, defensa)})", CriticalHit(ataque).ToString());

            }
            else
            {
                 int ataque = int.Parse(args[0]);
            
                table.AddColumn("Operation");
                table.AddColumn("Result");
                table.AddRow($"Damage({ataque})", Damage(ataque).ToString());
                table.AddRow($"Damage({ataque}, {2})", Damage(ataque, 2).ToString());
                table.AddRow($"CriticalHit({Damage(ataque, 2)})", "6");
            }

            AnsiConsole.Write(table);
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
            int fact;

            if (damage <= 0)
            {
                fact = 0;
            }
            else
            {

                fact = 1 + CriticalHit(1 - damage);
            }
            return fact;
        }


    }
}
