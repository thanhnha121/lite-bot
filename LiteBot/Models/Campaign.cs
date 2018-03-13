using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Campaign : Model
    {
        [MaxLength(100)]
        public string Name { get; set; }
        public Account CreatedBy { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public List<Post> Posts { get; set; }
        public Campaign()
        {
            LastModifiedTime = DateTime.Now;
            Posts = new List<Post>();
        }
    }
}