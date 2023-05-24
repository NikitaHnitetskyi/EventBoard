

using System.ComponentModel.DataAnnotations;

namespace EventBoardApp_.DataBase.Model
{
    public class Member : Person
    {
        [Key]
        public int Id { get; set; }
        public string Info { get; set; }
        public List<Events> Events { get; set; }

    }
}
