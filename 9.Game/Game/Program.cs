using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Welcome!");
            Console.WriteLine("You have 1-10 doors please type Door number");
            int door;
            int playerPower = 25;
            int monsterPower = 0;
            int fight = 0;
            do
            {
                string doorNumber = Console.ReadLine();
                bool doorCheck = int.TryParse(doorNumber, out door);
                switch (door)
                {
                    case 1:
                        playerPower = r.Next(10, 80);
                        break;
                    case 2:
                        monsterPower = r.Next(5, 150);
                        break;
                    case 3:
                        playerPower = r.Next(10, 80);
                        break;
                    case 4:
                        monsterPower = r.Next(5, 150);
                        break;
                    case 5:
                        playerPower = r.Next(10, 80);
                        break;
                    case 6:
                        playerPower = r.Next(10, 80);
                        break;
                    case 7:
                        monsterPower = r.Next(5, 150);
                        break;
                    case 8:
                        monsterPower = r.Next(5, 150);
                        break;
                    case 9:
                        playerPower = r.Next(10, 80);
                        break;
                    case 10:
                        monsterPower = r.Next(5, 150);
                        break;
                }
                if (playerPower > 0)
                {
                    fight = fight + playerPower - monsterPower;
                    Console.WriteLine("Player Power`{0}                                 Monster Power`{1}", fight, monsterPower);
                    if (fight > 0)
                    {
                        Console.WriteLine("Player WIN,player power is`{0}", fight);
                        Console.WriteLine("please choose another door!");
                    }

                    else
                        Console.WriteLine("Player Loss :(");
                }
            } while (fight > 0);
        }
    }
}
