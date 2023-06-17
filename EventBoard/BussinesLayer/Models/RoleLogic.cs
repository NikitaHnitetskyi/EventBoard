using BussinesLayer.Interfaces;
using BussinesLayer.NInject;
using EventBoardDataAccess.DataBase.Repository;
using Ninject;

namespace BussinesLayer.Models
{
    public class RoleLogic : IRoleLogic
    {
        public void AddRole(string name, string des)
        {
            var module = new Module();
            var kernal = new StandardKernel(module);
            var addRol = kernal.Get<UnitOfWork>();
            addRol.AddRole(name, des);
        }

        public void DeleteRole(int id)
        {
            var module = new Module();
            var kernal = new StandardKernel(module);
            var deleteRol = kernal.Get<UnitOfWork>();
            deleteRol.DeleteRole(id);
        }

        public void GetAllRole()
        {
            var module = new Module();
            var kernal = new StandardKernel(module);
            var allRol = kernal.GetAll<UnitOfWork>();
        }

        public void UpdateRole()
        {
            throw new NotImplementedException();
        }
    }
}
