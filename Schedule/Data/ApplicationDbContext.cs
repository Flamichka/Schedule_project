using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Schedule.Models;

//namespace MvcSql.Domain
namespace Schedule.Data

{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        //public DbSet<SubjectDataModel> Subjects { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //СУКА, Я ПОКОНЧУ С СОБОЙ
            builder.Entity<SubjectDataModel>().HasData(new SubjectDataModel
            {
                Id = 3,
                Name = "Test",
                Type = 3,
                Pz = true,
                Lz = false,
                L = true,
                Teacher1 = "Ivanov I. I.",
                Teacher2 = "Petrov P. P.",
                Teacher3 = "N/A",
                Teacher4 = "N/A"
            });
        }
    }
}
/*
 
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);

    builder.Entity<SubjectDataModel>().HasData(new
    {
        Id = 1,
        Name = "Test",
        Type = 3,
        Pz = true,
        Lz = false,
        L = true,
        Teacher1 = "Ivanov I. I.",
        Teacher2 = "Petrov P. P.",
        Teacher3 = "N/A",
        Teacher4 = "N/A"
    });
}
*/
