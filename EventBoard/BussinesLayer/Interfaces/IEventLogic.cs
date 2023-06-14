namespace BussinesLayer.Interfaces
{
    public interface IEventLogic
    {
        public void AddEvent(string name);
        public void DeleteEvent(int id);
        public void UpdateEvent();
        public void GetAllEvent();
    }
}
