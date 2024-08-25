using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesSc1.Model
{
    internal interface IMovieRepository
    {
        void Add(Movie movie);
        void Remove(Movie movie);
    
    }
}
