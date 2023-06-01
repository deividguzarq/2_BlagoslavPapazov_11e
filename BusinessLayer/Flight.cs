using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace BusinessLayer
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Destination { get; set; }
        [Range(0, 1500)]
        public DateTime? Time { get; set; }
        public List<Reservation> Reservations { get; set; }
        public Flight()
        {
            Reservations = new List<Reservation>();
        }

    }
}