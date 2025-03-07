using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using ColumnAttribute = Supabase.Postgrest.Attributes.ColumnAttribute;
using TableAttribute = Supabase.Postgrest.Attributes.TableAttribute;

namespace MauiApp1.Shared.Models
{


[Table("abastecimentos")]
public class Abastecimento : BaseModel
{
    [PrimaryKey("id")]
    public Guid Id { get; set; } 

    [Column("veiculo_id")]
    public Guid VeiculoId { get; set; }

    [Column("eh_motorista_id")]
    public Guid MotoristaId { get; set; }

    [Column("veiculo_placa")]
    public string VeiculoPlaca { get; set; } = string.Empty;

    [Column("km_inicial")]
    public int KmInicial { get; set; }

    [Column("localizacao")]
    public string Localizacao { get; set; } = string.Empty;

    [Column("combustivel")]
    public string Combustivel { get; set; } = string.Empty;

    [Column("data")]
    public DateTime? Data { get; set; } 

    [Column("tipo_combustivel")]
    public string TipoCombustivel { get; set; } = string.Empty;

    [Column("litros")]
    public decimal Litros { get; set; }

    [Column("valor")]
    public decimal Valor { get; set; }

    [Column("nota_fiscal_url")]
    public string? NotaFiscalUrl { get; set; } 
}
}
