using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_1._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }
        public static void runApp()
        {
            string[] students = { "Charlie", "Alice", "Bob",  "David", "Ella", "Jack", "Grace", "Frank", "Henry", "Ivy"  };

            Console.WriteLine("Unsorted Students:");
            DisplayStudents(students);

            BubbleSort(students);

            Console.WriteLine("\nSorted Students:");
            DisplayStudents(students);
        }

        public static void BubbleSort(string[] arr)
        {
            int n = arr.Length;
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (string.Compare(arr[i - 1], arr[i]) > 0)
                    {
                        // Swap the elements
                        string temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
        }

        public static void DisplayStudents(string[] arr)
        {
            foreach (string student in arr)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine();
        }

    }
}
