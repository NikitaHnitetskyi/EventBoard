namespace EventBoardDataAccess.DataBase.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<EventOrganizer> EventOrganizers { get; set; }
        public ICollection<EventMember> EventMembers { get; set; }
    }
}
