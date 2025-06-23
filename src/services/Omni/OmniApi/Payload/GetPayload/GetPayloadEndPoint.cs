using OmniApi.Models;

namespace OmniApi.Payload.GetPayload
{

    //public record GetPayloadRequest();

    public record GetPayloadResponse(IEnumerable<DevicePayload> DevicePayloads);
    public class GetPayloadEndPoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/devicepayloads", async (ISender sender) =>
            {
                var result = await sender.Send(new GetPayloadsQuery());

                var response = result.Adapt<GetPayloadResponse>();

                return Results.Ok(response);

            })
            .WithName("GetPayloads")
            .Produces<GetPayloadResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Get Payloads")
            .WithDescription("Retrieves all Weatherford IoT device payloads from the database.");
        }
    }        
}
