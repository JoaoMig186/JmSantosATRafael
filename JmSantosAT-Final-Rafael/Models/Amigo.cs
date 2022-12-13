using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JmSantosAT_Final_Rafael.Models
{
    public class Amigo
    {
        public int AmigoId { get; set; }
        [Required]
        public string AmigoNome { get; set; }
        [Required]
        public string  AmigoSobrenome { get; set; }
        [Required]
        public string AmigoTelefone { get; set; }
        [Required]
        public string AmigoEmail { get; set; }
        [Required]
        public DateTime AniversarioAmigo { get; set; }
        public List<Amigo> AmigosLista {get; set;}
        [Required]
        public string PaisAmigo { get; set; }
        [Required]
        public string EstadoAmigo { get; set; }
        [Required]
        public string ImagemAmigo { get; set; } 
    }
}
