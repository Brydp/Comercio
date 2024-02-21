using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Comercio.Models
{
    [Table("Venda")]
    public class Venda
    {

        [Column("Id_Venda")]
        [Display(Name = "Código da Venda")]

        public int Id { get; set; }

        [Column("DataVenda")]
        [Display(Name = "Data da Venda")]

        public int DataVenda { get; set; }
    }
}
