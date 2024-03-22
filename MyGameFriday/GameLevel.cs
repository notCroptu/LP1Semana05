using System;
using System.Text;

namespace MyGameFriday
{
    public class GameLevel
    {
        private Difficulty diff;
        private Enemy [] rooms;

        public GameLevel(int numRooms, Difficulty diff)
        {
            this.diff = diff;
            rooms = new Enemy[numRooms];
        }

        public void SetEnemyInRoom(int indice, Enemy enemy)
        {
            rooms[indice] = enemy;
        }
        public void PrintEnemies()
        {
            for (int i = 0; i < GetNumRooms(); i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"Room {i}: {rooms[i].GetName()}");
                }
            }
        }
        public Difficulty GetDifficulty()
        {
            return diff;
        }
        public int GetNumRooms()
        {
            return rooms.Length;
        }
        public int GetNumEnemies()
        {
            int count = 0;
            foreach(Enemy enemy in rooms)
            {
                if (enemy != null)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}