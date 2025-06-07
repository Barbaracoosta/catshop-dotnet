using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatShop.Models
{
    [Table("TBL_artefatoFelino")]
    public class ArtefatoFelino

    {
        [Key]
        public int ArtefatoFelinoId { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Campo 'Nome' deve ter entre 10 e 50 caracteres.")]
        public string Nome { get; set; }
        public string NomeSlug => Nome.ToLower().Replace(" ", "-");

        [Required(ErrorMessage = "Campo 'Descrição' obrigatório.")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Campo 'Descrição' deve ter entre 10 e 50 caracteres.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo 'Caminho URL da imagem' obrigatório.")]
        [Display(Name = "Caminho URL da imagem")]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public double Preco { get; set; }

        [Display(Name = "Disponibilidade")]
        public bool Disponibilidade { get; set; }

        public string DisponibilidadeFormatada => Disponibilidade ? "Em estoque" : "Sem estoque";

        [Required(ErrorMessage = "Campo 'Disponível em' obrigatório.")]
        [Display(Name = "Disponível em")]
        [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
        [DataType("month")]
        public DateTime DataCadastro { get; set; }
        
        [Display(Name = "Marca")]
        public int? MarcaId {  get; set; }
    }
}
