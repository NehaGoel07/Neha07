<Query Kind="Statements" />

IList<int> intlist=new List<int>();
var default_empty=intlist.DefaultIfEmpty();
Console.WriteLine(default_empty);