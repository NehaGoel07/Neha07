<Query Kind="Statements" />

IList<int> intlist=new List<int>(){30,50,20};
var first=intlist.First();
var first_default=intlist.FirstOrDefault();
Console.WriteLine("first element: "+first);
Console.WriteLine("first or default element: "+first_default);