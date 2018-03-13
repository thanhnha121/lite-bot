using System;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Form : Model
    {
        [MaxLength(30)]
        public string Type { get; set; }
        public string Json { get; set; }
        public string PayloadToString { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public Account CreatedBy { get; set; }

        public Form()
        {
            LastModifiedTime = DateTime.Now;
        }
    }
}