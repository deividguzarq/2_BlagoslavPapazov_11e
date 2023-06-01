using System;
using BusinessLayer;
using DataLayer;

namespace TestingLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight flight = new Flight();
            flight.Id = 1;
            flight.Destination = "Test";
            Reservation reservation = new Reservation();
            reservation.Id = 1;
            reservation.Price = 100;
            reservation.Seats = 100;
            reservation.Tickets = 100;
            reservation.Flight = flight;
            FlightContext flightContext = new FlightContext(new AirportDbContext());
            ReservationContext reservationsContext = new ReservationContext(new AirportDbContext());
            flightContext.Create(flight);
            reservationsContext.Create(reservation);
        }
    }
}
