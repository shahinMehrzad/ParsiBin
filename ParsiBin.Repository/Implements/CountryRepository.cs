using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.Repository.Implements
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(ParsibinContext context) : base(context)
        {
        }
    }
}
