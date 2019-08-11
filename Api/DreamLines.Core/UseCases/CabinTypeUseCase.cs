using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Dto.UseCaseRequests;
using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;
using DreamLines.Core.Interfaces.Gateways.Repositories;
using DreamLines.Core.Interfaces.UseCases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLines.Core.UseCases
{
    public sealed class CabinTypeUseCase : ICabinTypeUseCase
    {
        private readonly ICruiseRepository _cruiseLineRepository;

        public CabinTypeUseCase(ICruiseRepository cruiseLineRepository)
        {
            _cruiseLineRepository = cruiseLineRepository;
        }

        public async Task<List<Cabintype>> HandleAsync(CabinTypeRequest message, IOutputPort<CabinTypeResponse> outputPort)
        {
            return await _cruiseLineRepository.GetCabinType(message.nid,message.shipId);
        }
    }
}
