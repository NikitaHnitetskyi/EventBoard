namespace BussinesLayer.Interfaces
{
    public interface IRoleLogic
    {
        public void AddRole(string name);
        public void DeleteRole(int id);
        public void UpdateRole();
        public void GetAllRole();
    }
}
