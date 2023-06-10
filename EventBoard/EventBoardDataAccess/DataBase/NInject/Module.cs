using EventBoardDataAccess.DataBase.Models;
using EventBoardDataAccess.DataBase.Repository;
using Ninject.Modules;

namespace EventBoardDataAccess.DataBase.Modul
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRepository<EventParticipant>>().To<GenericRepository<EventParticipant>>();
            this.Bind<IRepository<Event>>().To<GenericRepository<Event>>();
            this.Bind<IRepository<EventOrganizer>>().To<GenericRepository<EventOrganizer>>();
            this.Bind<IRepository<EventSponsor>>().To<GenericRepository<EventSponsor>>();

            this.Bind<IRepository<Role>>().To<GenericRepository<Role>>();
            this.Bind<IRepository<User>>().To<GenericRepository<User>>();
            this.Bind<EventBoardContext>().To<EventBoardContext>();

        }
    }
}