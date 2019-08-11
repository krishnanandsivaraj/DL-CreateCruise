using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Core.Dto.UseCaseRequests
{
    public class CreateCruiseRequest : IUseCaseRequest<CreateCruiseResponse>
    {
        public Cruise cruise { get; set; }
    }
}
