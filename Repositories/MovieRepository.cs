using MiniApiJWT.Models;

namespace MiniApiJWT.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new() { Id = 1, Title = "Eternals", Description = "The sage of eternals", Rating = 6.8 },
            new() { Id = 2, Title = "The Avengers", Description = "Marvel's The Avengers or simply The Avengers, is a 2012 American superhero film based on the Marvel Comics superhero team of the same name.", Rating = 9.8 },
            new() { Id = 3, Title = "Spiderman", Description = "The Spiderman", Rating = 8.2 },
            new() { Id = 4, Title = "The Secret Life Of Walter Mitty", Description = "The Secret Life of Walter Mitty is a 2013 American adventure comedy-drama film directed", Rating = 10.0 },
            new() { Id = 5, Title = "G.I. Joe", Description = "G.I. Joe is an American media franchise and a line of action figures owned and produced by the toy company Hasbro. ", Rating = 7.8 }
        };
    }
}
