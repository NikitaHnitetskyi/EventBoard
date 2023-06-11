namespace EventBoardDataAccess.DataBase.Models
{
    public class Event
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> EventOrganizers { get; set; }
        public ICollection<User> EventSponsors { get; set; }
        public ICollection<User> EventPorticapants { get; set; }
    }
}
