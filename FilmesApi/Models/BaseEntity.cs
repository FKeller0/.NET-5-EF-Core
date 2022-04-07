using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
