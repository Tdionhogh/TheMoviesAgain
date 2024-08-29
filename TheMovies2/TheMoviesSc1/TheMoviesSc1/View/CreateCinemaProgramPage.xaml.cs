using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Controls;
using TheMoviesSc1.Model;
using System.IO;

namespace TheMoviesSc1.View
{
 
    public partial class CreateCinemaProgramPage : Page
    {
        private DataHandler _dataHandler;



        private readonly MovieViewModel _viewModel;

        public CreateCinemaProgramPage()
        {
            InitializeComponent();
            _viewModel = new MovieViewModel();
            DataContext = _viewModel;

            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uge33-TheMovies_Full.csv");


            _dataHandler = new DataHandler(filePath);
            LoadMoviesToDataGrid();
        }

        private void LoadMoviesToDataGrid()
        {
            try
            {
                List<Movie> movies = _dataHandler.GetMovies();
                MoviesDataGridFull.ItemsSource = movies;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while loading movies: {ex.Message}");

            }
        }

        private void MoviesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MoviesDataGridFull.SelectedItem is Movie selectedMovie)
            {               
                Title.Text = selectedMovie.Name;
                Duration.Text = selectedMovie.Name;
                Genre.Text = selectedMovie.Name;
                PlayingTime.Text = selectedMovie.Name;
                Screen.Text = selectedMovie.Name;
                Director.Text = selectedMovie.Name;
                PremiereDate.Text = selectedMovie.Name;
                MovieTheater.Text = selectedMovie.Name;
                City.Text = selectedMovie.Name;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Title.Text = "";
            Duration.Text = "";
            Genre.Text = "";
            PlayingTime.Text = "";
            Screen.Text = "";
            Director.Text = "";
            PremiereDate.Text = "";
            MovieTheater.Text = "";
            City.Text = "";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            CinemaProgram newProgram = new CinemaProgram(

                MovieTheater.Text,
                PlayingTime.Text,
                Screen.Text,
                City.Text,
                Director.Text,
                new Movie(Title.Text, Genre.Text, Duration.Text),
                PremiereDate.Text
            );

            // Save to file (CSV format for example)
            SaveToCSV(newProgram);

            // Show confirmation
            MessageBox.Show("Cinema Program saved successfully!");

            // Clear fields after saving
            ClearButton_Click(sender, e);
        }

        // Method to save CinemaProgram to a CSV file
        private void SaveToCSV(CinemaProgram program)
        {
            string filePath = "CinemaPrograms.csv"; // Define your file path

            // Using StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(filePath, true)) // true for appending to the file
            {
                // Writing data in CSV format
                writer.WriteLine($"{program.CinemaName};{program.PlayingTime};{program.Screen};{program.City};{program.PremiereDate};{program.Movie.Name};{program.Movie.Genre};{program.Movie.Duration}");
            }
        }

        private void MoviesDataGridFull_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
