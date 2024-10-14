namespace Movies.Contracts.Responses;

public class CreateMoviesResponse
{
    public required string Title { get; init; }

    public required int YearOfRelease { get; init; }

    public required IEnumerable<string> Genre { get; init; } = Enumerable.Empty<string>();
}