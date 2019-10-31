using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Game
    {
        public bool gameOver = false;
        Player player = new Player();

        public Enemy[] enemies = new Enemy[5];

    }

    class Controller
    {
        public double x, y;
        private int velocity;

        public Controller()
        {
            x = 0;
            y = 0;
            velocity = 5;
        }

        public int Velocity { get => velocity; set => velocity = value; }
    }

    class Player: Controller
    {
        int health;
        bool isDead = false;  
        public Player()
        {
            x = 0;
            y = 0;
            this.Velocity = 8;
        }
        public Player(int x, int y, int velocity)
        {
            this.x = x;
            this.y = y;
            this.Velocity = 8;
        }
    }

    class Enemy : Controller
    {
        int health;
        bool isDead = false;
        public Enemy()
        {
            x = 10;
            y = 10;
            this.Velocity = 5;
        }

        public void Spawned()
        {
            Console.WriteLine("I have Spawned");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.gameOver = true;

            Enemy enemies = new Enemy();
            enemies.Spawned();
            
            Console.ReadLine();
        }
    }
}
