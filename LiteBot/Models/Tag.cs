using System;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Tag : Model
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
    }
}