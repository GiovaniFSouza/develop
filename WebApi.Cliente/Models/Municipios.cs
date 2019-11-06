using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Cliente.Models
{
    public class Municipios
    {
        [Key]
        [Display(Name ="Id - Identificação do Sistema")]
        [Column(TypeName ="int")]
        public int Id { get; set; }
        [Display(Name = "Código")]
        [Column(TypeName = "varchar(5)")]
        public string codigo { get; set; }        
        [Display(Name = "Nome")]
        [Column(TypeName = "varchar(50)")]
        public string nome { get; set; }    
        [Display(Name = "Código da Uf")]
        [Column(TypeName = "int")]
        public int uf { get; set; }
        [Display(Name = "Vigência Inicial")]
        [Column(TypeName = "DateTime")]
        public DateTime? vigencia_ini { get; set; }
        [Display(Name = "Vigência Final")]
        [Column(TypeName = "DateTime")]
        public DateTime? vigencia_fim { get; set; }

    }
}
