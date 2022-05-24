using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;


namespace MergeSortvsBucketSort
{
    class Program
    {
        static public void MergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void SortMethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }

        public static void SortBucket(ref int[] input)
        {
            int minValue = input[0];
            int maxValue = input[0];
            int k = 0;

            for (int i = input.Length - 1; i >= 1; i--)
            {
                if (input[i] > maxValue) maxValue = input[i];
                if (input[i] < minValue) minValue = input[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = bucket.Length - 1; i >= 0; i--)
            {
                bucket[i] = new List<int>();
            }

            foreach (int i in input)
            {
                bucket[i - minValue].Add(i);
            }

            foreach (List<int> b in bucket)
            {
                if (b.Count > 0)
                {
                    foreach (int t in b)
                    {
                        input[k] = t;
                        k++;
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };
            int len = numbers.Length;
            
            stopwatch.Start(); // Merge sort süre başladı
            Console.WriteLine("Merge Sort: ");
            SortMethod(numbers, 0, len - 1);

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            
            stopwatch.Stop(); // Merge sort süre bitti
            Console.WriteLine(" | Merge Sort ile sıralamada geçen süre: " + stopwatch.Elapsed);

            int[] sayilar = { 38, 27, 43, 3, 9, 82, 10 };
            Console.WriteLine("Bucket Sort: ");

            stopwatch.Start(); // Bucket sort süre başladı
            SortBucket(ref sayilar);
            foreach (int item in sayilar)
            {
                Console.Write(item + " ");
            }
            stopwatch.Stop(); //Bucket sort süre bitti
            Console.WriteLine(" | Bucket sort ile sıralamada geçen süre: " + stopwatch.Elapsed);

        

        }
    }
}