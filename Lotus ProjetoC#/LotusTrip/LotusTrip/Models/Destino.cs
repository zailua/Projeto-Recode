using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotusTrip.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string UF { get; set; }

        public int PromocaoId { get; set; }

        [ForeignKey("PromocaoId")]
        public virtual Promocao Promocao { get; set; }

        [Required]
        public string Cidade { get; set; }
        
        [Required]
        public string Aeroporto { get; set;}


    }
}
