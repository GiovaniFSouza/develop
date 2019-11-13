using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Cliente.Models
{
    public class CodUfxUfs
    {
        
        public int Id { get; set; }
        public string nome { get; set; }
#pragma warning disable IDE1006 // Naming Styles
        public string sigla { get; set; }
#pragma warning restore IDE1006 // Naming Styles

    }
}
