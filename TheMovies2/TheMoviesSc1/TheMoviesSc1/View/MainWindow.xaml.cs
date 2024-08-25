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
            Introtekst.Visibility = Visibility.Hidden;
        }
    }
}

