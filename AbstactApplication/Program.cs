/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;
using System.Collections.Generic;

namespace AbstactApplication
{
    /// <summary> 
    /// This class demonstrates Circle and Square classes. OOP learning.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // This doesn't work, object cannot be created from abstract classes
            //DrawingObject do = new DrawingObject();

            Circle circle = new Circle();
            circle.Name = "My Circle";
            circle.Draw();

            Square square = new Square();
            square.Name = "My Square";
            square.Draw();

            List<DrawingObject> drawingObjects = new List<DrawingObject>();
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());

            Console.WriteLine("Loop through all drawing objects in a list:");
            foreach (DrawingObject drawingObject in drawingObjects)
            {
                drawingObject.Draw();
            }

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
