using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public interface IReviewRepository : IRepository<Review>
    {
        public int GetSumOfReviews(Review rev);
    }
}
