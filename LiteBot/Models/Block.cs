using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Block : Model
    {
        [MaxLength(100)]
        public string Name { get; set; }
        public Frame Frame { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public List<Sequence> Sequences { get; set; }

        public Block()
        {
            Sequences = new List<Sequence>();
            LastModifiedTime = DateTime.Now;
        }
    }
}