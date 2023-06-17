using BussinesLayer.Interfaces;
using BussinesLayer.NInject;
using EventBoardDataAccess.DataBase.Models;
using EventBoardDataAccess.DataBase.Repository;
using Ninject;

namespace BussinesLayer.Models
{
    public class UserLogic : IUserLogic
    {
       

        
        public void AddUser(int roleId, string name)
        {
            var module = new Module();
            var kernal = new StandardKernel(module);
            var addUser = kernal.Get<UnitOfWork>();
            addUser.AddUser(roleId, name);
        }

        public void DeleteUser(int id)
        {
            var module = new Module();
            var kernal = new StandardKernel(module);
            var deleteUser = kernal.Get<UnitOfWork>();
            deleteUser.DeleteUser(id);
        }

        public void GetAllUser()
        {
            var module = new Module();
            var kernal = new StandardKernel(module);
            var allUsers = kernal.GetAll<UnitOfWork>();
            
        }

      
    }
}
