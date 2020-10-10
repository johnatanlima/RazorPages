using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPages.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0,c}")]
        public decimal Price { get; set; }
    }
}
