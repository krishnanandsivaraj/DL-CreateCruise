using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DreamLines.Api.Presenters
{
    public sealed class ShipPresenter : IOutputPort<ShipResponse>
    {
        public JsonContentResult ContentResult { get; }

        public ShipPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(ShipResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response.ships) : JsonSerializer.SerializeObject(response.Errors);
        }
    }
}
