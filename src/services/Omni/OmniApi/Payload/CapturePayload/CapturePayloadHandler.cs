using Framework.CQRS;
using OmniApi.Models;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace OmniApi.Payload.CapturePayload
{
    //Inherits from Framework ICommand Class
    public record CapturePayload_Command(DateTime Timestamp, string DataType, double Value, List<object> Properties) 
        :ICommand<CapturePayload_Result>;
    public record CapturePayload_Result(Guid Id);

    //Link Payload MGG 6/20    
    internal class CapturePayloadCommandHandler (IDocumentSession session)
        : ICommandHandler<CapturePayload_Command, CapturePayload_Result>
    {
        public async Task<CapturePayload_Result> Handle(CapturePayload_Command command, CancellationToken cancellationToken)
        {
            //Business logic MGG 6/20
            
            //create payload entitiy
            var devicepaylod = new DevicePayload
            {
                Timestamp = command.Timestamp,
                DataType=command.DataType,
                Value=command.Value,
                Properties=command.Properties
            };

            //Save Database

            session.Store(devicepaylod);
            await session.SaveChangesAsync(cancellationToken);
            //Return Result
            return new CapturePayload_Result((devicepaylod.Id));

            
        }
    }
}
