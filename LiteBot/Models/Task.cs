using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Task : Model
    {
        [MaxLength(30)]
        public string Type { get; set; }
        public DateTime SendTime { get; set; }
        [MaxLength(20)]
        public string Status { get; set; }
        public List<User> Users { get; set; }
        //public 
    }
}