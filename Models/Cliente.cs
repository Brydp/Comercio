using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Comercio.Models
{
    [Table("Cliente")]
    public class Cliente
    {

        [Column("ClienteId")]
        [Display(Name = "Cód. Cliente")]

        public int ClienteId { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do cliente")]

        public string ClienteNome { get; set; } = string.Empty;
    }
}
