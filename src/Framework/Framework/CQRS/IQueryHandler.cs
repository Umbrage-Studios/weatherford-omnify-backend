using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.CQRS
{
    //This Handler returns and responds 06/20/2025 MGG
    public interface IQueryHandler<in TQuery,TResponse> :IRequestHandler<TQuery,TResponse>
        where TQuery : IQuery<TResponse>
        where TResponse:notnull
    {
    }
}
