
using CSharpBook;
using CSharpBook.Design_Patterns;
using CSharpBook.SOLID;
using static CSharpBook.EnumsProblem;

Problem problem = Problem.AsyncAwait;

if (problem == Problem.DesignPatterns)
{
    Singleton singleton = Singleton.GetInstance();
}
if (problem == Problem.LINQ)
{
    LINQ lINQ = new LINQ();
    LINQEnums subLINQProblem = LINQEnums.Grup;

    if (subLINQProblem == LINQEnums.Query)
        lINQ.QueryExpression();
    if (subLINQProblem == LINQEnums.ProjectionOperation)
        lINQ.ProjectionOperation();
    if (subLINQProblem == LINQEnums.SortingData)
        lINQ.SortingData();
    if (subLINQProblem == LINQEnums.Join)
        lINQ.Joins();
    if (subLINQProblem == LINQEnums.Grup)
        lINQ.Grup();
}
if (problem == Problem.Workout)
{
    WorkOut objWorkOut = new WorkOut();
    objWorkOut.WorkoutSample3();
}
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

    DelegatesWithParam delegatesWithParam = new DelegatesWithParam();
    delegatesWithParam.MainMethod();
}
else if (problem == Problem.AsyncAwait)
{
    AsyncAwaitExample asyncAwaitExample = new AsyncAwaitExample();
    asyncAwaitExample.MainMethod();

    asyncAwaitExample.TaskExample();

    asyncAwaitExample.ExampleTaskCancellationToken();
}
else if (problem == Problem.Events)
{
    EventExample eventsExample = new EventExample();
    eventsExample.MainMethod();
}
else if (problem == Problem.SOLIDDesignPrinciples)
{
    SOLIDPrinciples principleProblem = SOLIDPrinciples.SOLID_S;
    if (principleProblem == SOLIDPrinciples.SOLID_S)
    {
        SingleResponsibilityPrinciple singleResponsibilityPrinciple = new SingleResponsibilityPrinciple();
        singleResponsibilityPrinciple.MainMethod();
    }
    else if (principleProblem == SOLIDPrinciples.SOLID_O)
    {
        OpenClosePrinciple openCloseObj = new OpenClosePrinciple();
        openCloseObj.MainMethod();
    }
    else if (principleProblem == SOLIDPrinciples.SOLID_L)
    {

    }
    else if (principleProblem == SOLIDPrinciples.SOLID_I)
    {
        InterfaceSegregationPrinciple interfaceSegregationPrinciple = new InterfaceSegregationPrinciple();
        interfaceSegregationPrinciple.MainMethod();
    }
    else if (principleProblem == SOLIDPrinciples.SOLID_D)
    {
        DependencyInversionPrinciple dependencyObj = new DependencyInversionPrinciple();
        dependencyObj.MainMethod();
    }

}
else
{
    Console.WriteLine("NONE");
}