using DreamLines.Core.Interfaces;
using System.Collections.Generic;

namespace DreamLines.Core.Dto.UseCaseResponses
{
    public class CreateCruiseResponse : UseCaseResponseMessage
    {
        public int Id { get; }
        public IEnumerable<string> Errors { get; }

        public CreateCruiseResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public CreateCruiseResponse(int id, bool success = false, string message = null) : base(success, message)
        {
            Id = id;
        }
    }
}
