using HelloWebAPI.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWebAPI.UI.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAll ();
        
        Task<Movie> GetById(int id);

        Task InsertMovie(Movie movie);
        
        Task UpdateMovie(int id, Movie movie);

        Task DeleteMovie(int id);

    }
}
