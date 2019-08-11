using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;

namespace DreamLines.Core.Dto.UseCaseRequests
{
    public class CruiseLineRequest : IUseCaseRequest<CruiseLineResponse>
    {
        public string range { get; set; }
    }
}
