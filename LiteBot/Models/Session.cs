using System;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Session : Model
    {
        [MaxLength(255)]
        public string Token { get; set; }
        public DateTime ExpiredTime { get; set; }
        [MaxLength(30)]
        public string Ip { get; set; }
    }
}