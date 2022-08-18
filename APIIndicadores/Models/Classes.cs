using System.ComponentModel.DataAnnotations.Schema;

namespace APIIndicadores.Models;

public class BolsaValores
{
    public string? Sigla { get; set; }
    public string? NomeBolsa { get; set; }
    public DateTime DataReferencia { get; set; }
    [Column(TypeName = "numeric(10,4)")]
    public decimal Variacao { get; set; }   
}

public class Indicador
{
    public string? Sigla { get; set; }
    public string? NomeIndicador { get; set; }
    public DateTime UltimaAtualizacao { get; set; }
    [Column(TypeName = "numeric(18,4)")]
    public decimal Valor { get; set; }
    
}