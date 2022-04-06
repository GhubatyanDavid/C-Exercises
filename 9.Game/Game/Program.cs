using System;

namespace Game
{
    internal class Program
    {
        static int[] doorNumbers = new int[10];
        static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            Random r = new Random();

            Console.WriteLine("Welcome!");

            Console.WriteLine("You have 1-10 doors please type Door number");


            int playerPower = 25;
            int monsterPower = 0;
            int index = 0;

            do
            {
                int playerOrMonster = r.Next(1, 3);
                string doorNumber = Console.ReadLine();
                bool doorCheck = int.TryParse(doorNumber, out int door);

                if (!doorCheck)
                {
                    Console.WriteLine("Please type correct number of the door!");
                    continue;
                }

                if (!CanOpenTheDoor(door)) continue;


                switch (playerOrMonster)
                {
                    case 1:
                        {
                            doorNumbers[index] = door;
                            playerPower += r.Next(10, 80);
                        }
                        break;
                    case 2:
                        {
                            doorNumbers[index] = door;
                            monsterPower = r.Next(5, 150);
                        }
                        break;
                }

                playerPower = playerPower - monsterPower;

                if (playerPower > 0)
                {

                    ShowResultInformation(playerPower, monsterPower, "Player Win the game.\n");

                    Console.WriteLine("please choose next door!\n");

                }
                else
                {
                    ShowResultInformation(playerPower, monsterPower, "Player lost the game.\n");

                    break;
                }

                index++;

                monsterPower = 0;

            } while (index < doorNumbers.Length);

            if (playerPower == monsterPower)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Player win the game. Draw");

                Console.ResetColor();
            }
        }

        public static bool CanOpenTheDoor(int doorNumber)
        {
            for (int i = 0; i < doorNumbers.Length; i++)
            {
                if (doorNumbers[i] == doorNumber)
                {
                    Console.WriteLine("Please choose another door becouse this door is already opened.");
                    return false;
                }
            }
            return true;
        }

        public static void ShowResultInformation(int playerPower,int monsterPower,string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Player Power - {0}         MonsterPower - {1}\n", playerPower, monsterPower);

            Console.ResetColor();

        }

    }
}
