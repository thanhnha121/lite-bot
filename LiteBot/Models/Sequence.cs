using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Sequence : Model
    {
        public string Name { get; set; }
        public List<Form> Forms { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }

        public Sequence()
        {
            Forms = new List<Form>();
        }
    }
}