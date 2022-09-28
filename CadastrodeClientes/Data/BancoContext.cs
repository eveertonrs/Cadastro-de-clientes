using CadastrodeCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastrodeCliente.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<ClienteModel> Cliente { get; set; }
    }
}
