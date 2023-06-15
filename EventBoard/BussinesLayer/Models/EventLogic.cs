using BussinesLayer.Interfaces;
using BussinesLayer.NInject;
using EventBoardDataAccess.DataBase.Repository;
using Ninject;

namespace BussinesLayer.Models
{
    public class EventLogic : IEventLogic
    {
       
        public void AddEvent(string name)
        {
            var module = new Module();
            var kernal = new StandardKernel(module);
            var addEv = kernal.Get<UnitOfWork>();
            addEv.AddEvent(name);
        }
        public void DeleteEvent(int id)
        {
            var deleteEvent = new UnitOfWork();
            deleteEvent.DeleteEvent(id);
        }

        public void GetAllEvent()
        {
            
        }

        public void UpdateEvent()
        {
            
        }
    }
}
