using DreamLines.Core.Domain.Entities;
using DreamLines.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Core.Dto.UseCaseResponses
{
    public class ShipResponse : UseCaseResponseMessage
    {
        public List<Ship> ships { get; set; }

        public IEnumerable<Error> Errors { get; }

        public ShipResponse(IEnumerable<Error> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public ShipResponse(List<Ship> ship, bool success = false, string message = null) : base(success, message)
        {
            ships = ship;
        }
    }
}
