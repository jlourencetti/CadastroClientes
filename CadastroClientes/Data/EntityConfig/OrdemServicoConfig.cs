using CadastroClientes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroClientes.Data.EntityConfig;

public class OrdemServicoConfig : IEntityTypeConfiguration<OrdemServico>
{
    public void Configure(EntityTypeBuilder<OrdemServico> builder)
    {
        builder.HasKey(a => a.OrdemServicoId);
        builder.HasOne(o => o.Cliente).WithMany(c => c.OrdemServicos).HasForeignKey(o => o.ClienteId);

        builder.ToTable("OrdensServico");
    }
    
}