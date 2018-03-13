using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class GroupUser : Model
    {
        [MaxLength(255)]
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Attribute> Attributes { get; set; }
        public DateTime LastModifiedTime { get; set; }
        [NotMapped]
        public List<User> Users { get; set; }

        public GroupUser()
        {
            LastModifiedTime = DateTime.Now;
        }
    }
}