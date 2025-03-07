using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Shared.Models
{
    public enum Tipo_usuario
    {
        Gestor,
        Motorista,
        Admin
    }

    [Table("usuarios")]
    public class Usuario : BaseModel
    {

        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("cpf")]
        public  string Cpf { get; set; } = string.Empty;

        [Column("email")]
        [MaxLength(30)]
        public string Email { get; set; } = string.Empty;
        [Column("tipo_usuario")]
        public string TipoUsuario { get; set; } = string.Empty;


        [Column("eh_motorista")]
        public bool EhMotorista { get; set; } = false;


    }
}

