using EventBoardApp_.DataBase.Model;
using Microsoft.EntityFrameworkCore;

namespace EventBoardApp_.DataBase
{
    public class RoleContext : DbContext
    {
        public RoleContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Дипломна робота\DataBase.mdf; Integrated Security = True; Connect Timeout = 30");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Visitor> Visitors { get; set; }

        public DbSet<Events> Events { get; set; }




    }
}
