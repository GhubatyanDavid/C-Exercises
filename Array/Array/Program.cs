using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 6,3,5,0,2,1,10,11,12 };
            int[] secondArray = { 4,78,5,10,3,0,1,11 };
            string[] finalArray = new string[firstArray.Length];
            bool firstNumberDone = false;
            int counter = 0;
            int i = 0;

            for (; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (!firstNumberDone || finalArray[i] == null)
                    {
                        if (firstArray[i] == secondArray[j])
                        {
                            finalArray[counter++] = Convert.ToString(firstArray[i]);
                            firstNumberDone = true;
                        }
                    }
                    if (firstNumberDone)
                    {
                        if (firstArray[i] == secondArray[j]  && finalArray[counter-1] == Convert.ToString(firstArray[i-1]))
                        {
                            finalArray[counter++] = Convert.ToString(firstArray[i]);
                            break;
                        }
                    }
                }
                if (firstNumberDone)
                {
                    if (finalArray[counter-1] != Convert.ToString(firstArray[i]))
                    {
                        RemoveArrayItems(finalArray,counter);
                        counter++;
                    }
                }

            }
            Print(finalArray);
        }
        static void RemoveArrayItems(string[] array, int counter)
        {
            array[counter] = "  ";
        }
        static void Print(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}



