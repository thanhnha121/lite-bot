using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Post : Model
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
        [MaxLength(640)]
        public string Text { get; set; }
        [MaxLength(640)]
        public string WelcomeMessage { get; set; }
        [MaxLength(255)]
        public string Url { get; set; }
        public GroupUser GroupUser { get; set; }
        public GroupGiftcode GroupGiftcode { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public Boolean IsSchedule { get; set; }
        public List<ShortLink> ShortLinks { get; set; }
        public Post()
        {
            LastModifiedTime = DateTime.Now;
            IsSchedule = false;
            ShortLinks = new List<ShortLink>();
        }
    }
}