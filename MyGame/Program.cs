using System;
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
            StringBuilder newname = new StringBuilder(name, 0, 8, 50);
            return newname.ToString();
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
            Enemy slime = new Enemy("slime6789-10-11");
            Console.WriteLine(slime.GetName());
        }
    }
}
