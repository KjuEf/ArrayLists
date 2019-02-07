using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 20, 8, 30, 15, 7, 3, 40, 100 };

            // Length()
            Console.WriteLine(" Length " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 7);

            Console.WriteLine(index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effects of clear method: ");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effects of copy method: ");
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effects of sort method: ");
            foreach(var n in numbers)
                Console.WriteLine(n);


            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effects of reverse method: ");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //----------


            Console.WriteLine("Lists");
            var numbers1 = new List<int>() { 7, 4, 15, 20, 1, 3 };

            // Add()
            numbers1.Add(1);

            // AddRange()
            numbers1.AddRange(new int[2] { 2, 5 });

            // IndexOf()
            var nub7 = numbers1.IndexOf(20);
                Console.WriteLine("Index of 7: " + nub7);

            // LastIndexOf()
            Console.WriteLine("Last index of 1: " + numbers1.LastIndexOf(1));

            // Count()
            Console.WriteLine("Count " + numbers1.Count);

            // Remove()
            for (var i = 0; i < numbers1.Count; i++)
            {
                if (numbers1[i] == 1)
                    numbers1.Remove(numbers1[i]);
            }

           // foreach(var number in numbers1)
             //   Console.WriteLine(number);

            // Sort()
            numbers1.Sort();
            foreach (var number in numbers1)
                Console.WriteLine(number);

            // Clear()
            numbers1.Clear();
            Console.WriteLine("Count " + numbers1.Count);

        }
    }
}
