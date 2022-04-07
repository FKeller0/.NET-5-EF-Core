using FilmesAPI.Models;

namespace FilmesApi.Models
{
    public class Endereco : BaseEntity
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }
}
