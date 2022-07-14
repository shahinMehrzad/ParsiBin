using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.Persistence.Repositories
{
    public class SeasonRepository : BaseRepository<Season>, ISeasonRepository
    {
        public SeasonRepository(ParsibinContext context) : base(context)
        {
        }
    }
}
