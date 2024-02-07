using BV212_EF.NET_ADO.DataBase.Tables;
using Microsoft.EntityFrameworkCore;

namespace BV212_EF.NET_ADO.DataBase;

public class OrdersDB : DbContext
{
    public DbSet<OrderRow> Orders { get; set; }
    public DbSet<PriceRow> Price { get; set; }
    public DbSet<TaskRow> Tasks { get; set; }

    public OrdersDB()
    {
        //Orders = new List<OrderRow>();
        //Price = new List<PriceRow>();
        //Tasks = new List<TaskRow>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=db.sqlite");
        }
        
    }
}