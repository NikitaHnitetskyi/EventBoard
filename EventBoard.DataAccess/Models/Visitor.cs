using System.ComponentModel.DataAnnotations;

namespace EventBoardApp_.DataBase.Model
{
    public class Visitor : Person 
    {
        [Key]
        public int Id { get; set; }

        public string City { get; set; }
        public string Info { get; set; }
    }
}
