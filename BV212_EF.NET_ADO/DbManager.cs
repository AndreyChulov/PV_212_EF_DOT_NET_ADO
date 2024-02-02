using BV212_EF.NET_ADO.DataBase;
using BV212_EF.NET_ADO.DataBase.Tables;

namespace BV212_EF.NET_ADO;

public class DbManager : IDisposable
{
   private const string HorizontalLine = "======================================";
   private OrdersDB _database = new OrdersDB();

   public void PopulateTasks()
   {
      Console.WriteLine(HorizontalLine);
      Console.WriteLine("Please populate [Tasks] table:");
      InsertTask();
      Console.WriteLine("Populating [Tasks] table finished.");
      Console.WriteLine(HorizontalLine);
  
   }

   public void InsertTask()
   {
      Console.WriteLine("Please populate [Tasks] row:");
      Console.WriteLine("Please write data in [Name] way:");
      var taskRow = new TaskRow();
      var name = Console.ReadLine();

      if (string.IsNullOrEmpty(name))
      {
         Console.WriteLine("Populating [Tasks] row finished.");
      }
      else
      {
         taskRow.Name = name;
         _database.Tasks.Add(taskRow);
         InsertTask();
      }
   }
   
   public void Dispose()
   {
   }
}