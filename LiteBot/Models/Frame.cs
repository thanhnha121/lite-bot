using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Frame : Model
    {
        /// <summary>
        /// Template: type for template
        /// Normal: type for normal frame
        /// </summary>
        [MaxLength(30)]
        public string Type { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public Account CreatedBy { get; set; }
        [MaxLength(30)]
        public string Icon { get; set; }
        [MaxLength(30)]
        public string Status { get; set; }
        public List<Block> Blocks { get; set; }

        public Frame()
        {
            LastModifiedTime = DateTime.Now;
            Blocks = new List<Block>();
        }
    }
}