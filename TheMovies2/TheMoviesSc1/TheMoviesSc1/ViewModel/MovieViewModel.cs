using System.Collections.Generic;
using TheMoviesSc1.Model; // Sørg for at inkludere dette for at referere til Movie og MovieRepository

public class MovieViewModel
{
    private readonly MovieRepository _movieRepository;

    public List<Movie> Movies { get; set; }

    public MovieViewModel()
    {
        _movieRepository = new MovieRepository();
        Movies = new List<Movie>(_movieRepository.GetAllMovies());
    }

    public void AddMovie(Movie movie)
    {
        _movieRepository.Add(movie);
        Movies.Add(movie);  // Opdaterer UI'et
    }

    public void RemoveMovie(Movie movie)
    {
        _movieRepository.Remove(movie);
        Movies.Remove(movie);  // Opdaterer UI'et
    }
}


