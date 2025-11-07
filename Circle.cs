// Task 2: Constants  [ 5 Minutes ]
// Create a class named Circle.
// Inside the class, declare a constant variable named PI and initialize it with the value 3.14.
// In the Main() method of Program.cs,
// Try to modify the value of PI of the Circle class and observe the compilation error and explain the error. 
// Additionally, you can create methods to calculate area and perimeter of the circle.

using System;

class Circle
{
    public const double PI = 3.14;
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return PI * Radius * Radius;
    }

    public double GetPerimeter()
    {
        return 2 * PI * Radius;
    }
}
