using ParsiBin.DAL.Context;
using ParsiBin.DAL.Entities;
using ParsiBin.Repository.BaseRepository;
using ParsiBin.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.Repository.Implements
{
    public class LeagueRepository : BaseRepository<League>, ILeagueRepository
    {
        public LeagueRepository(ParsibinContext context) : base(context)
        {
        }
    }
}
