using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] secondArray = { 2, 3, 4, 10, 5, 6, 7, 12, 13 };
            string[] finalArray = new string[firstArray.Length];
            bool result = false;
            int counter = 0;
            int i = 0;

            for (; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        finalArray[counter++] = Convert.ToString(firstArray[i]);
                        result = true;
                        break;
                    }
                }
                if (result == true)
                {
                    i++;
                    break;
                }
            }
            for (; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j] & finalArray[counter - 1] == Convert.ToString(firstArray[i - 1]))
                    {
                        finalArray[counter++] = Convert.ToString(firstArray[i]);
                        result = true;
                        break;
                    }
                }
            }
            for (int k = 0; k < finalArray.Length; k++)
            {
                Console.WriteLine(finalArray[k]);
            }
        }
    }
}


