﻿using IDalRepository = GestMovie.Mvc.Models.Data.Repositories.IMovieRepository;
using DalService = GestMovie.Mvc.Models.Data.Services.MovieService;

using GestMovie.Mvc.Models.Business.Entities;
using GestMovie.Mvc.Models.Business.Repositories;
using GestMovie.Mvc.Models.Business.Mappers;

namespace GestMovie.Mvc.Models.Business.Services
{
    public class MovieService : IMovieRepository
    {
        private readonly IDalRepository _repository;

        public MovieService(IDalRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Movie> Get()
        {
            return _repository.Get().Select(m => m.ToBll());
        }

        public Movie Insert(Movie movie)
        {
            return _repository.Insert(movie.ToDal()).ToBll();
        }
    }
}
