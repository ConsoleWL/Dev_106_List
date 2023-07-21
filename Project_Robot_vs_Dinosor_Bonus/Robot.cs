using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosor_Bonus
{
    public class Robot
    {
        public string name;
        public int health = 100;

        public Weapon activeBluster;
        public Weapon activeLaserGun;
        public Weapon activeCanon;

        public Weapon finalWeapon;
        List<Weapon> weapons = new List<Weapon>();

        public Robot(string name)
        {
            this.name = name;

            activeBluster = new Weapon("Bluster", 15);
            activeLaserGun = new Weapon("LaserGun", 11);
            activeCanon = new Weapon("Canon", 20);
            weapons.Add(activeBluster);
            weapons.Add(activeLaserGun);
            weapons.Add(activeCanon);
        }

        public void ChooseAWeapon()
        {
            string choseOfWeapon;
            Console.WriteLine($"Choose a weapon for a {name}");

            while (true)
            {
                for (int i = 1; i <= weapons.Count; i++)
                {
                    Console.WriteLine($"Press {i} - {weapons[i - 1].name}");
                }

                choseOfWeapon = Console.ReadLine();

                if(choseOfWeapon == "1" || choseOfWeapon == "2" || choseOfWeapon == "3")
                {
                    break;
                }
                {
                    Console.WriteLine("\n***** Wrong input, must be 1,2 or 3 *****");
                }
            }

            switch (choseOfWeapon)
            {
                case "1":
                    finalWeapon = weapons[0];
                    break;
                case "2":
                    finalWeapon = weapons[1];
                    break;
                case "3":
                    finalWeapon = weapons[2];
                    break;
            }
        }

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= finalWeapon.attackPower;

            Console.WriteLine($"{name} attacks  {dinosaur.name} for [{finalWeapon.attackPower}]");

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
