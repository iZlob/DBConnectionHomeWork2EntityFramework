using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySqlBuilder;
using MySqlConnector;
using System.Data.Common;


namespace DBConnectionHomeWork2EntityFramework.DB;




public class DataBase : DbContext
{
    public DbSet<Cars> cars { get; set; }
    public DbSet<Orders> orders { get;set; }
    public DbSet<Workers> workers { get; set; }
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var ConnectionStringBuilder = new MySqlConnectionStringBuilder();
        ConnectionStringBuilder.Database = "zlobindatabase";
        ConnectionStringBuilder.Server = "db4free.net";
        ConnectionStringBuilder.Port = 3306;
        ConnectionStringBuilder.UserID = "i_zlobin";
        ConnectionStringBuilder.Password = "Myrtlebeach2007";
        ConnectionStringBuilder.SslMode = MySqlSslMode.Required;

        var connectionString = ConnectionStringBuilder.ConnectionString;
        optionsBuilder.UseMySql(connectionString, new MySqlServerVersion("8.1"));
        base.OnConfiguring(optionsBuilder); 
    }
}