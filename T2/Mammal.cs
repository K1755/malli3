/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
namespace MammalApplication
{
    /// <summary> 
    /// Mammal class...
    /// </summary>
    abstract class Mammal
    {
        public int Age { get; set; }
        public abstract void Liiku();
    }
}
