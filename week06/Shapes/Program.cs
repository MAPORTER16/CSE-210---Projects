using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        //Add different shapes to the list
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));
        
        //Iterate through the list and display each shapes info
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}