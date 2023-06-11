
using CSharpBook;
using static CSharpBook.EnumsProblem;

Problem problem = Problem.AsyncAwait;

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
else if (problem == Problem.AsyncAwait)
{
    AsyncAwaitExample asyncAwaitExample = new AsyncAwaitExample();
    asyncAwaitExample.MainMethod();
}
else
{
    Console.WriteLine("NONE");
}