using Domen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementation
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly MovieContext context;

        public ReviewRepository(MovieContext movieContext)
        {
            this.context = movieContext;
        }
        public void Add(Review entity)
        {
            if(context.Reviews.SingleOrDefault(r => r.UserId == entity.UserId && r.MovieId==entity.MovieId) == null)
            {
                int numberOfReviews = context.Reviews.Where(r => r.MovieId == entity.MovieId).ToList().Count() + 1;
                int sumOfReviews = GetSumOfReviews(entity) + entity.Rating;
                double rating = (double)sumOfReviews / numberOfReviews;

                context.Add(entity);

                Movie movie = context.Movies.SingleOrDefault(m => m.MovieId == entity.MovieId);
                movie.Rating = Math.Round(rating, 1);
                context.Movies.Update(movie);
            }
        }

        public void Delete(Review entity)
        {
            Review review = context.Reviews.SingleOrDefault(r => r.MovieId == entity.MovieId && r.UserId == entity.UserId);
            int numberOfReviews = context.Reviews.Where(r => r.MovieId == entity.MovieId).ToList().Count() - 1;
            int sumOfReviews = GetSumOfReviews(entity) - review.Rating;
            double rating = (double)sumOfReviews / numberOfReviews;

            context.Remove(review);

            Movie movie = context.Movies.SingleOrDefault(m => m.MovieId == entity.MovieId);
            movie.Rating = Math.Round(rating, 1);
            context.Movies.Update(movie);

        }


        public List<Review> Find(string text)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAll()
        {
            return context.Reviews.Include(r=>r.User).
                ToList().OfType<Review>().ToList();
        }

        public Review GetSingle(Review entity)
        {
            //var list = context.Reviews.Include(r => r.User).
            //    ToList().OfType<Review>().ToList();
            //return list.Find(r => r.MovieId == entity.MovieId && r.UserId == entity.UserId);
            throw new NotImplementedException();
        }

        public int GetSumOfReviews(Review entity)
        {
            List<Review> lista=context.Reviews.Where(r=>r.MovieId==entity.MovieId).ToList();
            int sumOfReviews = 0;
            foreach(Review r in lista)
            {
                sumOfReviews += r.Rating;
            }
            return sumOfReviews;
        }

        public bool IsRated(int userId, int movieId)
        {
            if (context.Reviews.FirstOrDefault(r => r.UserId == userId && r.MovieId == movieId) != null)
            {
                return true;
            }
            return false;
        }

        public void Update(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
