using OmniApi.Models;

namespace OmniApi.Payload.GetPayloadById
{

    public record GetDevicePayloadbyIdResponse(DevicePayload DevicePayload);
    public class GetDevicePayloadbyIdEndPoint :ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/devicepayloads/{id}", async (Guid id, ISender sender) =>
            {
                var result = await sender.Send(new GetDevicePayloadbyIdQuery(id));
                var response = result.Adapt<GetDevicePayloadbyIdResponse>();
                return Results.Ok(response);
            })
            .WithName("GetDevicePayloadById")
            .Produces<GetDevicePayloadbyIdResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Get Device Payload by ID")
            .WithDescription("Retrieves a specific Weatherford IoT device payload by its ID from the database.");
        }
    }
}
