using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Core.Dto.UseCaseRequests
{
    public class ShipRequest : IUseCaseRequest<ShipResponse>
    {
        public string nid { get; set; }
    }
}
