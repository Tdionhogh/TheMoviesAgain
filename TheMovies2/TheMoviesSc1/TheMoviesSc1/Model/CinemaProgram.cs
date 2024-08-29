using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesSc1.Model
{
    class CinemaProgram
    {

        private string _cinemaName;
        private string _premiereDate;

        private string _city;

        private string _screen;

        private string _playingTime;

        private string _movieTheater;


        public string PlayingTime { get; set; }

        public string Screen { get; set; }

        public string CinemaName { get; set; }

        public string PremiereDate { get; set; }

        public string City { get; set; }

        public string MovieTheater { get; set; }

        private Movie _movie;

        public Movie Movie
        {
            get { return _movie; }
            set { _movie = value; }
        }

        public CinemaProgram(string cinemaName, string playingTime, string screen, string city, string premiereDate, Movie movie,string movieTheater)
        {
            CinemaName = cinemaName;
            PremiereDate = premiereDate;
            PlayingTime = playingTime;
            Screen = screen;
            City = city;
            _movie = movie;
        }
    }
    }
