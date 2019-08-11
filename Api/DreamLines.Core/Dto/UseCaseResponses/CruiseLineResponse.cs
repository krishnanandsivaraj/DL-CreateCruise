using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Core.Dto.UseCaseResponses
{
    public class CruiseLineResponse : UseCaseResponseMessage
    {
        public List<CruiseLine> cruiseLines { get; set; }

        public IEnumerable<Error> Errors { get; }

        public CruiseLineResponse(IEnumerable<Error> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public CruiseLineResponse(List<CruiseLine> id, bool success = false, string message = null) : base(success, message)
        {
            cruiseLines = id;
        }
    }
}
