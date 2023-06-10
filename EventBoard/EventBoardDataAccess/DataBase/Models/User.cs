namespace EventBoardDataAccess.DataBase.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Event> OrganizedEvents { get; set; }
        public ICollection<Event> PorticipatedEvents { get; set; }
        public ICollection<Event> SponsoredEvents { get; set; }

    }
}
