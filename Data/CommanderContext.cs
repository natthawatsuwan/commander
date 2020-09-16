using Commander.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        { }


        public DbSet<Command> Commands { get; set; }

    }
    /*public class CommanderFactory : IDesignTimeDbContextFactory<CommanderContext>
    {
        public CommanderContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CommanderContext>();
            optionsBuilder.UseSqlServer("CommanderConnection");

            return new CommanderContext(optionsBuilder.Options);
        }
    }*/
   

}