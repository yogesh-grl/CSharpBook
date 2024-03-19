using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Design_Patterns
{

    public abstract class AbstractProduct
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract void Description();
    }

    public class Product : AbstractProduct
    {
        public override int Id { get; set; }

        public override string Name { get; set; }

        public override void Description()
        {
            Console.WriteLine($"ID: {Id} - Product: {Name}");
        }
    }

    public class NullObject : AbstractProduct
    {
        public override int Id { get; set; }
        public override string Name { get; set; }

        public override void Description()
        {
            Console.WriteLine($"ID: {Id} - Product: {Name}");
        }
    }


    internal class NullObjectPattern
    {
        List<Product> products = new List<Product>();
        NullObject? ProductNotFound = new NullObject() { Id = -1, Name = "Not Available" };

        public NullObjectPattern()
        {
            products.Add(new Product() { Id = 1, Name = "Laptop" });
            products.Add(new Product() { Id = 2, Name = "Mouse" });
        }

        public AbstractProduct GetProduct(int ID)
        {
            AbstractProduct product = products.Find(x => x.Id == ID);
            return product ?? ProductNotFound;//new Product() { Id=-1, Name = "Not Available"};
        }

        /// <summary>
        /// all this method
        /// </summary>
        public void DisplayProdcut()
        {
            //As the item is available we will get the result as 
            //ID: 1 - Product: Laptop
            AbstractProduct abstractProduct = GetProduct(0);
            Console.WriteLine(abstractProduct.Description);


            //As the item is not availble we will get the result as 
            //ID: -1 - Product: Not Available
            abstractProduct = GetProduct(5);
            Console.WriteLine(abstractProduct.Description);
        }
    }
}
