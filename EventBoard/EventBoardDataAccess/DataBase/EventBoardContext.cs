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
                .HasMany(x => x.SponsoredEvents)// користувач може бути спонсором багатьох подій
                .WithMany(x => x.EventSponsors)// означає, що в об'єкті "SponsoredEvents" також є колекція "EventSponsors" (спонсори подій).
                .UsingEntity<EventSponsor>( // вказує, що ми використовуємо проміжну сутність "EventSponsor" для зберігання додаткової інформації про зв'язок між користувачем і спонсорованою подією.
                    eventSponsor => eventSponsor //встановлює зв'язок між сутністю "EventSponsor" і "Event". "EventSponsor" може мати одну подію, але подія може мати багатьох спонсорів.
                    .HasOne<Event>()
                    .WithMany().HasForeignKey(x => x.EventId),//вказує на зовнішній ключ "EventId" в "EventSponsor" для зв'язку з первинним ключем "Event".
                    eventSponsor => eventSponsor//встановлює зв'язок між сутністю "EventSponsor" і "User". "EventSponsor" може мати одного користувача (спонсора), але користувач може бути спонсором багатьох подій.
                    .HasOne<User>()
                    .WithMany()
                    .HasForeignKey(x => x.SponsorId)); // вказує на зовнішній ключ "SponsorId" в "EventSponsor" для зв'язку з первинним ключем "User".

            modelBuilder.Entity<User>()
                .HasMany(x => x.PorticipatedEvents)
                .WithMany(x => x.EventPorticapants)
                .UsingEntity<EventParticipant>(
                eventParticipant => eventParticipant
                .HasOne<Event>()
                .WithMany().HasForeignKey(x => x.EventId),
                eventParticipant => eventParticipant
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(x => x.UserId));

            modelBuilder.Entity<User>()
                .HasMany(x => x.OrganizedEvents)
                .WithMany(x => x.EventOrganizers)
                .UsingEntity<EventOrganizer>(
                eventOrganizer => eventOrganizer
                .HasOne<Event>()
                .WithMany().HasForeignKey(x => x.EventId),
                eventOrgnizer => eventOrgnizer
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(x => x.UserId));

            base.OnModelCreating(modelBuilder);
        }

    }
}
