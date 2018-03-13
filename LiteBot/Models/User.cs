using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class User : Model
    {
        [MaxLength(20)]
        public string FanpageId { get; set; }
        [MaxLength(255)]
        public string Fullname { get; set; }
        [MaxLength(20)]
        public string FacebookId { get; set; }
        [MaxLength(20)]
        public string FacebookIdFp { get; set; }
        public DateTime LastModifiedTime { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
        [MaxLength(30)]
        public string Status { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Attribute> Attributes { get; set; }

        public User()
        {
            Tags = new List<Tag>();
            Attributes = new List<Attribute>();
            LastModifiedTime = DateTime.Now;
        }
    }
}