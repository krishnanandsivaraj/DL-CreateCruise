using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DreamLines.Core.Interfaces.UseCases;
using DreamLines.Api.Presenters;
using DreamLines.Core.Dto.UseCaseRequests;
using System;
using DreamLines.Core.UseCases;
using DreamLines.Core.Domain.Entities;
using Microsoft.AspNetCore.Cors;

namespace DreamLines.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class CruiseController : ControllerBase
    {
        private readonly ICruiseUseCase _cruiseUseCase;
        private readonly IShipUseCase _shipUseCase;
        private readonly CruiseLinePresenter _cruiseLinePresenter;
        private readonly ShipPresenter _shipPresenter;
        private readonly ICabinTypeUseCase _cabinTypeUseCase;
        private readonly CabinTypePresenter _cabinTypePresenter;
        private readonly ICreateCruiseUseCase _createCruiseUseCase;
        private readonly CreateCruisePresenter _createCruisePresenter;

        public CruiseController(
            ICruiseUseCase cruiseUseCase, 
            CruiseLinePresenter cruiseLinePresenter,
            IShipUseCase shipUseCase,
            ShipPresenter shipPresenter,
            ICabinTypeUseCase cabinTypeUseCase,
            CabinTypePresenter cabinTypePresenter,
            ICreateCruiseUseCase createCruiseUseCase,
            CreateCruisePresenter createCruisePresenter
            )
        {
            _cruiseUseCase = cruiseUseCase;
            _shipUseCase = shipUseCase;
            _cruiseLinePresenter = cruiseLinePresenter;
            _shipPresenter = shipPresenter;
            _cabinTypeUseCase = cabinTypeUseCase;
            _cabinTypePresenter = cabinTypePresenter;
            _createCruiseUseCase = createCruiseUseCase;
            _createCruisePresenter = createCruisePresenter;
        }

        [HttpGet]
        [Route("CruiseLine")]
        public async Task<IActionResult> Get()
        {
            var response=  await _cruiseUseCase.HandleAsync(new CruiseLineRequest() { range="all" }, _cruiseLinePresenter);
            return Ok(response);
        }

        [HttpGet]
        [Route("ships")]
        public async Task<IActionResult> GetShips(int nId)
        {
            var response = await _shipUseCase.HandleAsync(new ShipRequest() {  nid=Convert.ToString(nId) }, _shipPresenter);
            return Ok(response);
        }

        [HttpGet]
        [Route("catagories")]
        public async Task<IActionResult> GetCagagories(int nId,int shipId)
        {
            var response = await _cabinTypeUseCase.HandleAsync(new CabinTypeRequest() { nid = nId, shipId=shipId }, _cabinTypePresenter);
            return Ok(response);
        }

        [HttpPost]
        
        public async Task<IActionResult> Post([FromBody]Models.Request.CreateCruise cruises)
        {
            Cruise cru = new Cruise() { nid = cruises.nid, rId = 0, cabinType = cruises.cabinType, shipId = cruises.shipId, departureDate = cruises.departureDate, isFlight = cruises.isFlight };
            
            var response = await _createCruiseUseCase.HandleAsync(new CreateCruiseRequest() {  cruise= cru }, _createCruisePresenter);
            return Ok(response);
        }


    }
}
