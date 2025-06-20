using MediatR;


namespace Framework.CQRS
{
    //This interface retunrs nothing MGG 6/20/2025
    public interface ICommand<out TResponse> :IRequest<TResponse>
    {
    }


    //This interface retunrs responce MGG 6/20/2025
    public interface ICommand : ICommand<Unit>
    {
    }


}
