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
    /// Baby class...
    /// </summary>
    class Baby : Human
    {
        public string Diaper { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Crawl!");
        }
    }
}
