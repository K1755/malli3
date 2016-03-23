/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace AbstactApplication
{
    /// <summary> 
    /// DrawingObject class...
    /// </summary>

    abstract class DrawingObject
    {
        public string Name { get; set; }

        public DrawingObject()
        {
        }

        public DrawingObject(string name)
        {
            Name = name;
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something!");
        }

        public abstract void Draw();
    }
}
