using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosor_Bonus
{
    public class Weapon
    {
        public string name;
        public int attackPower;

        public Weapon(string name, int attackPower)
        {
            this.name = name;
            this.attackPower = attackPower;
        }
    }
}
