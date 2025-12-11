using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Image
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Path { get; set; }

        [Required]
        public long TourId { get; set; }
        
        public Tour Tour { get; set; }
    }

}
