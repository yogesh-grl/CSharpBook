using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Design_Patterns.Creational_Design_Pattern
{
    class Sheep
    {
        public string Name { get; set; }

        public string Category { get; set; }
        public Sheep(string name, string category)
        {
            Name = name;
            Category = category;
        }

        //Shallow Copy 
        public Sheep Clone()
        {
            return (Sheep)MemberwiseClone();
        }

        //Deep Copy
        public Sheep DeepCopy()
        {
            Sheep sheep = new Sheep(Name, Category);
            return sheep;
        }
    }


    internal class Prototype
    {
        public Prototype()
        {
        }

        public void MainMethod()
        {
            Sheep sheep = new Sheep("Dolly", "Mountain Sheep");
            Console.WriteLine(sheep.Name + " " + sheep.Category);

            Sheep cloneSheep = sheep.Clone();
            cloneSheep.Name = "Lilly";
            Console.WriteLine(cloneSheep.Name + " " + cloneSheep.Category);
            Console.WriteLine(sheep.Name + " " + sheep.Category);

            Sheep DeepCopy = sheep.DeepCopy();
            DeepCopy.Name = "John";
            Console.WriteLine(DeepCopy.Name + " " + DeepCopy.Category);
            Console.WriteLine(sheep.Name + " " + sheep.Category);
        }
    }
}

