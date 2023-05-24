using System.ComponentModel.DataAnnotations;

namespace EventBoardApp_.DataBase.Model
{
    public class Sponsor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Events> EventsSponsor { get; set; }
        public Role Role { get; set; }

    }
}
