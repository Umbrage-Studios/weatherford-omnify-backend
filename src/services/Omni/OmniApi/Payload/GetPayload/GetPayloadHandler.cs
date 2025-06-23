using Framework.CQRS;
using Marten.Linq.QueryHandlers;
using OmniApi.Models;

namespace OmniApi.Payload.GetPayload
{
    public record GetPayloadsQuery():IQuery<GetPayloadsResult>;

    public record GetPayloadsResult(IEnumerable<DevicePayload> DevicePayloads);

    internal class GetPayloadsQueryHandler
        (IDocumentSession session, ILogger<GetPayloadsQueryHandler> logger) : IQueryHandler<GetPayloadsQuery, GetPayloadsResult>
    {
        public async Task<GetPayloadsResult> Handle(GetPayloadsQuery query, CancellationToken cancellationToken)
        {
            logger.LogInformation("Weatherford Device logs by GetPayloadsQueryHandler {@Query}",query);

            var DevicePayloads= await session.Query<DevicePayload>().ToListAsync(cancellationToken);

            return new GetPayloadsResult(DevicePayloads);

        }
    }
}
