using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Review
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long TourId { get; set; }

        [MaxLength(1000)]
        public string Comment { get; set; }

        [Required]
        public DateTime CreateAt { get; set; } 

        [Required]
        [Range(1, 5)]
        public byte Rating { get; set; }

       
        public Tour Tour { get; set; }
    }

}
