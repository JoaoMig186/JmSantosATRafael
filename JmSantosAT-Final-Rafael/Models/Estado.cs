using System.ComponentModel.DataAnnotations;

namespace JmSantosAT_Final_Rafael.Models
{
    public class Estado
    {
        [Key]
        public int EstadosId { get; set; }
        public string EstadosNome { get; set; } 
        public string EstadoImagem {get;set;}
        public int PaisId { get; set; }         
        public Pais Paises { get; set; }  
    }
}
