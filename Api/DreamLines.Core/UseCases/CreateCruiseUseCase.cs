using DreamLines.Core.Dto.UseCaseRequests;
using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;
using DreamLines.Core.Interfaces.Gateways.Repositories;
using DreamLines.Core.Interfaces.UseCases;
using System.Threading.Tasks;

namespace DreamLines.Core.UseCases
{
    public sealed class CreateCruiseUseCase : ICreateCruiseUseCase
    {
        private readonly ICruiseRepository _cruiseLineRepository;

        public CreateCruiseUseCase(ICruiseRepository cruiseLineRepository)
        {
            _cruiseLineRepository = cruiseLineRepository;
        }

        public async Task<bool> HandleAsync(CreateCruiseRequest message, IOutputPort<CreateCruiseResponse> outputPort)
        {
            return await _cruiseLineRepository.InsertCruise(message);
        }
    }
}
