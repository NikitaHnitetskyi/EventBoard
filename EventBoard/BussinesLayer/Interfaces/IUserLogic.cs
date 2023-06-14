namespace BussinesLayer.Interfaces
{
    public interface IUserLogic
    {
       public void AddUser (string name);
       public void DeleteUser (int id);
       public void UpdateUser ();
       public void GetAllUser();
    }
}
