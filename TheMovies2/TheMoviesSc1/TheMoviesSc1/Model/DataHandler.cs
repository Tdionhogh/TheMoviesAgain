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
        { get { return _fileName; } set { _fileName = value; } }

        

        public List<Movie> GetMovies(string _fileName)
		{
            List<Movie> movies = new();

            try
            {
                DataHandler handler = new();

                using (StreamReader sr = new StreamReader(_fileName))
                {
                    string line; 

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineArray = line.Split(";");

                        Movie movie = new Movie((lineArray[0]), (lineArray[1]), (lineArray[2]));

                        movies.Add(movie);
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            return movies;
        }

	

        

    }
}
