namespace CadastroClientes.Models;

public class Cliente
{
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string? CEP { get; set; }
    public virtual ICollection<OrdemServico> OrdemServicos { get; set; }
    
}