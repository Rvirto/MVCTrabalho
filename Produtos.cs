using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPadaria.Models
{
    [Table("Produtos")]
    public class Produtos
    {
       public Produtos()
        {
            this.Pedidos = new HashSet<Pedidos>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Produto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(25, ErrorMessage = "O produto deve ter no máximo 25 caracteres")]
        public string descricao { get; set; }

        [Display(Name = "Unidade")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(15, ErrorMessage = "A unidade deve ter no máximo 15 caracteres")]
        public string unidade { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(0, 100, ErrorMessage = "A quantidade tem de estar no máximo entre 0 e 100")]
        public int quantidade { get; set; }

        [Display(Name = "Valor R$")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Currency)]
        public decimal valor { get; set; }

        [Display(Name = "Lista de Pedidos")]
        public virtual ICollection<Pedidos> Pedidos { get; set; }

    }
}