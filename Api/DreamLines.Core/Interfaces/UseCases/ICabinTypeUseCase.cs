using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Dto.UseCaseRequests;
using DreamLines.Core.Dto.UseCaseResponses;
using System.Collections.Generic;

namespace DreamLines.Core.Interfaces.UseCases
{
    public interface ICabinTypeUseCase : IUseCaseGetRequestHandler<List<Cabintype>, CabinTypeRequest, CabinTypeResponse>
    {
    }
}
