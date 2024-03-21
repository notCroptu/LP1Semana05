using System;
using System.Text;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int powerUps;

        static Enemy()
        {
            powerUps = 0;
        }
        public Enemy(string name)
        {
            this.name = SetName(name); // name o c u l t a t h i s . name
            health = 100;
            shield = 0;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damagestilltoinflict = -shield;
                shield = 0;
                health -= damagestilltoinflict;
                if (health < 0) health = 0;
            }
        }
        public string SetName(string name)
        {
            if (name.Length > 8)
            {
            StringBuilder buildernewname = new StringBuilder(name, 0, 8, 50);
            name = buildernewname.ToString();
            }
            return name;
        }
        public void PickupPowerUp(PowerUp powerup, float value)
        {
            if (powerup == PowerUp.Health)
            {
                this.health += value;
                if (this.health > 100) this.health = 100;
            }
            else if (powerup == PowerUp.Shield)
            {
                this.shield += value;
                if (this.shield > 100) this.shield = 100;
            }

            powerUps += 1;
        }
        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }
        public string GetName()
        {
            return name;
        }
        public static int GetPowerUps()
        {
            return powerUps;
        }
    }
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
