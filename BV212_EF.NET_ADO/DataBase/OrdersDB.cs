using BV212_EF.NET_ADO.DataBase.Tables;

namespace BV212_EF.NET_ADO.DataBase;

public class OrdersDB
{
    public List<OrderRow> Orders { get; set; }
    public List<PriceRow> Price { get; set; }
    public List<TaskRow> Tasks { get; set; }
}