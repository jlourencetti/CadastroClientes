using CadastroClientes.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CadastroClientes.Data.Context;

public class MySQLContext : DbContext
{
    public MySQLContext() {}
    
    public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClienteConfig());
        modelBuilder.ApplyConfiguration(new OrdemServicoConfig());
    }
}