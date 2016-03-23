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
    /// Square class...
    /// </summary>
    class Square : DrawingObject
    {
        // You need to implement Draw()-method!
        public override void Draw()
        {
            Console.WriteLine("Draw Square!");
        }
    }
}
