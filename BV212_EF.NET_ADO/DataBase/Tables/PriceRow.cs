namespace BV212_EF.NET_ADO.DataBase.Tables;

public class PriceRow
{
   public int Id => _primaryKey.Key;
   public int TaskId { get; set; }
   public int Price { get; set; }
   public short Year { get; set; }
   
   private readonly PrimaryKey _primaryKey = new PrimaryKey();
}