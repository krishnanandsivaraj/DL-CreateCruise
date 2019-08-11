using DreamLines.Api.Serialization;
using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;
using System.Net;

namespace DreamLines.Api.Presenters
{
    public sealed class CruiseLinePresenter : IOutputPort<CruiseLineResponse>
    {
        public JsonContentResult ContentResult { get; }

        public CruiseLinePresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(CruiseLineResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response.cruiseLines) : JsonSerializer.SerializeObject(response.Errors);
        }
    }
}
