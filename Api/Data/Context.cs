using Microsoft.EntityFrameworkCore;

namespace Crud.Api.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Tarefas> TaksRegister { get; set; }
    }


}