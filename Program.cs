using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Task 1: User Greeting =====");
            string userName = "Tushar";
            int luckyNumber = 4;
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            Console.WriteLine("\n===== Task 2: Circle =====");
            Circle myCircle = new Circle(5);
            Console.WriteLine($"Area: {myCircle.GetArea()}");
            Console.WriteLine($"Perimeter: {myCircle.GetPerimeter()}");
            // Uncommenting the next line will cause a compile-time error
            // Circle.PI = 3.14159;

            Console.WriteLine("\n===== Task 3: Data Types and Type Conversion =====");
            byte b = 255;
            short s = 32000;
            int i = 42;
            long l = 1234567890;
            float f = 3.14f;
            double d = 3.14159;
            decimal dec = 3.1415926535m;
            char c = 'A';
            bool flag = true;

            // Type conversions
            string intToString = i.ToString();
            double stringToDouble = Convert.ToDouble("3.14");

            // Print all variables
            Console.WriteLine($"byte: {b}");
            Console.WriteLine($"short: {s}");
            Console.WriteLine($"int: {i}");
            Console.WriteLine($"long: {l}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"double: {d}");
            Console.WriteLine($"decimal: {dec}");
            Console.WriteLine($"char: {c}");
            Console.WriteLine($"bool: {flag}");
            Console.WriteLine($"int to string: {intToString}");
            Console.WriteLine($"string \"3.14\" to double: {stringToDouble}");

            Console.WriteLine("\n===== Task 4: Array and Array Methods =====");
            int[] numbers = { 7, 3, 9, 1, 5 };
            Array.Sort(numbers); 
            Array.Reverse(numbers); 
            Console.WriteLine("Array elements:");
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                Console.WriteLine($"Index {idx}: {numbers[idx]}");
            }
            int searchNumber = 5;
            int position = Array.IndexOf(numbers, searchNumber);
            Console.WriteLine($"Position of {searchNumber} in array: {position}");

            Console.WriteLine("\n===== Task 5: DateTime and TimeSpan =====");
            DateTime birthDate = new DateTime(2002, 07, 29); 
            DateTime currentDate = DateTime.Now;
            TimeSpan ageSpan = currentDate - birthDate;
            int ageYears = (int)(ageSpan.TotalDays / 365.25);

            Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current date: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Age in years: {ageYears}");
            DateTime plus10Days = birthDate.AddDays(10);
            Console.WriteLine($"Birthdate + 10 days: {plus10Days.ToShortDateString()}");

            Console.WriteLine("\n===== Task 6: Generic Collections =====");

            List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
            fruits.Add("Orange"); // add new fruit
            fruits.Remove("Banana"); 
            Console.WriteLine("Fruits in list:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Dictionary<int, string> fruitDict = new Dictionary<int, string>
            {
                {1, "Apple"},
                {2, "Banana"},
                {3, "Mango"}
            };
            fruitDict.Add(4, "Orange"); // add new entry
            Console.WriteLine("Fruits in dictionary:");
            foreach (var kvp in fruitDict)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }
        }
    }
}
