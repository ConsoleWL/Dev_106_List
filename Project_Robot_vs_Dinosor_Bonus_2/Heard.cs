﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosor_Bonus_2
{
    public class Heard
    {
        public Dinosaur dinosaur1;
        public Dinosaur dinosaur2;
        public Dinosaur dinosaur3;
        Random rnd = new Random();

        public Heard(string dinosaur1Name, string dinosaur2Name, string dinosaur3Name)
        {
            dinosaur1 = new Dinosaur(dinosaur1Name);
            dinosaur2 = new Dinosaur(dinosaur2Name);
            dinosaur3 = new Dinosaur(dinosaur3Name);
        }

        public void HeardAtack(Fleet fleet)
        {
            Robot robot1 = fleet.robot1;
            Robot robot2 = fleet.robot2;
            Robot robot3 = fleet.robot3;

            int random = rnd.Next(1, 4);

            //Logic for dinosaur 1
            if (dinosaur1.isAlive == true)
            {
                random = rnd.Next(1, 4);

                if (random == 1)
                {
                    if (robot1.isAlive == true)
                    {
                        dinosaur1.Attack(robot1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        dinosaur1.Attack(robot2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        dinosaur1.Attack(robot3);
                    }
                }
                else if (random == 2)
                {
                    if (robot2.isAlive == true)
                    {
                        dinosaur1.Attack(robot2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        dinosaur1.Attack(robot3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        dinosaur1.Attack(robot1);
                    }

                }
                else if (random == 3)
                {
                    if (robot3.isAlive == true)
                    {
                        dinosaur1.Attack(robot3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        dinosaur1.Attack(robot1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        dinosaur1.Attack(robot2);
                    }
                }
            }

            //Logic for dinosaur 2
            if (dinosaur2.isAlive == true)
            {
                random = rnd.Next(1, 4);

                if (random == 1)
                {
                    if (robot1.isAlive == true)
                    {
                        dinosaur2.Attack(robot1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        dinosaur2.Attack(robot2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        dinosaur2.Attack(robot3);
                    }
                }
                else if (random == 2)
                {
                    if (robot2.isAlive == true)
                    {
                        dinosaur2.Attack(robot2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        dinosaur2.Attack(robot3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        dinosaur2.Attack(robot1);
                    }

                }
                else if (random == 3)
                {
                    if (robot3.isAlive == true)
                    {
                        dinosaur2.Attack(robot3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        dinosaur2.Attack(robot1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        dinosaur2.Attack(robot2);
                    }
                }
            }

            //Logic for dinosaur 3
            if (dinosaur3.isAlive == true)
            {
                random = rnd.Next(1, 4);

                if (random == 1)
                {
                    if (robot1.isAlive == true)
                    {
                        dinosaur3.Attack(robot1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        dinosaur3.Attack(robot2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        dinosaur3.Attack(robot3);
                    }
                }
                else if (random == 2)
                {
                    if (robot2.isAlive == true)
                    {
                        dinosaur3.Attack(robot2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        dinosaur3.Attack(robot3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        dinosaur3.Attack(robot1);
                    }

                }
                else if (random == 3)
                {
                    if (robot3.isAlive == true)
                    {
                        dinosaur3.Attack(robot3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        dinosaur3.Attack(robot2);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        dinosaur3.Attack(robot1);
                    }
                }
            }
        }
    }
}
