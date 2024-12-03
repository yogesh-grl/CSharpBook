
using CSharpBook;
using CSharpBook.Core;
using CSharpBook.Design_Patterns.Creational_Design_Pattern;
using CSharpBook.LeetCode;
using CSharpBook.LeetCode.ArrayOrString;
using CSharpBook.OOPS;
using CSharpBook.SOLID;
using System.ComponentModel.Design;
using static CSharpBook.EnumsProblem;

Problem problem = Problem.LeetCode;

if (problem == Problem.Core)
{
    CoreSubTopics coreSubTopics = CoreSubTopics.Array;
    if (coreSubTopics == CoreSubTopics.Array)
    {
        ArrayBook arrayBook = new ArrayBook();
        arrayBook.IterateArray();
        arrayBook.InsertElementAtPosition(3, 8);
    }
}
else if (problem == Problem.DesignPatterns)
{
    DesignPatterns designPatterns = DesignPatterns.Prototype;

    if (designPatterns == DesignPatterns.SingleTon)
    {
        Singleton singleton = Singleton.GetInstance();
    }
    else if (designPatterns == DesignPatterns.Prototype)
    {
        Prototype prototype = new Prototype();
        prototype.MainMethod();
    }
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
    //objWorkOut.WorkoutSample3();
    //string rootPath = @"E:\Source Code\Yogesh\C3BrowserApp_BE\QiDataModelTPT\QI_Development\QITestCasesV_2_0_1\BPP_MPP";
    //objWorkOut.GetDirectoriesAndFiles(rootPath);

    //string rootPath1 = @"E:\Projects\Project C3_MPP\Raw data\MPP_Eye_Raw_EYE.bin";//@"C:\GRL\GRL-C3-MP-TPT\SignalFiles\Temp\MPP_Eye_Raw_Chunk_1_EYE.bin";
    //List<int> lsInt = objWorkOut.FindByteCountsBetweenPattern(rootPath1, new byte[] { 0xFF, 0xFF, 0XFF, 0xFF });

    //objWorkOut.cancellationTokenExample();
    //objWorkOut.CSVToJSON();
    objWorkOut.StringExplore();
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
    LeetCodeSubProblem subProblem = LeetCodeSubProblem.ArrayString;
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
        //containsDuplicate.ContainsDuplicateValue(new int[] { 1, 2, 3, 1 });

        //containsDuplicate.IsAnagram("anagram", "nagaram");

        //containsDuplicate.TwoSum(new int[] { -1, -2, -3, -4, -5 }, -8);// 3,2,4 - 6  //2,7,11,15  - 9 

        //containsDuplicate.GroupAnagrams(new[]{""});//(new string[]{"eat","tea","tan","ate","nat","bat"});

        //containsDuplicate.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2);//new[] { 1, 1, 2, 2 }, 2

        //containsDuplicate.PalindromeNumber(-121);

        containsDuplicate.LongestCommonPrefix(new string[] { "flower", "flower", "flower" }); ;//"flower", "flow", "flight"
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