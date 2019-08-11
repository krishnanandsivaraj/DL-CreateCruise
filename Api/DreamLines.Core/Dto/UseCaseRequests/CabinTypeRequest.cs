using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Core.Dto.UseCaseRequests
{
    public class CabinTypeRequest : IUseCaseRequest<CabinTypeResponse>
    {
        public int nid { get; set; }
        public int shipId { get; set; }
    }
}
