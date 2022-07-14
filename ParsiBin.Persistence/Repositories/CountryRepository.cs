using ParsiBin.Application.Repositories;
using ParsiBin.Domain.Entities;
using ParsiBin.Persistence.Context;
using ParsiBin.Repository.BaseRepository;

namespace ParsiBin.Persistence.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(ParsibinContext context) : base(context)
        {
        }
    }
}
