/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace CarWithTyresApplication
{
    /// <summary> 
    /// Tyre class...
    /// </summary>
    class Tyre
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string TyreSize { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Model:" + Model + " TyreSize:" + TyreSize;
        }
    }
}
