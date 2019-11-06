using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Cliente.Models
{
    public class Paises
    {
        [Key]
        [Column(TypeName ="int")]
        [Display(Name ="Id - Identificação do Sistema")]
        public int Id { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "Código")]
        public int codigo { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Column(TypeName = "DateTime")]
        [Display(Name = "Vigência Inicial")]
        public DateTime? vigencia_ini { get; set; }
        [Column(TypeName = "DateTime")]
        [Display(Name = "Vigência Final")]
        public DateTime? vigencia_fim { get; set; }
    }
}
