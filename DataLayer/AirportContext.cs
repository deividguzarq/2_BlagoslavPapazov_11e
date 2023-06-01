using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;

namespace DataLayer
{
    public class AirportContext : IDb<Airport, int>
    {
        private readonly AirportDbContext dbContext;
        public AirportContext(AirportDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Airport item)
        {
            try
            {
                dbContext.Airports.Add(item);
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
                Airport airportFromDb = Read(key);
                dbContext.Airports.Remove(airportFromDb);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Airport Read(int key)
        {
            try
            {
                return dbContext.Airports.FirstOrDefault(c => c.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Airport> ReadAll()
        {
            try
            {
                return dbContext.Airports.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Airport item)
        {
            try
            {
                Airport airportFromDb = Read(item.Id);
                dbContext.Entry(airportFromDb).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
