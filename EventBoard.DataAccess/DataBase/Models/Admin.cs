using System.ComponentModel.DataAnnotations;

namespace EventBoardApp_.DataBase.Model
{
    
        public class Admin : Person
        {
          [Key] 
          public int Id { get; set; }
          public List<Events> Events { get; set; }

        }
    
}
