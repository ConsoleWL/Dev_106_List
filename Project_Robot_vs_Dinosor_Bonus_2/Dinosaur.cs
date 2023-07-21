using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosor_Bonus_2
{
    public class Dinosaur
    {
        public string name;
        public int health = 100;
        public int attackPower = 10;
        public bool isAlive = false;

        public Dinosaur(string name)
        {
            this.name = name;
            isAlive = true;
        }

        public void Attack(Robot robot)
        {
            robot.health -= attackPower;

            Console.WriteLine($"Player: {name} attacks player:<{robot.name}> ===> with DMG[{attackPower}]");

            if (robot.health > 0)
            {
            }
            else
            {
                Console.WriteLine($"                                           <{robot.name}> is DEAD!\n");
                robot.isAlive = false;
            }
        }
    }
}

//public void Attack(Robot robot)
//{
//    robot.health -= attackPower;

//    Console.WriteLine($"{name} attacks {robot.name} for [{attackPower}]");

//    if (robot.health > 0)
//    {
//        Console.WriteLine($"<{robot.name}> has now HP:{robot.health}");
//    }
//    else
//    {
//        Console.WriteLine($"{robot.name} is DEAD!\n");
//    }
//}