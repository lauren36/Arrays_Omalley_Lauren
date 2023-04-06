using System;

namespace Arrays_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Askes the user to enter a whole number for the array size amd assigns it to an integer
            Console.WriteLine("Enter a whole number for the array size");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            for(int i = 0; i < arraySize; i++)
            {
                // Askes user to enter a whold number t
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            // Tells the sum of the array
            Console.WriteLine($"The sum of the array is {sum}");

            // Sorts the numbers from least to greatest 
            Array.Sort(numbers);

            Console.WriteLine("Array:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
