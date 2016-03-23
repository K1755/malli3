/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace CarWithTyresApplication
{
    /// <summary> 
    /// This class demonstrates Vehicle and Tyre classes. OOP learning.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create tyre
            Tyre tyre1 = new Tyre { Name = "Nokia", Model = "Hakkapeliitta", TyreSize = "205R16" };
            // create a car
            Vehicle car = new Vehicle { Name = "Porsche", Model = "911" };
            Console.WriteLine("Created a new vehichle {0} model {1}", car.Name, car.Model);
            car.AddTyre(tyre1);
            car.AddTyre(tyre1);
            car.AddTyre(tyre1);
            car.AddTyre(tyre1);
            Console.WriteLine(car.ToString());
            
            // create motorbike
            Vehicle bike = new Vehicle { Name = "Ducati", Model = "Diavel" };
            Console.WriteLine("Created a new vehichle {0} model {1}", bike.Name, bike.Model);
            // create a tyre
            Tyre tyre2 = new Tyre { Name = "MIC", Model = "Pilot", TyreSize = "160R17" };
            Tyre tyre3 = new Tyre { Name = "MIC", Model = "Pilot", TyreSize = "140R16" };
            bike.AddTyre(tyre2);
            bike.AddTyre(tyre3);
            Console.WriteLine(bike.ToString());

            Console.WriteLine("Press enter key to continue..");
            Console.ReadLine();
        }
    }
}
