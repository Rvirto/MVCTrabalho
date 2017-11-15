using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Model
{
    public class Pedidos
    {
        public Pedidos()
        {
            this.Produtos = new HashSet<Produtos>();
            this.Clientes = new HashSet<Cliente>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        public int clienteID { get; set; }
        [ForeignKey("cliente")]
        public virtual Cliente cliente { get; set; }
        public virtual string Nomecliente { get { return cliente.nome; } }

        public int produtoID {get; set;}
        [ForeignKey("produto")]
        public virtual Produtos produto { get; set; }
        public virtual string Nomeproduto { get { return produto.descricao; } }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int quantidade { get; set; }


        [Display(Name = "Lista de Produtos")]
        public virtual ICollection<Produtos> Produtos { get; set; }

        [Display(Name = "Lista de Clientes")]
        public virtual ICollection<Cliente> Clientes { get; set; }

    }
}
