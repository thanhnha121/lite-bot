using System;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Giftcode : Model
    {
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
        public int Status { get; set; }
        public User Receiver { get; set; }
        public DateTime LastModifiedTime { get; set; }

        public Giftcode()
        {
            LastModifiedTime = DateTime.Now;
        }
    }
}