using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Dto.UseCaseRequests;
using DreamLines.Core.Dto.UseCaseResponses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Core.Interfaces.UseCases
{
    public interface IShipUseCase : IUseCaseGetRequestHandler<List<Ship>, ShipRequest, ShipResponse>
    {
    }
}
