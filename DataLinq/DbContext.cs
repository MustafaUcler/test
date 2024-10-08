using Microsoft.EntityFrameworkCore;

public class PersonDbContext : DbContext
{
        public DbSet<Person> Persons {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Test;Trusted_Connection=True;");
    }

}