namespace CadastroClientes.Models;

public class OrdemServico
{
    public int OrdemServicoId { get; set; }
    public string Descricao { get; set; }
    public string ArmacaoModelo { get; set; }
    public string ArmacaoCor { get; set; }
    public string LenteTipo { get; set; }
    public double? GrauOlhoEsquerdo { get; set; }
    public double? GrauOlhoDireito { get; set; }
    public double? Adicao { get; set; }
    public DateTime DataCriaco { get; set; } = DateTime.Now;
    public DateTime DataEntrega { get; set; }
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }
    
}