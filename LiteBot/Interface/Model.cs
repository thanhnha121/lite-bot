using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace LiteBot.Interface
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }

        public Model()
        {
            CreatedTime = DateTime.Now;
        }
    }
}