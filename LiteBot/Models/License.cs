using System;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class License : Model
    {
        [MaxLength(255)]
        public string Key { get; set; }
        public DateTime ExpiredTime { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
    }
}