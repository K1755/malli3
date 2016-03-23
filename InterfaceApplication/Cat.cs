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
    /// Cat class...
    /// </summary>
    class Cat : IAnimal
    {
        public string Name { get; set; }

        public string Talk()
        {
            return "Miau!";
        }
    }
}
