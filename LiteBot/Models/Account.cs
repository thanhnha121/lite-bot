using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Account : Model
    {
        [MaxLength(255)]
        public string Fullname { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Username { get; set; }
        [MaxLength(100)]
        public string Password { get; set; }
        [MaxLength(20)]
        public string FacebookId { get; set; }
        [MaxLength(20)]
        public string Status { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
        public List<Fanpage> Fanpages { get; set; }
        public License License { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public List<Session> Sessions { get; set; }

        public Account()
        {
            Tags = new List<Tag>();
            Fanpages = new List<Fanpage>();
            LastModifiedTime = DateTime.Now;
            Sessions = new List<Session>();
        }
    }
}