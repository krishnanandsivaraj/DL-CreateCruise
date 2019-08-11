using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Dto.GatewayResponses.Repositories;
using DreamLines.Core.Dto.UseCaseRequests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DreamLines.Core.Interfaces.Gateways.Repositories
{
    public interface ICruiseRepository
    {
        Task<bool> InsertCruise(List<CruiseLine> cruiseLines);
        Task<bool> InsertShip(List<Ship> ships);
        Task<bool> InsertCabinTypes(List<Cabintype> cabintypes);

        Task<List<CruiseLine>> GetCruiseLine(string range);
        Task<List<Ship>> GetShipsAsync(string nid);
        Task<List<Cabintype>> GetCabinType(int nid, int shipId);
        Task<bool> InsertCruise(CreateCruiseRequest message);
    }
}
