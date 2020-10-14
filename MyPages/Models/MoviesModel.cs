using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPages.Models
{
    public class MoviesModel
    {
        public int ID { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Lançamento")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Gênero")]
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        [Display(Name = "Avaliação")]
        public string Rating { get; set; }
    }
}
