﻿using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.DTO.Country;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Services.BaseServices;
using ParsiBin.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mapster;

namespace ParsiBin.Services.Implements
{
    public class CountryService : BaseService<Country>, ICountryService
    {
        private readonly IBaseRepository<Country> _repo;
        public CountryService(IBaseRepository<Country> repo, ParsibinContext dbContext) : base(repo, dbContext)
        {
            _repo = repo;            
        }

        public async Task<IEnumerable<CountryDTO>> GetList()
        {
            var result = await _repo.GetList();
            return result.Adapt<List<CountryDTO>>();
        }

    }
}
