using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Cliente.Models
{
    public class Ufs
    {
        [Key]
        [Display(Name ="Id - Identificação do Sistema")]
        [Column(TypeName ="int")]
        public int Id { get; set; }
        [Display(Name = "Código")]
        [Column(TypeName = "varchar(2)")]
        public string codigo { get; set; }
        [Display(Name = "Nome")]
        [Column(TypeName = "varchar(30)")]
        public string nome { get; set; } 
        [Display(Name = "Vigência Inicial")]
        [Column(TypeName = "DateTime")]
        public DateTime? vigencia_ini { get; set; }
        [Display(Name = "Vigência Fim")]
        [Column(TypeName = "DateTime")]
        public DateTime? vigencia_fim { get; set; }

    }
}
