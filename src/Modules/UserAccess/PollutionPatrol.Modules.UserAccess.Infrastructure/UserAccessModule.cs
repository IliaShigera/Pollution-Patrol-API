namespace PollutionPatrol.Modules.UserAccess.Infrastructure;

internal sealed class UserAccessModule : IUserAccessModule
{
    private readonly IMediator _mediator;

    public UserAccessModule(IMediator mediator) => _mediator = mediator;

    public async Task<TResult> ExecuteCommandAsync<TResult>(ICommand<TResult> command) => await _mediator.Send(command);

    public async Task ExecuteCommandAsync(ICommand command) => await _mediator.Send(command);

    public async Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query) => await _mediator.Send(query);
}