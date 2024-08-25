using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesSc1.Model
{
    public class DataHandler
    {
        private string _fileName;

        public string FileName
        { 
            get { return _fileName; } 
            set { _fileName = value; } 
        }

        public DataHandler(string filePath)
        {
            _fileName = filePath;
        }
        

        public List<Movie> GetMovies()
		{
            List<Movie> movies = new();

            try
            {

                using (StreamReader sr = new StreamReader(_fileName))
                {
                    string line; 

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineArray = line.Split(";");

                        if ( lineArray.Length>=3)
                        {
                            Movie movie = new Movie((lineArray[0]), (lineArray[1]), (lineArray[2]));

                            movies.Add(movie);
                            
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }

            return movies;
        }

    }
}
