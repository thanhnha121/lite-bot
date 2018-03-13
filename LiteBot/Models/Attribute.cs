using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Attribute : Model
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Value { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
    }
}