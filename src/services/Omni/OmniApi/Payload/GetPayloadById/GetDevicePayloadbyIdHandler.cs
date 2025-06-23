using Framework.CQRS;
using OmniApi.Exceptions;
using OmniApi.Models;

namespace OmniApi.Payload.GetPayloadById
{
    public record GetDevicePayloadbyIdQuery(Guid Id) :IQuery<GetDevicePayloadbyIdResult>;

    public record GetDevicePayloadbyIdResult(DevicePayload DevicePayload);
    internal class GetDevicePayloadbyIdQueryHandler(IDocumentSession session, ILogger<GetDevicePayloadbyIdQueryHandler> logger) 
        : IQueryHandler<GetDevicePayloadbyIdQuery, GetDevicePayloadbyIdResult>
        
    {
        public async Task<GetDevicePayloadbyIdResult> Handle(GetDevicePayloadbyIdQuery query, CancellationToken cancellationToken)
        {
            logger.LogInformation("Weatherford Device logs by GetPayloadsQueryHandler {@Query}", query);

            var devicePayload = await session.LoadAsync<DevicePayload>(query.Id, cancellationToken);

            if (devicePayload == null)
            {
                logger.LogWarning("Device payload with ID {Id} not found.", query.Id);
                throw new DeviceNotFoundException();
            }

            return new GetDevicePayloadbyIdResult(devicePayload);

        }
    }
}
