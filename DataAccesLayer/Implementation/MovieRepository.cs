using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class MovieRepository : IMovieRepository
    {

        private readonly MovieContext context;

        public MovieRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }

        public void Add(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            //return context.Movies.ToList().OfType<Movie>().ToList();

            return new List<Movie> {
                new Movie()
                {
                    Name = "test1",
                    Thumbnail = "Don't look up.jpg",
                    Synopsis = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Year = new DateTime(),
                    Rating = 8.9,
                    Genres = "Comedy, Drama, Sci-Fi",
                    Duration = 197
                },
                new Movie()
                {
                    Name = "test2",
                    Thumbnail = "Wolf of the Wall street.jpg",
                    Synopsis = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Year = new DateTime(),
                    Rating = 8.9,
                    Genres = "Comedy, Drama, Sci-Fi",
                    Duration = 197
                },
                new Movie()
                {
                    Name = "test3",
                    Thumbnail = "Don't look up.jpg",
                    Synopsis = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Year = new DateTime(),
                    Rating = 8.9,
                    Genres = "Comedy, Drama, Sci-Fi",
                    Duration = 197
                },
                new Movie()
                {
                    Name = "test3",
                    Thumbnail = "Don't look up.jpg",
                    Synopsis = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Year = new DateTime(),
                    Rating = 8.9,
                    Genres = "Comedy, Drama, Sci-Fi",
                    Duration = 197
                },
                new Movie()
                {
                    Name = "test3",
                    Thumbnail = "Don't look up.jpg",
                    Synopsis = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Year = new DateTime(),
                    Rating = 8.9,
                    Genres = "Comedy, Drama, Sci-Fi",
                    Duration = 197
                },
                new Movie()
                {
                    Name = "test3",
                    Thumbnail = "Don't look up.jpg",
                    Synopsis = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Year = new DateTime(),
                    Rating = 8.9,
                    Genres = "Comedy, Drama, Sci-Fi",
                    Duration = 197
                },
            };

        }

        public Movie GetSingle(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}
