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
    /// Adult class...
    /// </summary>
    class Adult : Human
    {
        public string Car { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Walk!");
        }
    }
}
