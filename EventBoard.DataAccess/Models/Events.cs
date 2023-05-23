

using System.ComponentModel.DataAnnotations;

namespace EventBoardApp_.DataBase.Model
{
    public class Events
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeCreate { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Info { get; set; }
    }
}
