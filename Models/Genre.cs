using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Genre
    {
        [Key]
        public  Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        //relation one-to-Many to movie 
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
