namespace EventBoardDataAccess.DataBase.Models
{
   public class EventSponsor
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string SponsorName { get; set; }
        public Event Event { get; set; }
    }
}
