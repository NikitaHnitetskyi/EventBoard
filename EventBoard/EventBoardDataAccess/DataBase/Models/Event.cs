namespace EventBoardDataAccess.DataBase.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<EventOrganizer> EventOrganizers { get; set; }
        public ICollection<EventSponsor> EventSponsors { get; set; }
        public ICollection<EventMember> EventMembers { get; set; }
    }
}
