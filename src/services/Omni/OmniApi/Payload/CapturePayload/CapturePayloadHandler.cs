using Framework.CQRS;
using MediatR;
using System.Windows.Input;

namespace OmniApi.Payload.CapturePayload
{
    //Inherits from Framework ICommand Class
    public record CapturePayload_Command(DateTime Timestamp, string DataType, double Value, List<object> Properties) 
        :ICommand<CapturePayload_Result>;
    public record CapturePayload_Result(Guid Id);

    //Link Payload MGG 6/20    
    internal class CapturePayloadCommandHandler 
        : ICommandHandler<CapturePayload_Command, CapturePayload_Result>
    {
        public Task<CapturePayload_Result> Handle(CapturePayload_Command command, CancellationToken cancellationToken)
        {
            //Business logic MGG 6/20
            throw new NotImplementedException();
        }
    }
}
