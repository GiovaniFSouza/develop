using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Cliente.Models
{
    public class Pessoa
    {
        [Key]
        [Column(TypeName ="int")]
        [Display(Name ="Identificação do Sistema")]
        public int Id { get; set; }
        //[Required(ErrorMessage ="")]
        [Display(Name ="Codigo")]
        [Column(TypeName ="varchar(10)")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "Nome / Razão Social é obrigatório.")]
        [Display(Name = "Nome / Razão Social")]
        [Column(TypeName = "varchar(50)")]
        public string nome { get; set; }
        //[Required]
        [Display(Name = "Nome Fantasia")]
        [Column(TypeName = "varchar(50)")]
        public string apelido { get; set; }
        [Required(ErrorMessage = "Cep é obrigtório.")]
        [Display(Name = "Cep"), DisplayFormat(DataFormatString = "99999-99")]
        [Column(TypeName = "varchar(8)")]
        public string cep { get; set; }
        [Required(ErrorMessage = "Endereço é obrigatório.")]
        [Display(Name = "Endereço")]
        [Column(TypeName = "varchar(70)")]
        public string logradouro { get; set; }
        [Required(ErrorMessage = "Número é obrigatório.")]
        [Display(Name = "Número")]
        [Column(TypeName = "varchar(10)")]
        public string numero { get; set; }
        [Required(ErrorMessage = "Cidade é obrigatório.")]
        [Display(Name = "Cidade")]
        [Column(TypeName = "int")]
        public int municipio { get; set; }
        [Required(ErrorMessage = "Bairro é obrigatório.")]
        [Display(Name = "Bairro")]
        [Column(TypeName = "varchar(50)")]
        public string bairro { get; set; }
        [Required(ErrorMessage = "Estado é obrigatório.")]
        [Display(Name = "Estado")]
        [Column(TypeName = "int")]
        public int estado { get; set; }
        [Required(ErrorMessage = "País é obrigatório.")]
        [Display(Name = "País")]
        [Column(TypeName = "int")]
        public int pais { get; set; }
        //[Required(ErrorMessage = "Etado Cívil é obrigatório.")]
        [Display(Name = "Estado Cívil")]
        [Column(TypeName = "int")]
        public int? estadocivil { get; set; }
        //[Required(ErrorMessage = "Profissão é obrigatório.")]
        [Display(Name = "Profissão")]
        [Column(TypeName = "int")]
        public int? profissao { get; set; }
        //[Required]
        [Display(Name = "Nacionalidade")]
        [Column(TypeName = "varchar(20)")]
        public string nacionalidade { get; set; }
        //[Required]
        [Display(Name = "Data Nascimento")]
        [Column(TypeName = "DateTime")]
        public DateTime? datanascimento { get; set; }
        [Required(ErrorMessage = "Fisíca / Jurídica é obrigatório.")]
        [Display(Name = "Fisíca / Jurídica")]
        [Column(TypeName = "varchar(1)")]
        public string pessoa_fj { get; set; }
        [Required(ErrorMessage = "Cpf / Cnpj é obrigatório.")]
        [Display(Name = "Cpf / Cnpj")] 
        [Column(TypeName = "varchar(15)")]
        public string cpf_cnpj { get; set; }
        //[Required]
        [Display(Name = "Rg")]
        [Column(TypeName = "varchar(18)")]
        public string rg { get; set; }
        //[Required]
        [Display(Name = "Orgão Expedidor")]
        [Column(TypeName = "varchar(6)")]
        public string orgexpe { get; set; }
        [Required(ErrorMessage = "Código Ibge é obrigatório.")]
        [Display(Name = "Codigo Ibge")]
        [Column(TypeName = "varchar(7)")]
        public string codigo_ibge { get; set; }
        //[Required]
        [Display(Name = "Inscrição Estadual")]
        [Column(TypeName = "varchar(18)")]
        public string ie { get; set; }
        //[Required]
        [Display(Name = "Inscrição Municipal")]
        [Column(TypeName = "varchar(18)")]
        public string im { get; set; }
        //[Required]
        [Display(Name = "Importador")]
        [Column(TypeName = "bit")]
        public bool importador { get; set; }
        //[Required]
        [Display(Name = "Telefone")]
        [Column(TypeName = "varchar(12)")]
        public string fone { get; set; }
        //[Required]
        [Display(Name = "Celular")]
        [Column(TypeName = "varchar(12)")]
        public string cel { get; set; }
        [Required(ErrorMessage = "Informe Email válido.")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Column(TypeName = "varchar(100)")]
        public string email { get; set; }
        //[Required]
        [Display(Name = "Complemento")]
        [Column(TypeName = "varchar(50)")]
        public string complemento { get; set; }
        [Display(Name = "Data Cadastro")]
        [Column(TypeName = "DateTime")]
        public DateTime? datacadastro { get; set; }

    }
}
