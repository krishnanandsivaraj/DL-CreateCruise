using DreamLines.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Core.Dto.GatewayResponses.Repositories
{
    public sealed class CruiseLineResponse : BaseGatewayResponse
    {
        public List<CruiseLine> CruiseLines { get; }
        public CruiseLineResponse(List<CruiseLine> cruiseLines, bool success = false, IEnumerable<Error> errors = null) : base(success, errors)
        {
            CruiseLines = cruiseLines;
        }
    }
}
