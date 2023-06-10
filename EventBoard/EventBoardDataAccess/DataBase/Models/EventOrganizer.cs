namespace EventBoardDataAccess.DataBase.Models
{
    public class EventOrganizer
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public Event Event { get; set; }
        public User User { get; set; }
    }
}
