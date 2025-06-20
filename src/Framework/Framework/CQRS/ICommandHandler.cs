using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.CQRS
{
    //Unit is a void represantation for Mediatr 6/20/2025 MGG
    public interface ICommandHandler<in TCommand>
        : ICommandHandler<TCommand, Unit>
        where TCommand : ICommand<Unit>
    {
        
    
    }

    //Interface generating from IRequestHandler class of Mediatr 6/20/2025 MGG
    public interface ICommandHandler<in TCommand, TResponse> 
        : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
        where TResponse:notnull

    {

    }
}
