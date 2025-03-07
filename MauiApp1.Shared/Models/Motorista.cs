using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;


namespace MauiApp1.Shared.Models
{
    [Table("motoristas")]
    public class Motorista : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("cpf")]
        public string Cpf { get; set; } = string.Empty;

        [Column("validade_cnh")]
        public DateTime? ValidadeCnh { get; set; }


        [Column("numero_cnh")]
        public int Numero_Cnh { get; set; } 

        [Column("eh_motorista")]
        public bool EhMotorista { get; set; } = false;
    }
}

    


