using System;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Fanpage : Model
    {
        [MaxLength(20)]
        public string FanpageId { get; set; }
        [MaxLength(255)]
        public string FanpageName { get; set; }
        [MaxLength(255)]
        public string FanpageToken { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public string Descriptions { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }

        public Fanpage()
        {
            LastModifiedTime = DateTime.Now;
        }
    }
}