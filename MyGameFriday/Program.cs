using System;
using System.Text;

namespace MyGameFriday
{
    public class Program
    {
        private static void Main()
        {
            GameLevel gl = new GameLevel(101, Difficulty.Easy);

            gl.SetEnemyInRoom(1, new Enemy("Ringo"));
            gl.SetEnemyInRoom(2, new Enemy("Tina"));
            gl.SetEnemyInRoom(18, new Enemy("Faker"));
            gl.SetEnemyInRoom(98, new Enemy("Chet"));
            gl.SetEnemyInRoom(57, new Enemy("Out of order"));

            Console.WriteLine($"Difficulty: {gl.GetDifficulty()}");

            Console.WriteLine($"Number of rooms: {gl.GetNumRooms()}");

            Console.WriteLine($"Number of enemies: {gl.GetNumEnemies()}");

            gl.PrintEnemies();

            // Este programa mostra o seguinte no ecrã:
            //
            // Difficulty: Easy
            // Number of rooms: 101
            // Number of enemies: 5
            // Room 1: Ringo
            // Room 2: Tina
            // Room 18: Faker
            // Room 57: Out of order
            // Room 98: Chet
        }
    }
}