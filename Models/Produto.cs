using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Comercio.Models
{
    [Table("Produto")]
    public class Produto
    {

        [Column("ProdutoId")]
        [Display(Name = "Cód. Produto")]

        public int ProdutoId { get; set; }

        [Column("ProdutoNome")]
        [Display(Name = "Nome do Produto")]

        public string ProdutoNome { get; set; } = string.Empty;

        [Column("ProdutoEstoque")]
        [Display(Name = "Quantidade de Estoque")]

        public string ProdutoEstoque { get; set; } = string.Empty;
    }
}
