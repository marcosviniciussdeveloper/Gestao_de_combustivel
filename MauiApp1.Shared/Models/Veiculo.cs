using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Shared.Models
{
    [Table("veiculos")]
    public class Veiculo : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("placa")]
        [MaxLength(10)] 
        public string Placa { get; set; } = string.Empty;

        [Column("modelo")]
        public string Modelo { get; set; } = string.Empty;

        [Column("tipo_combustivel")]
        public string TipoCombustivel { get; set; } = string.Empty;

        [Column("categoria")]
        public string Categoria { get; set; } = string.Empty;

        [Column("ano")]
        public int Ano { get; set; }    

        [Column("marca")]
        public string Marca { get; set; } = string.Empty;   

        [Column("quilometragem_atual")]
        public int QuilometragemAtual { get; set; }
    }
}
