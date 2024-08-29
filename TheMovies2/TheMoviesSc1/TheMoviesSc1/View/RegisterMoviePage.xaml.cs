using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TheMoviesSc1.Model;

namespace TheMoviesSc1.View
{
    /// <summary>
    /// Interaction logic for RegisterMoviePage.xaml
    /// </summary>
    public partial class RegisterMoviePage : Page
    {
        private DataHandler _dataHandler;

      

        private readonly MovieViewModel _viewModel;
        public RegisterMoviePage()
        {
            InitializeComponent();
            _viewModel = new MovieViewModel();
            DataContext = _viewModel;

            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uge33-TheMovies-Team5.csv");


            _dataHandler = new DataHandler(filePath);
            LoadMoviesToDataGrid();
        }

        private void LoadMoviesToDataGrid()
        {
            try
            {
                List<Movie> movies = _dataHandler.GetMovies();
                MoviesDataGrid.ItemsSource = movies;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while loading movies: {ex.Message}"); 
               
            }
        }
        
        private void MoviesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MoviesDataGrid.SelectedItem is Movie selectedMovie)
            {
                TitleTextBox.Text = selectedMovie.Name; 
                GenreTextBox.Text = selectedMovie.Genre;
                DurationTextBox.Text = selectedMovie.Duration;
            }
        }


        private void AddFilmButton_Click(object sender, RoutedEventArgs e)
        {
            Movie newMovie = new Movie(
                TitleTextBox.Text,
                GenreTextBox.Text,
                DurationTextBox.Text);

            _viewModel.AddMovie(newMovie);
            _viewModel.SaveMovies();
            LoadMoviesToDataGrid();

            MessageBox.Show("Film added successfully!");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TitleTextBox.Clear();
            GenreTextBox.Clear();
            DurationTextBox.Clear();
        }
/*
        private void RegisterFilmButton_Click(object sender, RoutedEventArgs e)
        {

            RegisterFilmWindow registerFilmWindow = new RegisterFilmWindow();
            registerFilmWindow.Show();*/
        }
    }


