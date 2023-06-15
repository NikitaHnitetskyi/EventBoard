using Ninject.Modules;
using BussinesLayer.Interfaces;
using BussinesLayer.Models;
using EventBoardDataAccess.DataBase.Repository;

namespace BussinesLayer.NInject
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUserLogic>().To<UserLogic>();
            this.Bind<IRoleLogic>().To<RoleLogic>();
            this.Bind<IEventLogic>().To<EventLogic>();
            this.Bind<UnitOfWork>().To<UnitOfWork>();
            
        }
    }
}
