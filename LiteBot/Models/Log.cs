using System;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Log : Model
    {
        [MaxLength(30)]
        public string Type { get; set; }
        public string MoreInfo { get; set; }
    }
}