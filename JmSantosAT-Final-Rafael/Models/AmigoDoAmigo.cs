using System.ComponentModel.DataAnnotations;

namespace JmSantosAT_Final_Rafael.Models
{
    public class AmigoDoAmigo
    {
        public int AmigoDoAmigoId { get; set; }
        public Amigo Amigo { get; set; }
        [Required]
        public string AmigoDoAmigoNome { get; set; }
        [Required]
        public string AmigoDoAmigoSobrenome { get; set; }
        [Required]
        public string AmigoDoAmigoTelefone { get; set; }
        [Required]
        public string AmigoDoAmigoEmail { get; set; }
        [Required]
        public DateTime AniversarioAmigoDoAmigo { get; set; }
        public string PaisAmigoDoAmigo { get; set; }
        [Required]
        public string EstadoAmigoDoAmigo { get; set; }
        [Required]
        public string ImagemAmigoDoAmigo { get; set; }
    }
}

