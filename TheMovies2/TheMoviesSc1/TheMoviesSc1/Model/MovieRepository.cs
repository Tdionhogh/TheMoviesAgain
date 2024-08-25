namespace TheMoviesSc1.Model;

public class MovieRepository : IMovieRepository
{
    private List<Movie> movies = new List<Movie>();

    public void Add(Movie movie)
    {
        movies.Add(movie);
    }

    public void Remove(Movie movie)
    {
        movies.Remove(movie);
    }

    public List<Movie> GetAllMovies()
    {
        return movies;
    }
}

