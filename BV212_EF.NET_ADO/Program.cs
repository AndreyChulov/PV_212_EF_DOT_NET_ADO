// See https://aka.ms/new-console-template for more information

using BV212_EF.NET_ADO;

Console.WriteLine("Hello, World!");

using (var dbManager = new DbManager())
{
   dbManager.PopulateTasks(); 
}