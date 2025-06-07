namespace CatShop.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nome { get; set;}
        public ICollection<ArtefatoFelino>? Artefatos { get; set;}
      
    }
}
