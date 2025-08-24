using System;

namespace c_array_max_min_sum_avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 44, 66, 77, 88, 876, 43 };

            int min = arr[0];
            int max = arr[0];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
                sum += arr[i];
            }

            double avg = (double)sum / arr.Length;

            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
        }
    }
}
