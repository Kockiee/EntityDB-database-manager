using System.Data.Entity;

namespace EntityDBApplication.Models
{
    public class ContaContext : DbContext
    {
        public DbSet<Conta> Contas { get; set; }
    }
}
