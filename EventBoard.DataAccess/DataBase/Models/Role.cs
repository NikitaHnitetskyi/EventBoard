﻿

using System.ComponentModel.DataAnnotations;

namespace EventBoardApp_.DataBase.Model
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}