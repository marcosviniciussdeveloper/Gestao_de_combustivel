using Supabase.Postgrest.Attributes;
using ColumnAttribute = Supabase.Postgrest.Attributes.ColumnAttribute;
using TableAttribute = Supabase.Postgrest.Attributes.TableAttribute;
using Supabase.Postgrest.Models;


namespace MauiApp1.Shared.Models
{
    [Table("manutencoes")]
    public class Manutencoes : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("id_veiculo")]
        public Guid IdVeiculo { get; set; }

        [Column("data")]
        public DateTime Data { get; set; } = DateTime.UtcNow;

        [Column("tipo_manutencao")] 
        public string TipoManutencao { get; set; } = string.Empty;

        [Column("descricao")]
        public string Descricao { get; set; } = string.Empty;

        [Column("custo")]
        public decimal Custo { get; set; }

        [Column("nota_fiscal_url")]
        public string? NotaFiscalUrl { get; set; }
    }
}
