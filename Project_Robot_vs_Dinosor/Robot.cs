using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosor
{
    public class Robot
    {
        public string name;
        public int health = 100;
        public Weapon activeWeapon;

        public Robot(string name)
        {
            this.name = name;
            activeWeapon = new Weapon();
        }

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= activeWeapon.attackPower;

            Console.WriteLine($"{name} attacks  {dinosaur.name} for [{activeWeapon.attackPower}]");

            if (dinosaur.health > 0)
            {
                Console.WriteLine($"<{dinosaur.name}> has now HP:{dinosaur.health}");
            }
            else
            {
                Console.WriteLine($"{dinosaur.name} is DEAD!\n");
            }
        }
  
    }
}
