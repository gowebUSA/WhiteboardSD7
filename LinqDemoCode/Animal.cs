using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemoCode
{
    class Animal
    {
        public string Name { get; set; }
        public double Weigth { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }
        public Animal(string name = "no name", double wt = 0, double ht = 0)
        {
            Name = name;
            Weigth = wt;
            Height = ht;
        }
        public override string ToString()
        {
            return string.Format($"{Name} weighs {Weigth} lbs and is {Height} in tall.");
        }
    }
}
