using FilmesApi.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Cinema : BaseEntity
    {        
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public int EnderecoFK { get; set; }
        public int GerenteFK { get; set; }
    }
}