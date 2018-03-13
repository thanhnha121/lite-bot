using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class GroupGiftcode : Model
    {
        [MaxLength(255)]
        public string Name { get; set; }
        public Account CreatedBy { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public List<Giftcode> Giftcodes { get; set; }
        public GroupGiftcode()
        {
            LastModifiedTime = DateTime.Now;
        }
    }
}