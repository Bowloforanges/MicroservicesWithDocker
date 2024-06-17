namespace Entities;

public class GenericHttpResponse
{
    public int? StatusCode { get; init; }
    public string? Message { get; init; }
    public object? Data { get; init; }
}
