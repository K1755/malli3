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
    /// This class demonstrates Human, Adult and Baby classes. OOP learning.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "Kirsi Kernel";
            human.Age = 50;
            human.Liiku(); // Move!

            Adult adult = new Adult();
            adult.Name = "Nikke Husso";
            adult.Age = 40;
            adult.Car = "Jeep";
            adult.Liiku(); // Walk!

            Baby baby = new Baby();
            baby.Name = "Retu";
            baby.Age = 1;
            baby.Diaper = "Bambers";
            baby.Liiku(); // Crawl

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
