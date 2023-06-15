using EventBoardDataAccess.DataBase.Models;
using EventBoardDataAccess.DataBase.Modul;
using Ninject;

namespace EventBoardDataAccess.DataBase.Repository
{
    public class UnitOfWork
    {
        private IRepository<EventParticipant> eventMemberRepository;
        private IRepository<EventOrganizer> eventOrganizerRepository;
        private IRepository<EventSponsor> eventSponsorRepository;
        private IRepository<Role> roleRepository;
        private IRepository<User> userRepository;
        private IRepository<Event> eventRepository;

        private EventBoardContext dbContext;
        public UnitOfWork(EventBoardContext dbContext, IRepository<EventParticipant> eventMemberRepository, IRepository<EventOrganizer> eventOrganizerRepository, IRepository<EventSponsor> eventSponsorRepository,
            IRepository<Role> roleRepository, IRepository<Event> eventRepository, IRepository<User> userRepository)
        {
            this.dbContext = dbContext;
            this.eventMemberRepository.DbContext = dbContext;
            this.eventOrganizerRepository.DbContext = dbContext;
            this.eventSponsorRepository.DbContext = dbContext;
            this.roleRepository.DbContext = dbContext;
            this.userRepository.DbContext = dbContext;
            this.eventRepository.DbContext = dbContext;
        }
        #region EventParticipant
        public void AddEventMember(int eventId)
        {
            eventMemberRepository.Add(new EventParticipant { Id = eventId });
            dbContext.SaveChanges();
        }
        public void DeleteEventParticipant(int id)
        {
            eventMemberRepository.Delete(id);
            dbContext.SaveChanges();
        }
        public IQueryable<EventParticipant> AllEventParticipant()
        {
            var eventMember = eventMemberRepository.GetAll();
            return eventMember;
        }

        #endregion

        #region EventOrganizer
        public void AddEventOrganizer(int eventId)
        {
            eventOrganizerRepository.Add(new EventOrganizer {EventId = eventId });
            dbContext.SaveChanges();
        }
        public void DeleteEventOrganizer(int id)
        {
            eventOrganizerRepository.Delete(id);
            dbContext.SaveChanges();
        }
        public IQueryable<EventOrganizer> AllEventOrganizer()
        {
            var eventOrganizer = eventOrganizerRepository.GetAll();
            return eventOrganizer;
        }

        #endregion

        #region EventSponsor
        public void AddEventSponsor(int sponsorId)
        {
            eventSponsorRepository.Add(new EventSponsor {SponsorId = sponsorId});
            dbContext.SaveChanges();
        }
        public void DeleteOrganizator(int id)
        {
            eventSponsorRepository.Delete(id);
            dbContext.SaveChanges();
        }
        public IQueryable<EventSponsor> AllEventSponsor()
        {
            var eventSponsor = eventSponsorRepository.GetAll();
            return eventSponsor;
        }

        #endregion

        #region Role
        public IQueryable<Role> AllRole()
        {
            var roles = roleRepository.GetAll();
            return roles;
        }
        public void AddRole(string name, string des)
        {
            roleRepository.Add(new Role {Name = name, Description = des });
            dbContext.SaveChanges();
        }
        public void DeleteRole(int id)
        {
            roleRepository.Delete(id);
            dbContext.SaveChanges();
        }
        #endregion

        #region Event
        public void AddEvent(string name)
        {
              eventRepository.Add(new Event { Name = name });
            dbContext.SaveChanges();
        }
        public void DeleteEvent(int id)
        {
            eventRepository.Delete(id);
            dbContext.SaveChanges();

        }
        public IQueryable<Event> AllEvent()
        {
            var events = eventRepository.GetAll();
            return events;
        }
        #endregion

        #region User
        public void AddUser(int roleId, string name)
        {
            userRepository.Add(new User { RoleId = roleId, Name = name });
            dbContext.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            userRepository.Delete(id);
            dbContext.SaveChanges();
        }
        public IQueryable<User> AllUser()
        {
            var users = userRepository.GetAll();
            return users;
        }
        public void Commit()
        {
            dbContext.SaveChanges();
        }
        #endregion

        #region UnitOfWork
        public UnitOfWork()
        {
            var module = new Module();
            var kernal = new StandardKernel(module);
            eventMemberRepository = kernal.Get<IRepository<EventParticipant>>();
            eventOrganizerRepository = kernal.Get<IRepository<EventOrganizer>>();
            eventSponsorRepository = kernal.Get<IRepository<EventSponsor>>();
            roleRepository = kernal.Get<IRepository<Role>>();
            userRepository = kernal.Get<IRepository<User>>();
            eventRepository = kernal.Get<IRepository<Event>>();
            dbContext = kernal.Get<EventBoardContext>();

            eventMemberRepository.DbContext = dbContext;
            eventOrganizerRepository.DbContext = dbContext;
            eventSponsorRepository.DbContext = dbContext;
            roleRepository.DbContext = dbContext;
            userRepository.DbContext = dbContext;
            eventRepository.DbContext = dbContext;

        }
        #endregion
    }
}
