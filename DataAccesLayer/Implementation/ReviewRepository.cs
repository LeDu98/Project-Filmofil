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
            context.Add(entity);
        }

        public void Delete(Review entity)
        {
            Review r = context.Reviews.FirstOrDefault(r => r.MovieId == entity.MovieId && r.UserId == entity.UserId);
            context.Remove(r);
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

        public void Update(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
