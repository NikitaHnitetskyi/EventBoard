using EventBoardDataAccess.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace EventBoardDataAccess.DataBase
{
    public class EventBoardContext : DbContext
    {
        public EventBoardContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Дипломна робота\DataBase.mdf; Integrated Security = True; Connect Timeout = 30");
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.SponsoredEvents)
                .WithMany(x => x.EventSponsors)
                .UsingEntity<EventSponsor>(
                    eventSponsor => eventSponsor
                    .HasOne<Event>()
                    .WithMany().HasForeignKey(x => x.EventId),
                    eventSponsor => eventSponsor
                    .HasOne<User>()
                    .WithMany()
                    .HasForeignKey(x => x.SponsorId));

            //написать две таких же конфигурации

            base.OnModelCreating(modelBuilder);
        }

    }
}
