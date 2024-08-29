using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesSc1.Model
{
    public class Cinema
    {
        private string _cinemaName;
        private string _Screen;

        public string Screen { get { return _Screen; } set { _Screen = value; } }
        public string CinemaName { get { return _cinemaName; } set {_cinemaName = value; } }


    }
}
