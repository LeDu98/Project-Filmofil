using DataAccesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IActingRepository ActingRepository { get; set; }
        
        public IActorRepository ActorRepository { get; set; }
        
        public ICountryRepository CountryRepository { get; set; }
       
        public IMovieRepository MovieRepository { get; set; }
        
        public IPersonnelRepository PersonnelRepository { get; set; }
       
        public IPositionRepository PositionRepository { get; set; }
        
        public IReviewRepository ReviewRepository { get; set; }
        
        public IStreamingServiceRepository StreamingServiceRepository { get; set; }
        
        public IStudioRepository StudioRepository { get; set; }
       
        public ISiteUserRepository SiteUserRepository { get; set; }

        public IGenreRepository GenreRepository { get; set; }

        public IMovieGenreRepository MovieGenreRepository { get; set; }

        public void Save();
    }
}
