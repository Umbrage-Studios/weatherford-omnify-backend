using Framework.CQRS;
using Marten.Linq.QueryHandlers;
using OmniApi.Models;

namespace OmniApi.Payload.GetPayload
{
    public record GetPayloadsQuery():IQuery<GetPayloadsResult>;

    public record GetPayloadsResult(IEnumerable<DevicePayload> DevicePayloads);

    internal class GetPayloadsQueryHandler : IQueryHandler<GetPayloadsQuery, GetPayloadsResult>
    {
        public Task<GetPayloadsResult> Handle(GetPayloadsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
