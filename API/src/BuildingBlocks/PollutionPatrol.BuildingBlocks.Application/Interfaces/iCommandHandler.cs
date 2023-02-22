namespace PollutionPatrol.BuildingBlocks.Application.Interfaces;

public interface ICommandHandler<in TCommand, TResult> :
    IRequestHandler<TCommand, TResult>
    where TCommand : ICommand<TResult>
{
}

public interface iCommandHandler<in TCommand> :
    IRequestHandler<TCommand>
    where TCommand : ICommand
{
}