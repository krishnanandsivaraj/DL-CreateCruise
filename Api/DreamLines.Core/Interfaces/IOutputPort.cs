using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Core.Interfaces
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}
