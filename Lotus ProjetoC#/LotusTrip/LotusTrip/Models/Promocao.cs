using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LotusTrip.Models
{
    public class Promocao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NomePromocao { get; set; }

        [Required]
        public double ValorDesconto { get; set; }


        public ICollection<Destino> ListaUF { get; set; }



    }
}
