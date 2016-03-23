/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace InterfaceApplication
{
    /// <summary> 
    /// IAnimal interface...
    /// </summary>
    interface IAnimal
    {
        string Name { get; set; }
        string Talk();
    }
}
