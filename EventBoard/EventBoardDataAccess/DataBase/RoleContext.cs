using EventBoardDataAccess.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace EventBoardDataAccess.DataBase
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
        public DbSet<Event> Events { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EventOrganizer> EventOrganizers { get; set; }
        public DbSet<EventSponsor> EventSponsors { get; set; }
        public DbSet<EventMember> EventMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventOrganizer>()
                .HasKey(eo => new { eo.EventId, eo.UserId });

            modelBuilder.Entity<EventOrganizer>()
                .HasOne(eo => eo.Event)
                .WithMany(e => e.EventOrganizers)
                .HasForeignKey(eo => eo.EventId);

            modelBuilder.Entity<EventOrganizer>()
                .HasOne(eo => eo.User)
                .WithMany(u => u.EventOrganizers)
                .HasForeignKey(eo => eo.UserId);

            modelBuilder.Entity<EventSponsor>()
                .HasKey(es => new { es.Id, es.EventId });

            modelBuilder.Entity<EventSponsor>()
                .HasOne(es => es.Event)
                .WithMany(e => e.EventSponsors)
                .HasForeignKey(es => es.EventId);

            modelBuilder.Entity<EventMember>()
                .HasKey(em => new { em.Id, em.EventId, em.UserId });

            modelBuilder.Entity<EventMember>()
                .HasOne(em => em.Event)
                .WithMany(e => e.EventMembers)
                .HasForeignKey(em => em.EventId);

            modelBuilder.Entity<EventMember>()
                .HasOne(em => em.User)
                .WithMany(u => u.EventMembers)
                .HasForeignKey(em => em.UserId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
