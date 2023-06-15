using BussinesLayer.Interfaces;
using EventBoardDataAccess.DataBase.Repository;

namespace BussinesLayer.Models
{
    public class UserLogic : IUserLogic
    {
       

        
        public void AddUser(int roleId, string name)
        {
            var addUser = new UnitOfWork();
            addUser.AddUser( roleId, name);
        }

        public void DeleteUser(int id)
        {
           var deletUser = new UnitOfWork();
            deletUser.DeleteUser(id);
        }

        public void GetAllUser()
        {
           
        }

        public void UpdateUser()
        {
            
        }
    }
}
