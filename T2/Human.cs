/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace MammalApplication
{
    /// <summary> 
    /// Human class...
    /// </summary>
    class Human : Mammal
    {
        public string Name { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Move!");
        }
        public void grow()
        {
            base.Age++;
        }
    }
}
