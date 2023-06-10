
using CSharpBook;
using static CSharpBook.EnumsProblem;

Problem problem = Problem.Delegates;

if (problem == Problem.AbstractClass)
{
    AbstractClassExample abstractClassExample = new AbstractClassExample();
    abstractClassExample.MainMethod();
}
else if (problem == Problem.Inheritance)
{
    InheritanceExample inheritanceExample = new InheritanceExample();
    inheritanceExample.MainMethod();
}
else if (problem == Problem.Delegates)
{
    Delegates delegates = new Delegates();
    delegates.MainMethod();
}
else
{
    Console.WriteLine("NONE");
}