using Movies.Application.Models;

namespace Movies.Application.Repository;

public interface IMovieRepository
{
    Task<IEnumerable<Movie>> GetAllAsync();
    
    Task<Movie?> GetByIdAsync(Guid id);
    
    Task<bool> CreateAsync(Movie movie);
    
    Task<bool> UpdateAsync(Movie movie);

    Task<bool> DeleteByIdAsync(Guid id);
    
    // TODO: Should we have delete all?
}