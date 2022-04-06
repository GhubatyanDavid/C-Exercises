using System;
using System.Text;
namespace HomeWork2
{
    internal class Program
    {
        string number = "5,6";
        string text = "C#     can    be     used     to     create    a number of different programs and applications ";
        string secondText = " 1 mobile apps, 2 desktop apps, 3 cloud-based services, 4 websites, 5 enterprise  6 software and     games";
        static void Main(string[] args)
        {
            Program program = new Program();

            Fibonachi();//1.
            //ArrayIndexSquare(1,1000);//2.
            //ArrayMinMax(1,1000);//3.
            //MinimalSum(1,1000);//4.
            //MaxAmountArrayElements(1,1000);//5
            //IndexOfEvenNumbers(1,1000);//6
            //SubtractRepeatTwoNumbers(1,1000);//7
            //ArithmeticAverage(1, 1000);//8
            //MatrixDiagonalElements(1, 1000);//10
            //FindMatrixDiaganalsElements(1, 100);11
            //DeleteGaps(program.text);//12
            //RemoveNumber(program.secondText);//13
            //ReplaceRomanNumberals("12");//14
            //LongestWord(program.secondText,program.text);//15
            //Console.WriteLine(PowNumber(3,5));//16
            //Console.WriteLine(Factorial(5));//17
            //TwoNumberResult(5,6);//18
            //SameSymbol(program.text, program.secondText);//20
            //CheckArrayAscendingElements();//21
            //ArraySort();//22
        }
        /// <summary>
        /// 1.Ստեղծեք առաջին n Ֆիբոնաչիի թվերից զանգված:
        /// </summary>
        public static void Fibonachi()
        {
            Console.WriteLine("Please type length of Fibonachi numbers ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] fibonachi = new int[number];
            fibonachi[0] = 0;
            fibonachi[1] = 1;
            for (int i = 2; i < fibonachi.Length; i++)
            {
                fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];

            }
            for (int i = 0; i < fibonachi.Length; i++)
            {
                Console.Write(fibonachi[i]);
                Console.Write(",");
            }

        }

        /// <summary>
        /// 2. Ստեղծեք զանգված, որի յուրաքանչյուր տարրը հավասար է իր index-ի քառակուսուն:
        /// </summary>
        public static void ArrayIndexSquare(int start, int end)
        {
            int[] array = InitializationArray();

            FillArrayWithRandomElements(array, start, end);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)Math.Pow(i, 2);
                PrintNumber(array[i]);
            }
        }
        /// <summary>
        /// 3.Գտե՛ք զանգվածի ամենամեծ և ամենափոքր տարրերի գումարը:
        /// </summary>
        public static void ArrayMinMax(int start, int end)
        {
            int[] array = InitializationArray();

            FillArrayWithRandomElements(array, start, end);

            int max = array[0];
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            int sum = min + max;
            Console.WriteLine($"Minimum Element is`{min} , Maximum Element is`{max} ,The sum of the largest and smallest elements  {sum}");
        }

        /// <summary>
        /// 4.Տրվում է զանգված: Գտեք երկու հարևան տարրեր, որոնց գումարը նվազագույն է
        /// </summary>
        public static void MinimalSum(int start, int end)
        {

            int[] array = InitializationArray();

            FillArrayWithRandomElements(array, start, end);

            int sum = array[0] + array[1];
            int secondSum = 0;

            for (int i = 0; i + 1 < array.Length; i++)
            {
                secondSum = array[i] + array[i + 1];
                if (secondSum < sum)
                    sum = secondSum;
            }

            Console.WriteLine("Array adjacent items  minimal sum is`{0}", sum);
        }

        /// <summary>
        /// 5.Տրվում է զանգված: Գտեք զանգվածի երեք հաջորդական տարրեր, որոնք ունեն առավելագույն գումար:
        /// </summary>
        public static void MaxAmountArrayElements(int start, int end)
        {
            int[] array = InitializationArray();

            FillArrayWithRandomElements(array, start, end);

            int secondSum = 0;

            int sum = 0;

            for (int i = 0; i + 3 < array.Length; i++)
            {
                secondSum = array[i] + array[i + 1] + array[i + 2];
                sum = array[i + 1] + array[i + 2] + array[i + 3];
                if (secondSum < sum)
                    secondSum = sum;
            }

            Console.WriteLine("Max Amount 3 array elements will be `{0}", secondSum);
        }

        /// <summary>
        /// 6.Գտեք զանգվածի զույգ թվերի index-ը:
        /// </summary>
        public static void IndexOfEvenNumbers(int start, int end)
        {
            int[] array = InitializationArray();

            FillArrayWithRandomElements(array, start, end);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    Console.WriteLine("Array Even Number`{0} and Even Number index`{1}", array[i], i);
            }
        }

        /// <summary>
        /// 7. Հեռացրեք զանգվածի բոլոր թվերը, որոնք կրկնվում են ավելի քան երկու անգամ:
        /// </summary>
        public static void SubtractRepeatTwoNumbers(int start, int end)
        {
            int[] array = InitializationArray();

            FillArrayWithRandomElements(array, start, end);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] == array[j] & i != j)
                    {
                        array[j] = 0;
                    }
                }
            }
            Console.WriteLine($"Numbers without subtract `");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// 8. Տրվում է n չափի a զանգված: Կազմե՛ք նույն չափի b նոր զանգված՝ համաձայն հետևյալ կանոնի՝ B k տարրը հավասար է a զանգվածի տարրերի միջին թվաբանականին k-ից n թվերով։
        /// </summary>
        public static void ArithmeticAverage(int start, int end)
        {
            int[] a = InitializationArray();
            int[] b = new int[a.Length];

            FillArrayWithRandomElements(a, start, end);

            PrintArrayElements(a);

            int arithmeticAverage = 0;

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = i; j < b.Length; j++)
                {
                    arithmeticAverage += a[j];
                }
                b[i] = arithmeticAverage / b.Length - i;
                arithmeticAverage = 0;
            }
            PrintArrayElements(b);
        }

        /// <summary>
        /// 10. Տրվում է քառակուսի մատրիցա: Ցուցադրել անկյունագծի տարրերը:
        /// </summary>
        public static void MatrixDiagonalElements(int start, int end)
        {
            Console.WriteLine("Please type Matrix side Length");
            int length = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[length, length];

            FillMatrixWithRandomElements(array, start, end);

            PrintMatrixElements(array);

            Console.WriteLine("");

            Console.WriteLine(new string('-', 100));

            Console.Write("Matrix Dioganal will be`");

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0} , ", array[i, j]);
                    }
                }
            }
        }

        /// <summary>
        /// 11.Տրված է M կարգի քառակուսի մատրիցա: Զրո դարձրեք մատրիցայի այն տարրերը, որոնք գտնվում են և՛ հիմնական անկյունագծից վերև, և՛ երկրորդական անկյունագծից ներքև
        /// </summary>
        public static void FindMatrixDiaganalsElements(int start, int end)
        {
            Console.WriteLine("Please type Matrix side Length");
            int length = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[length, length];

            FillMatrixWithRandomElements(array, start, end);

            PrintMatrixElements(array);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j > i && j + i >= length)
                        PrintNumber(array[i, j]);

                }

            }
            PrintMatrixElements(array);

        }
        /// <summary>
        /// 12. Ջնջել տողի բոլոր հավելյալ բացերը, այսինքն՝ մի շարք հաջորդականբացատներ փոխարինել միայնակ բացատներով: Հեռացրեք ետևի բացատներըպարանի մեջ:
        /// </summary>
        public static void DeleteGaps(string text)
        {
            StringBuilder secondString = new StringBuilder();
            for (int i = 0; i+1 < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    secondString.Append(text[i]);
                }
                else if (text[i] == ' ' & text[i + 1] != ' ')
                {
                    secondString.Append(text[i]);
                }
            }
            Console.WriteLine(secondString);
        }

        /// <summary>
        /// 13. Ջնջել բոլոր թվերը տողի մեջ:
        /// </summary>
        public static void RemoveNumber(string text)
        {
            string secondString = null;
            for (int i = 0; i < text.Length; i++)
            {
                var c = char.IsDigit(text[i]);
                if (c != true)
                    secondString += text[i];
            }
            Console.WriteLine(secondString);
        }

        /// <summary>
        /// 14.Տողը պարունակում է տասնորդական թիվ: Գրի՛ր այդ թիվը և փոխարինիր հռոմեական թվերով։
        /// </summary>
        public static void ReplaceRomanNumberals(string secondText)
        {
            int number = Convert.ToInt32(secondText);
            Console.WriteLine(number);
            Console.WriteLine(ToRoman(number));
        }

        /// <summary>
        ///15. Որոշի՛ր տրված երկու նախադասության ամենաերկար ընդհանուր բառը:
        /// </summary>
        public static void LongestWord(string firstText, string secondText)
        {
            string longText = string.Empty;

            var firstSentence = firstText.Split(' ', ',');

            var secondSentence = secondText.Split(' ', ',');

            int maxLength = firstSentence.Length > secondSentence.Length ? firstSentence.Length : secondSentence.Length;

            for (int i = 0; i < maxLength; i++)
            {
                if (firstSentence.Length > i)
                {
                    if (longText.Length < firstSentence[i].Length)
                    {
                        longText = firstSentence[i];
                    }
                }
                if (secondSentence.Length > i)
                {
                    if (longText.Length < secondSentence[i].Length)
                    {
                        longText = secondSentence[i];
                    }
                }
            }
            Console.WriteLine(longText);
        }

        /// <summary>
        /// 16. Հաշվել թվի n աստիճանը օգտագործելով ռեկուրսիա։
        /// </summary>

        public static int PowNumber(int number, int n)
        {
            return PowRecursion(n, number, number);
        }
        public static int PowRecursion(int n, int number, int imutableNumber)
        {
            if (n == 1)
            {
                return number;
            }
            number = imutableNumber * number;
            n--;
            return PowRecursion(n, number, imutableNumber);
        }

        /// <summary>
        /// 17. Հաշվել թվի ֆակտորիալը օգտագործելով ռեկուրսիա։
        /// </summary>
        static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// 18.Օգտագործելով local function ստեղծել մեթող որը կհաշվի մուտքագրված երկու թվերի արտադրյալը(int, long, double, float…):
        /// </summary>
        public static void TwoNumberResult(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine("The Sum will be` {0}", Sum());
            decimal Sum()
            {
                return firstNumber * secondNumber;
            }
        }

        /// <summary>
        /// 20. Տրված է 2 տող ։ Գտնել նրանց միչև եղած ընդհանուր սիմվոլների քանակը։ Օրինակ “aabbcc” և “adcaa” ընդհանուր սիմվոլների քանակը 3։
        /// </summary>
        public static void SameSymbol(string firstText, string secondText)
        {
            string text = firstText + secondText;
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (!result.Contains(text[i]))
                {
                    result += text[i];
                }
            }
            Console.WriteLine($"Symbols ` {result.Length}");
        }

        /// <summary>
        /// 22. Տրված է միաչափ զանգված։ Տվյալ զանգվածում պատահական ընտրված են այնպիսի դաշտեր , որոնք պատունակում են բացսական արժեք ։ Առանց
        ///Բացսական արժեք ունեցող տարրերը տեղափոխելու զանգվածի դրական արժեք պարունակող տարրերը դասավորել աճման կարգով։
        /// </summary>
        public static void ArraySort()
        {
            int temp = 0;
            int[] a = new int[] { -1, 150, 190, 170, -1, -1, 160, 180 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == -1)
                    {
                        continue;

                    }
                    else if (a[i] != -1)
                    {
                        if (a[i] < a[j])
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }

        /// <summary>
        /// 21․ Տրված է ամբողջ թվերի հաջորդականություն զանգվածի տեսքով։Որոշել արդյոք հաջորդականությունը կլիինի աճող եթե զանգվաից հեռացնենք տարերից որևէ մեկը
        /// </summary>
        public static void CheckArrayAscendingElements()
        {
            int[] array = InitializationArray();
            int[] newArray = new int[array.Length - 1];

            FillArrayWithRandomElements(array, 1, 20);

            PrintArrayElements(array);

            Random rnd = new Random();

            int index = rnd.Next(0, array.Length);
            Console.WriteLine($"Remove Element from position`[{index}], Element value is` {array[index]}");


            for (int i = 0; i < newArray.Length; i++)
            {
                if (i != index)
                {
                    newArray[i] = array[i];
                }
            }

            PrintArrayElements(newArray);

            if (Check(newArray))
            {
                Console.WriteLine("The sequence is increasing");
            }
            else
            {
                Console.WriteLine("The sequence is not increasing");
            }


        }
        public static bool Check(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > min)
                {
                    min = array[i];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        #region Shared

        public static void FillArrayWithRandomElements(int[] array, int start, int end)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(start, end);
            }

        }
        public static void FillMatrixWithRandomElements(int[,] array, int start, int end)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(start, end);
                }
            }

        }
        public static void PrintMatrixElements(int[,] array)
        {
            Console.WriteLine();

            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    PrintNumber(array[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        public static void PrintArrayElements(int[] array)
        {
            Console.WriteLine();

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                PrintNumber(array[i]);
            }

            Console.WriteLine();
        }

        public static void PrintNumber(int number)
        {

            Console.Write(number + "  ");

        }
        public static int[] InitializationArray()
        {
            Console.WriteLine("Please type length of array");
            int number = Convert.ToInt32((Console.ReadLine()));
            int[] array = new int[number];
            return array;
        }
        public static string ToRoman(int number)
        {
            if (number >= 100) return "string.Empty";
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            else return " ";
        }

        #endregion Shared






    }
}
