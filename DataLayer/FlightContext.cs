using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;


namespace DataLayer
{
    public class FlightContext : IDb<Flight, int>
    {
        private readonly AirportDbContext dbContext;
        public FlightContext(AirportDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Flight item)
        {
            try
            {
                dbContext.Flights.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Flight flightFromDb = Read(key);
                dbContext.Flights.Remove(flightFromDb);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Flight Read(int key)
        {
            try
            {
                return dbContext.Flights.FirstOrDefault(c => c.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Flight> ReadAll()
        {
            try
            {
                return dbContext.Flights.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Flight item)
        {
            try
            {
                Flight flightFromDb = Read(item.Id);
                dbContext.Entry(flightFromDb).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
