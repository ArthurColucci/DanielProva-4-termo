using Microsoft.EntityFrameworkCore;
using DanielProva.Models;

namespace DanielProva.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
