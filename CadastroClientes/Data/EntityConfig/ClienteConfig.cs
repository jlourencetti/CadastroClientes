using CadastroClientes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroClientes.Data.EntityConfig;

public class ClienteConfig : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.HasKey(a => a.ClienteId);
        builder.HasMany(c => c.OrdemServicos).WithOne(o => o.Cliente).HasForeignKey(o => o.ClienteId);

        builder.ToTable("Clientes");
    }
    
}