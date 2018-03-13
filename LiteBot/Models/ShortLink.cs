using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class ShortLink : Model
    {
        [MaxLength(255)]
        public string OriginUrl { get; set; }
        [MaxLength(255)]
        public string FullUrl { get; set; }
        [MaxLength(20)]
        public string Url { get; set; }
    }
}