using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosor
{
    public class Battlefield
    {
        Dinosaur dinosaur;
        Robot robot;
        public void WelcomeMethod()
        {
            Console.WriteLine("Welcome to the battle  for the ages!\n");
        }

        public void WinnerOfTheGame()
        {
            if (dinosaur.health <= 0)
            {
                Console.WriteLine($"{robot.name} is victorious!");
            }
            else
            {
                Console.WriteLine($"{dinosaur.name} is victorious!");
            }
        }

        public void BattleSequence()
        {

            Console.WriteLine("Choose a name for a Dinasour:");
            string dinosaurName = Console.ReadLine();
            Console.WriteLine("Choose a name for a Robot:");
            string robotName = Console.ReadLine();

            dinosaur = new Dinosaur(dinosaurName);
            robot = new Robot(robotName);

            while(dinosaur.health > 0 ||  robot.health > 0)
            {
                Console.WriteLine();

                dinosaur.Attack(robot);
                
                if(robot.health <= 0)
                {
                    break;
                }

                robot.Attack(dinosaur);

                if (dinosaur.health <= 0)
                {
                    break;
                }
            }
        }

        public void RunGame()
        {
            WelcomeMethod();
            BattleSequence();
            WinnerOfTheGame();
        }
    }
}
