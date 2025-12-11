using DTO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payment
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long ReservationId { get; set; }

        [Required]
       
        public decimal Price { get; set; } 

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(50)]
        public string RefNo { get; set; }

        [Required]
        public short BankStatus { get; set; }

        [Required]
        public PaymentTypeEnam PaymentType { get; set; }

        
        public Reservation Reservation { get; set; }
    }

}
