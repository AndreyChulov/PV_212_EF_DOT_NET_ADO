namespace BV212_EF.NET_ADO.DataBase.Tables;

public class TaskRow
{
   public int Id => _primaryKey.Key;
   public string Name { get; set; }
   
   private readonly PrimaryKey _primaryKey = new PrimaryKey();
}