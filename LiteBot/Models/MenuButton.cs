using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class MenuButton : Model
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
        [MaxLength(640)]
        public string Text { get; set; }
        [MaxLength(255)]
        public string Url { get; set; }
        public Sequence Sequence { get; set; }
        public Account CreatedBy { get; set; }
        [MaxLength(30)]
        public string Status { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime LastModifiedTime { get; set; }

        public MenuButton()
        {
            LastModifiedTime = DateTime.Now;
        }
    }
}