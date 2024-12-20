using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Design_Patterns.Creational_Design_Pattern
{
    /// <summary>
    /// Product class - Complex object 
    /// </summary>
    public class ProductBuilder
    {
        public List<string> lsStrings = new List<string>();
        public ProductBuilder()
        {

        }

        public void Add(string data)
        {
            lsStrings.Add(data);
        }

        public void Show()
        {
            foreach (var data in lsStrings)
            {
                Console.WriteLine(data);
            }
        }
    }

    /// <summary>
    /// Builder class - either abstract or interface
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuilderPartA();
        public abstract void BuilderPartB();
        public abstract ProductBuilder GetResult();
    }

    /// <summary>
    /// Concrete implementation for builder
    /// </summary>
    public class Builder1 : Builder
    {
        ProductBuilder _productBuilder = new ProductBuilder();

        public override void BuilderPartA()
        {
            _productBuilder.Add("Builder1A");
        }

        public override void BuilderPartB()
        {
            _productBuilder.Add("Builder1B");
        }

        public override ProductBuilder GetResult()
        {
            return _productBuilder;
        }
    }

    /// <summary>
    /// Director class 
    /// </summary>
    public class Director
    {
        public void Constrcutor(Builder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }
    }

    /// <summary>
    /// Main Program
    /// </summary>
    internal class BuilderDesignPattern
    {
        public BuilderDesignPattern()
        {

        }

        public void Main()
        {
            Builder builder1 = new Builder1();
            Director director = new Director();

            director.Constrcutor(builder1);
            builder1.GetResult();
        }
    }
}
