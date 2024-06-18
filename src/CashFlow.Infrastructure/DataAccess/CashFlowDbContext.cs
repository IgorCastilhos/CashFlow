using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

internal class CashFlowDbContext : DbContext
{
    // Expenses is the name of the table in the database
    // Expense is the entity that will be stored in the Expenses table
    // DbSet is a collection of entities
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflowdb;Uid=root;Pwd=!%My9953;";

        var version = new Version(8, 0, 37);
        var serverVersion = new MySqlServerVersion(version);

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}
