using System.Threading.Tasks;

namespace DreamLines.Core.Interfaces
{
    public interface IUseCaseRequestHandler<in TUseCaseRequest, out TUseCaseResponse> where TUseCaseRequest : IUseCaseRequest<TUseCaseResponse>
    {
        Task<bool> HandleAsync(TUseCaseRequest message, IOutputPort<TUseCaseResponse> outputPort);
    }

    public interface IUseCaseGetRequestHandler<TRequest,in TUseCaseRequest, out TUseCaseResponse> where TUseCaseRequest : IUseCaseRequest<TUseCaseResponse>
    {
        Task<TRequest> HandleAsync(TUseCaseRequest message, IOutputPort<TUseCaseResponse> outputPort);
    }


}
