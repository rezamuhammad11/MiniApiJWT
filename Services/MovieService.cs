using MiniApiJWT.InterfaceServices;
using MiniApiJWT.Models;
using MiniApiJWT.Repositories;

namespace MiniApiJWT.Services
{
    public class MovieService : IMovieService
    {
        public Movie Create(Movie movie)
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            MovieRepository.Movies.Add(movie);

            return movie;
        }
        public Movie GetMovie(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null) return null;

            return movie;
        }
        public List<Movie> List() 
        { 
            return MovieRepository.Movies.ToList();
        }
        public Movie Update(Movie newMovie)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(o => o.Id == newMovie.Id);
            if (oldMovie == null) return null;

            oldMovie.Description = newMovie.Description;
            oldMovie.Title = newMovie.Title;
            oldMovie.Rating = newMovie.Rating;

            return newMovie;
        }
        public bool Delete(int id)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(o => o.Id == id);

            if (oldMovie is null) return false;

            MovieRepository.Movies.Remove(oldMovie);

            return true;
        }
    }
}
