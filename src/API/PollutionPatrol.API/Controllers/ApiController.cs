namespace PollutionPatrol.API.Controllers;

[ApiController]
public class ApiController : Controller
{
    private IMediator _mediator;
    
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
}