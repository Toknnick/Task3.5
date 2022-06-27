using System;

namespace Task3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sizeOfArray = 30;
            int maxValueInArray = 9;
            int[] arrayOfNumbers = new int[30] {0,1,1,1,1,2,2,2,2,2,3,3,3,3,3,4,4,4,4,4,5,6,7,3,2,4,5,6,1,2};
            int repeatingNumber = 0;
            int amountOfRepeat = 1;
            int saveRepeatingNumber = 0;
            Console.WriteLine("Массив:");

            for (int i = 0; i < sizeOfArray; i++)
            {
                //arrayOfNumbers[i] = random.Next(maxValueInArray);
                Console.Write(arrayOfNumbers[i] + " ");
            }

            for (int i = 0; i < arrayOfNumbers.Length - 2; i++)
            {
                if (arrayOfNumbers[i] == arrayOfNumbers[i + 1])
                {
                    repeatingNumber = arrayOfNumbers[i];

                    if (repeatingNumber != arrayOfNumbers[i + 2])
                    {
                        saveRepeatingNumber = repeatingNumber;
                    }
                }
            }

            for (int i = 0; i < sizeOfArray; i++)
            {
                if(saveRepeatingNumber == arrayOfNumbers[i] && saveRepeatingNumber == arrayOfNumbers[i + 1])
                {
                    amountOfRepeat++;
                }
            }

            Console.WriteLine($"\nПовторяющееся число: {saveRepeatingNumber}\nКоличество повторений: {amountOfRepeat}");
        }
    }
}
