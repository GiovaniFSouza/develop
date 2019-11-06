using Microsoft.EntityFrameworkCore;

namespace WebApi.Cliente.Models
{
    public class PfjContext : DbContext
    {
        public PfjContext(DbContextOptions<PfjContext> options) : base(options)
        {

        }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<CodUf> CodUf { get; set; }
        public DbSet<Ufs> Ufs { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Municipios> Municipios { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<Profissao> Profissao { get; set; }
        public DbSet<CodUfxUfs> CodUfxUfs { get; set; }
    }
}
