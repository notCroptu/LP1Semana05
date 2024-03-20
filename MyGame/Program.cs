﻿using System;
using System.Text;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
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

        }
    }
}
