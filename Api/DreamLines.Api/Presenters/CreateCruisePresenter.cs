using DreamLines.Core.Dto.UseCaseResponses;
using DreamLines.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DreamLines.Api.Presenters
{
    public sealed class CreateCruisePresenter : IOutputPort<CreateCruiseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public CreateCruisePresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(CreateCruiseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(response.Id) : JsonSerializer.SerializeObject(response.Errors);
        }
    }
}
