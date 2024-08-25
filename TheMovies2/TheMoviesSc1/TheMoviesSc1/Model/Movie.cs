namespace TheMoviesSc1.Model;


public class Movie
{
private string _name;
private string _genre;
private string _duration;

public string Name { get; set; }
public string Genre { get; set; }
public string Duration { get; set; }

public Movie(string name, string genre, string duration)
{
    this.Name = name;
    this.Genre = genre;
    this.Duration = duration;
}
}
