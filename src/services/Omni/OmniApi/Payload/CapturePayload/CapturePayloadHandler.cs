using MediatR;

namespace OmniApi.Payload.CapturePayload
{
    //Inherits from Mediatr IRequest Class
    public record CapturePayload_Command(DateTime Timestamp, string DataType, double Value, List<object> Properties) 
        :IRequest<CapturePayload_Result>;
    public record CapturePayload_Result(Guid Id);

    //Link Payload MGG 6/20    
    internal class CapturePayloadCommandHandler : IRequestHandler<CapturePayload_Command, CapturePayload_Result>
    {
        public Task<CapturePayload_Result> Handle(CapturePayload_Command request, CancellationToken cancellationToken)
        {
            //Business logic MGG 6/20
            throw new NotImplementedException();
        }
    }
}
