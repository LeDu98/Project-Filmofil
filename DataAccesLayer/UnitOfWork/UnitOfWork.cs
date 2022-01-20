using DataAccesLayer.Implementation;
using DataAccesLayer.Interfaces;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieContext context;
        
        public UnitOfWork(MovieContext context)
        {
            this.context = context;
            ActorRepository = new ActorRepository(context);
            SiteUserRepository = new SiteUserRepository(context);
            MovieRepository = new MovieRepository(context);
            StudioRepository = new StudioRepository(context);
            StreamingServiceRepository = new StreamingServiceRepository(context);
            CountryRepository = new CountryRepository(context);
            PersonnelRepository = new PersonnelRepository(context);
            ActingRepository = new ActingRepository(context);
            PositionRepository = new PositionRepository(context);
            ReviewRepository = new ReviewRepository(context);
            GenreRepository = new GenreRepository(context);
            MovieGenreRepository = new MovieGenreRepository(context);


        }
        
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

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
