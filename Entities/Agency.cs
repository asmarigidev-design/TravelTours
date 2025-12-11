using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Agency
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]       
        public string Tell { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public IEnumerable<Tour> Tours { get; set; }
    }

}
