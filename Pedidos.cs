using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPadaria.Models
{
    public class Pedidos
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        public int clienteID { get; set; }
        public virtual Cliente cliente { get; set; }
        public virtual string Nomecliente { get { return cliente.nome; } }


        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int quantidade { get; set; }


        public int produtoID { get; set; }
        public virtual Produtos produto { get; set; }
        public virtual string Nomeproduto { get { return produto.descricao; } }

        [DataType(DataType.Currency)]
        public decimal total { get; set; }
    }
}