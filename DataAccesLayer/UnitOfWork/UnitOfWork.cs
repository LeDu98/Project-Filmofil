﻿using Domen;
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
        public IUserRepository UserRepository { get; set; }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}