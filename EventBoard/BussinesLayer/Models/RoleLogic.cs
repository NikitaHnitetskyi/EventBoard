using BussinesLayer.Interfaces;
using EventBoardDataAccess.DataBase.Repository;

namespace BussinesLayer.Models
{
    public class RoleLogic : IRoleLogic
    {
        public void AddRole(string name, string des)
        {
            var addRole = new UnitOfWork();
            addRole.AddRole(name, des);
        }

        public void DeleteRole(int id)
        {
            var deleteRole = new UnitOfWork();
            deleteRole.DeleteRole(id);
        }

        public void GetAllRole()
        {
            throw new NotImplementedException();
        }

        public void UpdateRole()
        {
            throw new NotImplementedException();
        }
    }
}
