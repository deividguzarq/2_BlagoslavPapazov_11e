using System;
using DataLayer;
using BusinessLayer;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class FlightManager
    {
        private readonly FlightContext context;

        public FlightManager(AirportDbContext dbContext)
        {
            context = new FlightContext(dbContext);
        }

        public void Create(Flight item)
        {
            try
            {
                context.Create(item);
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
                context.Delete(key);
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
                return context.Read(key);
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
                return context.ReadAll();
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
                context.Update(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}