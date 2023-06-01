using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Reservation
    {
        public Reservation()
        {

        }

        [Key]
        public int Id { get; set; }
        [Range(0, 1000)]
        public int Seats { get; set; }
        [Range(0, 1000)]
        public int Tickets { get; set; }
        [Range(0, 1000)]
        public decimal Price { get; set; }
        [Required]
        public Flight Flight { get; set; }
        [ForeignKey("Flight")]
        public int FlightId { get; set; }

    }
}