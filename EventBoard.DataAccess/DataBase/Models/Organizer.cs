using System.ComponentModel.DataAnnotations;

namespace EventBoardApp_.DataBase.Model
{
    public class Organizer
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public List<Events> OrganizedEvents { get; set; }
        public Role Role { get; set; }
    }
}
