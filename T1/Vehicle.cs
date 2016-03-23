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
    /// Vehicle class...
    /// </summary>
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        private const int MaxTyres = 4;
        private int TyresCount = 0;
        public Tyre[] Tyres { get; }// = new Tyre[MaxTyres];

        public Vehicle()
        {
            Tyres = new Tyre[MaxTyres];
        }

        public void AddTyre(Tyre tyre)
        {
            if (TyresCount < MaxTyres)
            {
                Tyres[TyresCount] = tyre;
                TyresCount++;
                Console.WriteLine("Tyre {0} added to vehicle {1}", tyre.Name, Name);
            } else
            {
                Console.WriteLine("No room for a new tyres..., sorry!");
            }
        }

        public override string ToString()
        {
            string s = "Vechicle Name: " + Name + " Model:" + Model + "\nTyres:";
            foreach(Tyre tyre in Tyres)
            {
                if (tyre !=null) s += "\n-"+tyre.ToString();
            }
            return s;
        }
    }
}
