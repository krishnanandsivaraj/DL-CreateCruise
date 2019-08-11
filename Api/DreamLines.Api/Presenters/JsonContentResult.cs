using Microsoft.AspNetCore.Mvc;

namespace DreamLines.Api.Presenters
{
    public sealed class JsonContentResult : ContentResult
    {
        public JsonContentResult()
        {
            ContentType = "application/json";
        }
    }
}
