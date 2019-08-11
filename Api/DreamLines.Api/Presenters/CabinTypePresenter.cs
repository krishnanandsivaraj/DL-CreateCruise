using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DreamLines.Api.Presenters
{
    public sealed class CabinTypePresenter : IOutputPort<CabinTypeResponse>
    {
        public JsonContentResult ContentResult { get; }

        public CabinTypePresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(CabinTypeResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response.cabinTypes) : JsonSerializer.SerializeObject(response.Errors);
        }
    }
}
