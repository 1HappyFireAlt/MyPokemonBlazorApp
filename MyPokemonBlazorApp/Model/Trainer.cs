using System.ComponentModel.DataAnnotations;

namespace MyPokemonBlazorApp.Model
{
    public class Trainer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Pokemon Companion { get; set; } 
    }
}
