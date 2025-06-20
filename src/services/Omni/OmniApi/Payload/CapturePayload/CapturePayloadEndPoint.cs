using Carter;

namespace OmniApi.Payload.CapturePayload
{
    //Vertical slice architecture presentation API layer-MGG 6/20
    
    public record CaptureDevicePayload_Request(DateTime Timestamp, string DataType, double Value, List<object> Properties);


    public class CapturePayloadEndPoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            throw new NotImplementedException();
        }
    }
}
