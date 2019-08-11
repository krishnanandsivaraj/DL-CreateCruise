using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Dto;
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
    public sealed class CruiseUseCase : ICruiseUseCase
    {
        private readonly ICruiseRepository _cruiseLineRepository;

        public CruiseUseCase(ICruiseRepository cruiseLineRepository)
        {
            _cruiseLineRepository = cruiseLineRepository;
        }

        public async Task<List<CruiseLine>> HandleAsync(CruiseLineRequest message, IOutputPort<CruiseLineResponse> outputPort)
        {
            return await _cruiseLineRepository.GetCruiseLine("all");
        }
    }
}
