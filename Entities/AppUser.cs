using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string NationalCode { get; set; }
        public IEnumerable<Reservation> Reservations { get; set; }
    }
}
