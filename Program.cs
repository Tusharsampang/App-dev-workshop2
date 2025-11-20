using System;
<<<<<<< HEAD

// =========================
// ENUM FOR DAY TYPE
// =========================
public enum DayType
{
    Weekday,
    Weekend
}

// =========================
// RECORD FOR BOOK
// =========================
public record Book(string title, string author, double price);

// =========================
// PROGRAM CLASS
// =========================
class Program
{
    static void Main(string[] args)
    {
        // =========================
        // STUDENT OBJECTS
        // =========================
        Student s1 = new Student();
        s1.name = "Tushar";
        s1.age = 22;
        s1.address = "Kathmandu";

        Student s2 = new Student();
        s2.name = "Rahul";
        s2.age = 21;
        s2.address = "Pokhara";

        Console.WriteLine("----- Student 1 -----");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Address: " + s1.address);

        Console.WriteLine("\n----- Student 2 -----");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Address: " + s2.address);

        Console.WriteLine("\nCollege Name: " + Student.collegeName);

        // =========================
        // CALCULATOR
        // =========================
        Calculator calc = new Calculator();

        calc.PrintWelcome();

        int sum = calc.Add(10, 20);
        Console.WriteLine("Addition: " + sum);

        int product1 = calc.Multiply(5, 3);
        Console.WriteLine("Multiply (5 * 3): " + product1);

        int product2 = calc.Multiply(7);
        Console.WriteLine("Multiply (7 * default 1): " + product2);

        // =========================
        // PARAMETER DEMO
        // =========================
        ParameterDemo pd = new ParameterDemo();

        int num = 5;
        pd.Increase(ref num);
        Console.WriteLine("Value after Increase: " + num);

        string fullname;
        pd.GetFullName(out fullname);
        Console.WriteLine("Full Name: " + fullname);

        int total = pd.SumAll(10, 20, 30, 5, 15);
        Console.WriteLine("Sum of all numbers: " + total);

        // =========================
        // PLAYER OBJECTS
        // =========================
        Player p1 = new Player(); // default constructor
        p1.playerName = "Samer";
        p1.level = 50;
        p1.health = 100;

        Console.WriteLine("\n--- Player 1 (Default Constructor) ---");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        Player p2 = new Player("Tushar", 10, 250); // parameterized constructor

        Console.WriteLine("\n--- Player 2 (Parameterized Constructor) ---");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);

        // =========================
        // DAYTYPE ENUM EXAMPLE
        // =========================
        Console.Write("\nEnter a day (e.g., Sunday): ");
        string inputDay = Console.ReadLine().Trim().ToLower();

        DayType dayType;

        if (inputDay == "friday" || inputDay == "saturday")
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine("It is: " + dayType);

        // =========================
        // BOOK RECORD EXAMPLE
        // =========================
        Book book1 = new Book("C# Basics", "John Doe", 999.99);

        Book book2 = book1 with { title = "Advanced C#", price = 1299.50 };

        Console.WriteLine("\n--- Book 1 ---");
        Console.WriteLine(book1);

        var (title, author, price) = book2;
        Console.WriteLine("\n--- Book 2 (Deconstructed) ---");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
=======
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
>>>>>>> d0bbba571cbbef991c2103d940b1af40f729a3bb
    }
}
