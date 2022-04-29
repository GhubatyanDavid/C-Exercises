using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberComnination(); // 1.
            //Palindrome(); //2.
            //GuessNumber(); //3.
            //TowerOfHanoi(5); //4.
        }

        /// <summary>
        /// 1․Գրել ծրագիր, որը տրված թվի թվանշաններով կստանա բոլոր հնարավոր կոմբիացիաներն և կտպի։
        /// </summary>
        static void NumberComnination()
        {
            Console.WriteLine("Please type number!");
            string number = Convert.ToString(Console.ReadLine());
            string wait = new string('*', 20);
            Console.WriteLine(wait);
            Console.WriteLine("Numbers will be`");
            char[] array = number.ToCharArray();
            Combination(array, 0, array.Length - 1);
        }
        static void Combination(char[] array, int i, int length)
        {
            if (i == length)
                Console.WriteLine(array);
            else
            {
                for (int j = i; j <= length; j++)
                {
                    Change(ref array[i], ref array[j]);
                    Combination(array, i + 1, length);
                    Change(ref array[i], ref array[j]);
                }
            }
        }
        static void Change(ref char i, ref char j)
        {
            char number;
            number = i;
            i = j;
            j = number;
        }

        /// <summary>
        /// 2․  Գրել ծրագիր, որը ստուգի արդյոք մուտքագրված բառը Palindrome ։ 
        /// </summary>
        static void Palindrome()
        {
            Console.WriteLine("Please Type the word");
            string palWord = Console.ReadLine();
            char[] word = new char[palWord.Length];
            int j = palWord.Length - 1;
            for (int i = 0; i < palWord.Length; i++, j--)
            {
                word[i] = palWord[j];
            }
            string palindrome = new string(word);
            Print(palWord, palindrome);
        }
        static void Print(string palWord, string palindrome)
        {
            if (palWord == palindrome)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Word is correct Palindrome , Your word ` {palWord} , Palindrome word `{palindrome}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Sorry your word not Palindrome! , Your word ` {palWord}");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// 3․ Գրել ծրագիր , որը հնարավորություն կտա համակարգչին գտնել Ձեր մտապահած թիվը; 
        /// </summary>
        static void GuessNumber()
        {
            Console.WriteLine("Think about a number between 1-10 and let me guess.");
            int number = 5;
            string str = new string('*', 10);
            Console.WriteLine(str);
            Console.WriteLine($"If your number is`{number} please type 1 if not type 2");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oh yes, i'm genius");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"if your number bigger then {number} please type 1 if smaller press 2");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Console.WriteLine("if your number bigger  then 5 and smaller then 8 please type 1 if not type 2");
                    int secondInput = Convert.ToInt32(Console.ReadLine());
                    if (secondInput == 1)
                    {
                        Console.WriteLine("if your number is 6 press 1 if not press 2");
                        if (Convert.ToInt32(Console.ReadLine()) == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Oh yes, i'm genius");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Your number is 7");
                            Console.ResetColor();
                        }
                    }
                    if (secondInput == 2)
                    {
                        Console.WriteLine("if your number bigger  then 7 and smaller then 10 please type 1 if not type 2");
                        if (Convert.ToInt32(Console.ReadLine()) == 1)
                        {
                            Console.WriteLine("if your number is 8 press 1 if not press 2");
                            if (Convert.ToInt32(Console.Read()) == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Oh yes, i'm genius");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Your number is 9");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Your number is 10 :)");
                            Console.ResetColor();
                        }
                    }

                }
                else if (input == 2)
                {
                    Console.WriteLine("if your number bigger  then 1 and smaller then 4 please type 1 if not type 2");
                    int secondInput = Convert.ToInt32(Console.ReadLine());
                    if (secondInput == 2)
                    {
                        Console.WriteLine("if your number is 2 press 1 if not press 2");
                        if (Convert.ToInt32(Console.Read()) == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Oh yes, i'm genius");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Your number is 3");
                            Console.ResetColor();
                        }
                    }
                    if (secondInput == 1)
                    {
                        Console.WriteLine("if your number bigger  thn 3 and smaller then 5 please type 1 if not type 2");
                        if (Convert.ToInt32(Console.ReadLine()) == 1)
                        {
                            Console.WriteLine("if your number is 4 press 1 if not press 2");
                            if (Convert.ToInt32(Console.Read()) == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Oh yes, i'm genius");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Your number is 5");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Your number is 1 :)");
                            Console.ResetColor();
                        }
                    }

                }
            }
        }


        /// <summary>
        /// 4․ Tower of Hanoi։Գրել ծրագիր, որը կամայական n թվի համար կհաշվի թե ամենաքիչը քանի քայլում կարող ենք օվալները մի սյունից տեղափոխել մյուսը։ 
        /// </summary>
        static void TowerOfHanoi(int roundlyNumber)
        {
            string firstRonudly = "Pole 1";
            string endRoundly = "Pole 3";
            string secondRoundly = "Pole 2 ";

            Hanoi(roundlyNumber, firstRonudly, endRoundly, secondRoundly);
        }
        private static void Hanoi(int roundlyNumber, string firstRoundly, string endRoundly, string secondRoundly)
        {
            if (roundlyNumber > 0)
            {
                Hanoi(roundlyNumber - 1, firstRoundly, secondRoundly, endRoundly);
                Console.WriteLine($"Move disk from   {firstRoundly}  to  {endRoundly}");
                Hanoi(roundlyNumber - 1, secondRoundly, endRoundly, firstRoundly);
            }
        }
    }
}
