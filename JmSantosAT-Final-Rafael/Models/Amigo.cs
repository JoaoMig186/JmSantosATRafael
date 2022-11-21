namespace JmSantosAT_Final_Rafael.Models
{
    public class Amigo
    {
        public int AmigoId { get; set; }
        public string AmigoNome { get; set; }
        public string  AmigoSobrenome { get; set; }
        public string AmigoTelefone { get; set; }
        public string AmigoEmail { get; set; }
        public DateTime AniversarioAmigo { get; set; }
        public List<Amigo> AmigosLista {get; set;}
        public string PaisAmigo { get; set; }
        public string EstadoAmigo { get; set; }
        public string ImagemAmigo { get; set; } 
    }
}
