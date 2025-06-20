using Carter;
using Framework.CQRS;
using Mapster;
using MediatR;

namespace OmniApi.Payload.CapturePayload
{
    //Vertical slice architecture presentation API layer-MGG 6/20
    
    public record CaptureDevicePayload_Request(DateTime Timestamp, string DataType, double Value, List<object> Properties);
    public record CaptureDevicePayload_Response(Guid Id);

    //Adding Route as CapturePayloadEndPoint as a Carter router 6/20/2025 MGG
    public class CapturePayloadEndPoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            //Mapster mapping from Reuest Payload to Mediator Command Object 6/20/2025 MGG
            app.MapPost("/CaptureDevicePayload",
                async (CaptureDevicePayload_Request request,ISender sender) =>
                {
                    //Converting to request to Mediatr ICommand object 6/20/2025 MGG
                    var command = request.Adapt<CapturePayload_Command>();
                    //Triggering to Handler 6/20/2025 MGG
                    var result = await sender.Send(command);
                    //Mapping Handler response to Route response 6/20/2025 MGG
                    var response = result.Adapt<CapturePayload_Result>();
                    //Generating response as GUID 6/20/2025 MGG
                    return Results.Created($"/CaptureDevicePayload/{response.Id}", response);
                })
                .WithName("CaptureDevicePayload")
                .Produces<CaptureDevicePayload_Response>(StatusCodes.Status202Accepted)
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .WithSummary("Device Payload Capture")
                .WithDescription("Device Payload Capture");

            
            throw new NotImplementedException();
        }
    }
}
