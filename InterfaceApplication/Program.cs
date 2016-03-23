/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace InterfaceApplication
{
    /// <summary> 
    /// This class demonstrates Cat and Dog classes. OOP learning.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Mirre";
            Console.WriteLine("Here is {0}: {1}", cat.Name, cat.Talk());

            Dog dog = new Dog { Name = "Musti" };
            Console.WriteLine("Here is {0}: {1}", dog.Name, dog.Talk());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadKey();
        }
    }
}
