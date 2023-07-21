using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Robot_vs_Dinosor_Bonus_2
{
    public class Robot
    {
        public string name;
        public int health = 100;
        public Weapon weapon;
        public bool isAlive = false;

        public Robot(string name)
        {
            this.name = name;
            isAlive = true;
            weapon = new Weapon();
        }

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;

            Console.WriteLine($"Player: {name} attacks player:<{dinosaur.name}> ===> with DMG[{weapon.attackPower}]");

            if (dinosaur.health > 0)
            {
            }
            else
            {
                Console.WriteLine($"                                           <{dinosaur.name}> is DEAD!\n");
                dinosaur.isAlive = false;
            }
        }
    }
}

//public void Attack(Dinosaur dinosaur)
//{
//    dinosaur.health -= finalWeapon.attackPower;

//    Console.WriteLine($"{name} attacks  {dinosaur.name} for [{finalWeapon.attackPower}]");

//    if (dinosaur.health > 0)
//    {
//        Console.WriteLine($"<{dinosaur.name}> has now HP:{dinosaur.health}");
//    }
//    else
//    {
//        Console.WriteLine($"{dinosaur.name} is DEAD!\n");
//    }
//}

//public void ChooseAWeapon()
//{
//    string choseOfWeapon;
//    Console.WriteLine($"Choose a weapon for a {name}");

//    while (true)
//    {
//        for (int i = 1; i <= weapons.Count; i++)
//        {
//            Console.WriteLine($"Press {i} - {weapons[i - 1].name}");
//        }

//        choseOfWeapon = Console.ReadLine();

//        if (choseOfWeapon == "1" || choseOfWeapon == "2" || choseOfWeapon == "3")
//        {
//            break;
//        }
//        {
//            Console.WriteLine("\n***** Wrong input, must be 1,2 or 3 *****");
//        }
//    }

//    switch (choseOfWeapon)
//    {
//        case "1":
//            finalWeapon = weapons[0];
//            break;
//        case "2":
//            finalWeapon = weapons[1];
//            break;
//        case "3":
//            finalWeapon = weapons[2];
//            break;
//    }
//}