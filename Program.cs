using System;

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
    }
}
