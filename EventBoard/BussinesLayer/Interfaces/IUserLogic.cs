namespace BussinesLayer.Interfaces
{
    public interface IUserLogic
    {
       public void AddUser (int roleId, string name);
       public void DeleteUser (int id);
       public void UpdateUser ();
       public void GetAllUser();
    }
}
