﻿
using CSharpBook;
using CSharpBook.Design_Patterns;
using CSharpBook.LeetCode;
using CSharpBook.LeetCode.ArrayOrString;
using CSharpBook.OOPS;
using CSharpBook.SOLID;
using static CSharpBook.EnumsProblem;

Problem problem = Problem.LeetCode;

if (problem == Problem.DesignPatterns)
{
    Singleton singleton = Singleton.GetInstance();
}
else if (problem == Problem.LINQ)
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
else if (problem == Problem.Workout)
{
    WorkOut objWorkOut = new WorkOut();
    objWorkOut.WorkoutSample3();
}
else if (problem == Problem.AbstractClass)
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
else if (problem == Problem.Overloading)
{
    Overloading objOverLoading = new Overloading();
    objOverLoading.MainMethod();
}
else if (problem == Problem.Threads)
{
    ThreadSample objThread = new ThreadSample();
    objThread.MainMethod();
}
else if (problem == Problem.LeetCode)
{
    LeetCodeSubProblem subProblem = LeetCodeSubProblem.Solve;
    if (subProblem == LeetCodeSubProblem.BitManipulation)
    {
        BitManipulation bitManipulation = new BitManipulation();
        bitManipulation.AddBinary("11", "1");

        bitManipulation.HammingWeight(00000000000000000000000000001011);
    }
    else if (subProblem == LeetCodeSubProblem.ArrayString)
    {
        MergeSortedArray mergeSortedArray = new MergeSortedArray();
        mergeSortedArray.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6, }, 3);
    }
    else if (subProblem == LeetCodeSubProblem.Solve)
    {
        ContainsDuplicate containsDuplicate = new ContainsDuplicate();
        // containsDuplicate.ContainsDuplicateValue(new int[] { 1, 2, 3, 1 });
        // containsDuplicate.IsAnagram("anagram","nagaram");

        // containsDuplicate.TwoSum(new int[] { -1, -2, -3, -4, -5 }, -8);// 3,2,4 - 6  //2,7,11,15  - 9 

        //containsDuplicate.GroupAnagrams(new[]{""});//(new string[]{"eat","tea","tan","ate","nat","bat"});

        containsDuplicate.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2);//new[] { 1, 1, 2, 2 }, 2
    }
    {
        MergeSortedArray mergeSortedArray = new MergeSortedArray();
        mergeSortedArray.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6, }, 3);
    }
}
else
{
    Console.WriteLine("NONE");
}