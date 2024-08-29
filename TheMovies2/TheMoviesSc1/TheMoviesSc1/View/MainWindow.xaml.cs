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
using System.Windows.Shapes;
using TheMoviesSc1.Model;
using TheMoviesSc1.View;
using TheMoviesSc1.ViewModel;


namespace TheMoviesSc1.View

{
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();

            
        }

       

        private void RegisterFilm_Click(object sender, RoutedEventArgs e)
        {
            

            OneFrame.Navigate(new RegisterMoviePage()); 
           OneFrame.Visibility = Visibility.Visible;
            TwoFrame.Visibility = Visibility.Collapsed; 

            Introtekst.Visibility = Visibility.Hidden;
        }

        private void LaveProgram_Click(object sender, RoutedEventArgs e)
        {
            

            // Navigate to CreateCinemaProgramPage in TwoFrame
            TwoFrame.Navigate(new CreateCinemaProgramPage());
            TwoFrame.Visibility = Visibility.Visible;  // Show TwoFrame
            OneFrame.Visibility = Visibility.Collapsed; // Hide OneFrame

            // Hide the intro text
            Introtekst.Visibility = Visibility.Hidden;

        }
    }
}

