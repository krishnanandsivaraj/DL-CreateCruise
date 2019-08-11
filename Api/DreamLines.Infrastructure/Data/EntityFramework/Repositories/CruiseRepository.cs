using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Dto;
using DreamLines.Core.Dto.GatewayResponses.Repositories;
using DreamLines.Core.Dto.UseCaseRequests;
using DreamLines.Core.Interfaces.Gateways.Repositories;
using DreamLines.Infrastructure.Data.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLines.Infrastructure.Data.EntityFramework.Repositories
{
    public class CruiseRepository : ICruiseRepository
    {
        public async Task<bool> InsertShip(List<Ship> ships)
        {
            try
            {
                using (var context = new CruiseContext())
                {
                    foreach (var ship in ships)
                    {
                        context.ships.Add(ship);
                    }
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[ships] ON");
                    await context.SaveChangesAsync();
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[ships] OFF");
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public async Task<bool> InsertCabinTypes(List<Cabintype> cabintypes)
        {
            try
            {
                using (var context = new CruiseContext())
                {
                    foreach (var cabintype in cabintypes)
                    {
                        context.cabinTypes.Add(cabintype);
                    }
                    
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public async Task<bool> InsertCruise(List<CruiseLine> cruiseLines)
        {
            try
            {
                using (var context = new CruiseContext())
                {
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT cruiseLines ON");
                    foreach (var cruiseLine in cruiseLines)
                    {
                        context.cruiseLines.Add(cruiseLine);
                    }
                    await context.SaveChangesAsync();
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT cruiseLines OFF");
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<bool> InsertPorts(List<Port> ports)
        {
            try
            {
                using (var context = new CruiseContext())
                {
                    foreach (var port in ports)
                    {
                        context.ports.Add(port);
                    }
                    context.Database.SetCommandTimeout(180);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<List<CruiseLine>> GetCruiseLine(string range)
        {
                using (var context = new CruiseContext())
                {

                return await context.cruiseLines.ToListAsync();

                } 
        }

        public async Task<List<Ship>> GetShipsAsync(string nid)
        {
            using (var context = new CruiseContext())
            {
                List<Ship> allShips = new List<Ship>();
                List<Ship> ships = new List<Ship>();
                List<int> shipIds = await context.cabinTypes.Where(x => x.nid == Convert.ToInt32(nid)).Select(x => x.ship_id).Distinct().ToListAsync();
                foreach (int shipId in shipIds)
                {
                    ships=await context.ships.Where(x => x.ship_id == shipId).GroupBy(x => x.title, (key, group) => group.First()).ToListAsync();
                    allShips.AddRange(ships);
                }
                return allShips;
            }
        }

        public async Task<List<Cabintype>> GetCabinType(int nid, int shipId)
        {
            using (var context = new CruiseContext())
            {
                
                return await context.cabinTypes.Where(x =>  x.nid == nid && x.ship_id==shipId ).ToListAsync();
                
            }
        }

        public async Task<bool> InsertCruise(CreateCruiseRequest message)
        {
            Cruise cruise = new Cruise();
            cruise.nid = message.cruise.nid;
            cruise.shipId = message.cruise.shipId;
            cruise.cabinType = message.cruise.cabinType;
            cruise.rId = message.cruise.rId;
            cruise.departureDate = message.cruise.departureDate;
            cruise.isFlight = message.cruise.isFlight;

            using (var context = new CruiseContext())
            {
                
                    context.cruise.Add(cruise);
                
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}
