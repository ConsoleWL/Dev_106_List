using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosor_Bonus_2
{
    public class Battlefield
    {
        Heard heard;
        Fleet fleet;
        Random rnd2 = new Random();
        int startFirst;
        string fleetName1;
        string fleetName2;
        string fleetName3;
        string heardName1;
        string heardName2;
        string heardName3;

        int winnerAnnounce;

        public void WelcomeMethod()
        {
            Console.WriteLine("__________                                       __________ ");
            Console.WriteLine("__________     Welcome to the clan battle app!   __________ ");
            Console.WriteLine("__________                                       __________ ");
            Console.WriteLine("__________            Fleet vs Heard             __________ ");
            Console.WriteLine("__________                                       __________ ");
        }

        public void HeardSettings()
        {
            Console.WriteLine("\n__________ Heard, enter name for player number 1:__________ ");
            heardName1 = Console.ReadLine();
            Console.WriteLine("__________ Heard, enter name for player number 2:__________ ");
            heardName2 = Console.ReadLine();
            Console.WriteLine("__________ Heard, enter name for player number 3:__________ ");
            heardName3 = Console.ReadLine();
            heard = new Heard(heardName1, heardName2, heardName3);
            Console.WriteLine("__________ Heard team:__________ ");
            Console.WriteLine($"{heard.dinosaur1.name}");
            Console.WriteLine($"{heard.dinosaur2.name}");
            Console.WriteLine($"{heard.dinosaur3.name}");
        }

        public void FleetSettings()
        {
            Console.WriteLine("\n__________ Fleet, enter name for player number 1:__________ ");
            fleetName1 = Console.ReadLine();
            Console.WriteLine("__________ Fleet, enter name for player number 2:__________ ");
            fleetName2 = Console.ReadLine();
            Console.WriteLine("__________ Fleet, enter name for player number 3:__________ ");
            fleetName3 = Console.ReadLine();
            fleet = new Fleet(fleetName1, fleetName2, fleetName3);
            Console.WriteLine("__________ Fleet team:__________ ");
            Console.WriteLine($"{fleet.robot1.name}");
            Console.WriteLine($"{fleet.robot2.name}");
            Console.WriteLine($"{fleet.robot3.name}");
        }

        public void Settings()
        {
            HeardSettings();
            FleetSettings();
        }

        public int DeterningWhoStarts()
        {
            startFirst = rnd2.Next(1, 3);
            if(startFirst == 1)
            {
                Console.WriteLine("__________ Randizer choose Fleet to start  __________ \n");
                return 1;
            }
            else
            {
                Console.WriteLine("__________ Randizer choose Heard to start  __________ \n");
                return 2;
            }
        }
        public void RoundAnouncement(Fleet fleethp, Heard heardhp)
        {
            if (fleet.robot1.health < 0)
                fleet.robot1.health = 0;
            if (fleet.robot2.health < 0)
                fleet.robot2.health = 0;
            if (fleet.robot3.health < 0)
                fleet.robot3.health = 0;
            if (heard.dinosaur1.health < 0)
                heard.dinosaur1.health = 0;
            if (heard.dinosaur2.health < 0)
                heard.dinosaur2.health = 0;
            if (heard.dinosaur3.health < 0)
                heard.dinosaur3.health = 0;
            Console.WriteLine($"\n Fleet: player1 HP {fleet.robot1.health}  || Heard: player1 HP {heard.dinosaur1.health}");
            Console.WriteLine($" Fleet: player2 HP {fleet.robot2.health}  || Heard: player2 HP {heard.dinosaur2.health}");
            Console.WriteLine($" Fleet: player3 HP {fleet.robot3.health}  || Heard: player3 HP {heard.dinosaur3.health}");
        }
        public void WinnerOfTheGame(int winnerAnnounce)
        {
            if(winnerAnnounce == 1)
            {
                Console.WriteLine("__________                                       __________ ");
                Console.WriteLine("__________          Congratualiations!           __________ ");
                Console.WriteLine("__________                                       __________ ");
                Console.WriteLine("__________         The winner is HEARD!          __________ ");
                Console.WriteLine("__________                                       __________ ");
            }
            else
            {
                Console.WriteLine("__________                                       __________ ");
                Console.WriteLine("__________          Congratualiations!           __________ ");
                Console.WriteLine("__________                                       __________ ");
                Console.WriteLine("__________         The winner is FLEET!          __________ ");
                Console.WriteLine("__________                                       __________ ");
            }
        }

        int winnerOfTheGame;
        public int BattleSequence()
        {
            int start = DeterningWhoStarts();

            if(start == 1)
            {
                while (true)
                {
                    Console.WriteLine("__________            FLEET ATACKS               __________ ");
                    fleet.FleetAtack(heard);
                    RoundAnouncement(fleet, heard);
                    Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("__________            HEARD ATACKS               __________ ");
                    heard.HeardAtack(fleet);
                    RoundAnouncement(fleet, heard);
                    Console.ReadLine();

                    if (fleet.robot1.isAlive == false && fleet.robot2.isAlive == false && fleet.robot3.isAlive == false)
                    {
                        return winnerOfTheGame = 1;
                    }
                    if (heard.dinosaur1.isAlive == false && heard.dinosaur2.isAlive == false && heard.dinosaur3.isAlive == false)
                    {
                        return winnerOfTheGame = 2;
                    }
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("__________            HEARD ATACKS               __________ ");
                    heard.HeardAtack(fleet);
                    RoundAnouncement(fleet, heard);
                    Console.ReadLine();

                    Console.WriteLine("__________            FLEET ATACKS               __________ ");
                    fleet.FleetAtack(heard);
                    RoundAnouncement(fleet, heard);
                    Console.ReadLine();

                    if (fleet.robot1.isAlive == false && fleet.robot2.isAlive == false && fleet.robot3.isAlive == false)
                    {
                        return winnerOfTheGame = 1;
                    }
                    if (heard.dinosaur1.isAlive == false && heard.dinosaur2.isAlive == false && heard.dinosaur3.isAlive == false)
                    {
                        return winnerOfTheGame = 2;
                    }
                }
            }
        }

        public void RunGame()
        {
            WelcomeMethod();
            Settings();
            winnerAnnounce = BattleSequence();
            WinnerOfTheGame(winnerAnnounce);
        }
    }
}
