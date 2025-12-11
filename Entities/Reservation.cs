 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reservation
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long TourId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]       
        public int NumberOfSeats { get; set; }

        public IEnumerable<Payment> Payments { get; set; }

        
        public Tour Tour { get; set; }

        
        public AppUser AppUser { get; set; }
    }

}
