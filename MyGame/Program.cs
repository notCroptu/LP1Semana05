using System;
using System.Text;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEn = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[numEn];

            for (int i = 1; i <= numEn; i++)
            {
                Console.Write($"Nome do inimigo {i}: ");
                string name = Console.ReadLine();

                enemies[ i - 1 ] = new Enemy(name);
            }

            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }

            //test
            enemies[0].TakeDamage(20);
            Console.WriteLine($"Health after damage: {enemies[0].GetHealth()}");

            enemies[0].PickupPowerUp(PowerUp.Health, 30);
            Console.WriteLine($"Health after pickup: {enemies[0].GetHealth()}");

            enemies[0].PickupPowerUp(PowerUp.Shield, 20);
            Console.WriteLine($"Shield after pickup: {enemies[0].GetShield()}");

            enemies[1].TakeDamage(20);
            Console.WriteLine($"Health after damage: {enemies[1].GetHealth()}");

            enemies[1].PickupPowerUp(PowerUp.Health, 70);
            Console.WriteLine($"Health after pickup: {enemies[1].GetHealth()}");

            enemies[1].PickupPowerUp(PowerUp.Shield, 10);
            Console.WriteLine($"Shield after pickup: {enemies[1].GetShield()}");
            //end test

            Console.WriteLine(Enemy.GetPowerUps());
        }
    }
}
