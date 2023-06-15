namespace BussinesLayer.Interfaces
{
    public interface IRoleLogic
    {
        public void AddRole(string name, string des);
        public void DeleteRole(int id);
        public void UpdateRole();
        public void GetAllRole();
    }
}
