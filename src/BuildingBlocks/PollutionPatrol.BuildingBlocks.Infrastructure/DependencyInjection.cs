namespace PollutionPatrol.BuildingBlocks.Infrastructure;

public static class DependencyInjection
{
    public static void AddBuildingBlocks(this IServiceCollection services, IConfiguration config)
    {
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehaviour<,>));

        services.AddScoped<IDomainEventsAccessor, DomainEventsAccessor>();
        services.AddScoped<IDomainEventsDispatcher, DomainEventsDispatcher>();
        services.AddScoped<IEmailSender, EmailSender>();
    }
}