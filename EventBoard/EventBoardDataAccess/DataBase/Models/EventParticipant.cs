namespace EventBoardDataAccess.DataBase.Models
{
    public class EventParticipant
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
    }
}
