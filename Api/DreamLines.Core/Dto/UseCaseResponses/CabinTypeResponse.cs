using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Core.Dto.UseCaseResponses
{
    public class CabinTypeResponse : UseCaseResponseMessage
    {
        public List<Cabintype> cabinTypes { get; set; }

        public IEnumerable<Error> Errors { get; }

        public CabinTypeResponse(IEnumerable<Error> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public CabinTypeResponse(List<Cabintype> cabintypes, bool success = false, string message = null) : base(success, message)
        {
            cabinTypes = cabintypes;
        }
    }
}
