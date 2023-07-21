using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosor
{
    public class Dinosaur
    {
        public string name;
        public int health = 100;
        public int attackPower = 10;

        public Dinosaur(string name)
        {
            this.name = name;
        }

        public void Attack(Robot robot)
        {
            robot.health -= attackPower;

            Console.WriteLine($"{name} attacks {robot.name} for [{attackPower}]");

            if (robot.health > 0)
            {
                Console.WriteLine($"<{robot.name}> has now HP:{robot.health}");
            }
            else
            {
                Console.WriteLine($"{robot.name} is DEAD!\n");
            }
        }
    }
}
