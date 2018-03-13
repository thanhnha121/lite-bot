using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LiteBot.Interface;

namespace LiteBot.Models
{
    public class Menu : Model
    {
        [MaxLength(640)]
        public string Title { get; set; }
        public List<MenuButton> Buttons { get; set; }
        public Account CreatedBy { get; set; }
        public List<Fanpage> Fanpages { get; set; }
  
        public Menu()
        {
            Buttons = new List<MenuButton>();
            Fanpages = new List<Fanpage>();
        }
    }
}