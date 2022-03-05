using MiniApiJWT.Models;

namespace MiniApiJWT.InterfaceServices
{
    public interface IMovieService
    {
        public Movie Create(Movie movie);   
        public Movie GetMovie(int id);
        public List<Movie> List();
        public Movie Update(Movie newMovie);
        public bool Delete(int id);
    }
}
