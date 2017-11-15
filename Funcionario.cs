using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTrabalho.Model
{
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Funcionário")]
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35, ErrorMessage = "Tamanho tem que ser no máximo 35 caracteres")]
        public string nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Campo obrigatório e somente números")]
        public Double tel { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "O campo deve ter no máximo 50 caracteres")]
        public string endereco { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(35, ErrorMessage = "O campo deve ter no máximo 35 caracteres")]
        public string bairro { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(35, ErrorMessage = "O campo deve ter no máximo 35 caracteres")]
        public string cidade { get; set; }

        [Display(Name = "Unidade Federal")]
        [Required(ErrorMessage = "Campo UF é obrigatório")]
        [StringLength(2, ErrorMessage = "Campo UF tem no máximo 2 caracteres")]
        [MinLength(2, ErrorMessage = "Tem que ter no mínimo 2 caracteres")]
        public string uf { get; set; }
    }
}
