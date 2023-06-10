using EventBoardDataAccess.DataBase.Models;
using EventBoardDataAccess.DataBase.Modul;
using Ninject;


namespace EventBoardDataAccess.DataBase.Repository
{
    public class UnitOfWork
    {
        private IRepository<EventMember> eventMemberRepository;
        private IRepository<EventOrganizer> eventOrganizerRepository;
        private IRepository<EventSponsor> eventSponsorRepository;
        private IRepository<Role> roleRepository;
        private IRepository<User> userRepository;
        private IRepository<Event> eventRepository;

        private RoleContext dbContext;
        public UnitOfWork(RoleContext dbContext, IRepository<EventMember> eventMemberRepository, IRepository<EventOrganizer> eventOrganizerRepository, IRepository<EventSponsor> eventSponsorRepository,
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
        #region EventMember
        public void AddEventMember( int id)
        {
            eventMemberRepository.Add(new EventMember { Id = id });
        }
        public void DeleteEventMember(int id)
        {
            eventMemberRepository.Delete(id);
        }
        public IQueryable<EventMember> AllEventMember()
        {
            var eventMember = eventMemberRepository.GetAll();
            return eventMember;
        }

        #endregion

        #region EventOrganizer
        public void AddEventOrganizer()
        {
            eventOrganizerRepository.Add(new EventOrganizer { });
        }
        public void DeleteEventOrganizer(int id)
        {
            eventOrganizerRepository.Delete(id);
        }
        public IQueryable<EventOrganizer> AllEventOrganizer()
        {
            var eventOrganizer = eventOrganizerRepository.GetAll();
            return eventOrganizer;
        }

        #endregion

        #region EventSponsor
        public void AddEventSponsor()
        {
            eventSponsorRepository.Add(new EventSponsor { });
        }
        public void DeleteOrganizator(int id)
        {
            eventSponsorRepository.Delete(id);
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
        public void AddRole()
        {
            roleRepository.Add(new Role { });
        }
        public void DeleteRole(int id)
        {
            roleRepository.Delete(id);
        }
        #endregion

        #region Event
        public void AddEvent(string name, string info, string plase)
        {
       //   eventRepository.Add(new Event { Name = name, Info = info, Place = plase, });
        }
        public void DeleteEvent(int id)
        {
            eventRepository.Delete(id);
        }
        public IQueryable<Event> AllEvent()
        {
            var events = eventRepository.GetAll();
            return events;
        }
        #endregion
        public void AddUser()
        {
            userRepository.Add(new User { });
        }

        public void DeleteUser(int id)
        {
            userRepository.Delete(id);
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
        public UnitOfWork()
        {
            var module = new Module();
            var kernal = new StandardKernel(module);
            eventMemberRepository = kernal.Get<IRepository<EventMember>>();
            eventOrganizerRepository = kernal.Get<IRepository<EventOrganizer>>();
            eventSponsorRepository = kernal.Get<IRepository<EventSponsor>>();
            roleRepository = kernal.Get<IRepository<Role>>();
            userRepository= kernal.Get<IRepository<User>>();
            eventRepository = kernal.Get<IRepository<Event>>();
            dbContext = kernal.Get<RoleContext>();

            eventMemberRepository.DbContext = dbContext;
            eventOrganizerRepository.DbContext = dbContext;
            eventSponsorRepository.DbContext = dbContext;
            roleRepository.DbContext = dbContext;
            userRepository.DbContext = dbContext;
            eventRepository.DbContext = dbContext;

        }
    }
}
