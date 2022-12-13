using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JmSantosAT_Final_Rafael.Models
{
    public class Pais
    {
        [Key]
        public int PaisId { get; set; }
        public string PaisNome { get; set; }
        public string PaisImagem { get; set; }
        public int EstadosId { get; set; }   
    }
}
