namespace PollutionPatrol.BuildingBlocks.Application.Exceptions;

public class InvalidRequestException : Exception
{
    public InvalidRequestException(List<string> errors, string? message = default) : base(message)
    {
        Errors = errors;
    }

    public List<string> Errors { get; }

    public override string ToString() => $"Invalid request: {Message}. Details: {String.Join(", ", Errors)}";
}