using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Airport
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Reservation> Reservations { get; set; }
        public double YIncome { get; set; }

        public Airport()
        {
            Reservations = new List<Reservation>();
        }

    }
}